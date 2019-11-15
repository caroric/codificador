using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using AForge.Imaging;
using System.Timers;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Configuration;
using AForge.Math.Geometry;

namespace ProyectoCOM
{
    public partial class FormDecodificador : Form
    {
        Bitmap imagen = new Bitmap(ConfigurationManager.AppSettings["bitmap"]);
        private float hue;
        private float hue2;
        private float hue3;

        private Color color1 = new Color();
        private Color color2 = new Color();
        private Color color3 = new Color();
        private Color color4 = new Color();

        List<string> cadena_simbolos = new List<string>();
        List<string> cadena_final = new List<string>();
        
        //variables para decodificacion por deteccion de color
        bool rojo = true;
        bool verde = true;
        bool celeste = false;

        private int height;
        private int width;
        private IntPoint esquina;

        public FormDecodificador()
        {
            InitializeComponent();

            //PARA CARGAR LA IMAGEN
            using (FileStream fs = new FileStream(ConfigurationManager.AppSettings["Bitmap"], FileMode.Open, FileAccess.Read))
            {
                picture.Image = System.Drawing.Image.FromStream(fs);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            VideoCaptureDeviceForm webcamform = new VideoCaptureDeviceForm();
            webcamform.ShowDialog();
            VideoCaptureDevice webcam = new VideoCaptureDevice(webcamform.VideoDeviceMoniker);
            webcam.NewFrame += new NewFrameEventHandler(Grabar);
            webcam.Start();
            this.vspWebcam.VideoSource = webcam;
            vspWebcam.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            vspWebcam.Stop();
        }
        
        private void vspWebcam_NewFrame(object sender, ref Bitmap image)
        {
            this.Grabar(sender, new NewFrameEventArgs(image));
        }

        private void Grabar(object sender, NewFrameEventArgs frame)
        {
            Bitmap video = (Bitmap)frame.Frame.Clone();
            Bitmap temp = this.Zoom(video);

            picture.Image = temp;
            pictureBox1.Image = this.Tracker(frame, color1, "celeste");
            pictureBox2.Image = this.Tracker(frame, color2, "verde");
            pictureBox3.Image = this.Tracker(frame, color3, "rojo");
            pbTracking.Image = video;
            //-------------------------------------------------------------------------
            try
            {
                Bitmap bitmap = pbTracking.Image.Clone() as Bitmap;
                Bitmap clon = bitmap.Clone() as Bitmap;
                EuclideanColorFiltering filtro = new EuclideanColorFiltering();
                filtro.CenterColor = new AForge.Imaging.RGB(color4.R, color4.G, color4.B);
                filtro.Radius = 100;
                filtro.ApplyInPlace(bitmap);

                BlobCounter blobCounter = new BlobCounter();

                blobCounter.FilterBlobs = true;
                blobCounter.MinHeight = 50;
                blobCounter.MinWidth = 50;

                blobCounter.ProcessImage(bitmap);
                Blob[] blobs = blobCounter.GetObjectsInformation();

                SimpleShapeChecker shapeChecker = new SimpleShapeChecker();

                Graphics g = Graphics.FromImage(bitmap);
                Pen greenPen = new Pen(Color.Red, 6);
                Pen bluePen = new Pen(Color.Blue, 6);

                for (int i = 0, n = blobs.Length; i < n; i++)
                {
                    List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blobs[i]);

                    List<IntPoint> corners;

                    if (shapeChecker.IsQuadrilateral(edgePoints, out corners))
                    {
                        if (shapeChecker.CheckPolygonSubType(corners) == PolygonSubType.Rectangle)
                        {
                            g.DrawPolygon(greenPen, ToPointsArray(corners));
                            int xmin = corners[0].X;
                            int xmax = 0;
                            int ymin = corners[0].Y;
                            int ymax = 0;
                            foreach (var punto in corners)
                            {
                                if (punto.X < xmin)
                                {
                                    xmin = punto.X;
                                }
                                if (punto.X > xmax)
                                {
                                    xmax = punto.X;
                                }
                                if (punto.Y < ymin)
                                {
                                    ymin = punto.Y;
                                }
                                if (punto.Y > ymax)
                                {
                                    ymax = punto.Y;
                                }
                                if (punto.X == xmin && punto.Y == ymin)
                                {
                                    esquina = punto;
                                }
                            }
                            width = xmax - xmin;
                            height = ymax - ymin;
                        }
                    }
                }

                greenPen.Dispose();
                bluePen.Dispose();
                g.Dispose();

                pbTracking.Image = bitmap;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        private System.Drawing.Point[] ToPointsArray(List<IntPoint> points)
        {
            return points.Select(p => new System.Drawing.Point(p.X, p.Y)).ToArray();
        }

        private Bitmap Tracker(NewFrameEventArgs frame, Color color, string colorDetectado)
        {
            Bitmap copia = frame.Frame.Clone() as Bitmap;
            Bitmap temp = this.Zoom(copia);

            EuclideanColorFiltering filtro = new EuclideanColorFiltering();
            filtro.CenterColor = new AForge.Imaging.RGB(color.R, color.G, color.B);
            filtro.Radius = 100;
            filtro.ApplyInPlace(temp);

            BlobCounter blobcounter = new BlobCounter();
            blobcounter.MinWidth = 5;
            blobcounter.MinHeight = 5;
            blobcounter.FilterBlobs = true;
            blobcounter.ObjectsOrder = ObjectsOrder.Size;
            blobcounter.ProcessImage(temp);
            Rectangle[] rects = blobcounter.GetObjectsRectangles();

            if (rects.Length > 0)
            {
                Rectangle objectRect = rects[0];
                if (objectRect.Width >= 350 && objectRect.Height >= 350)
                {
                        Graphics g = Graphics.FromImage(temp);
                        using (Pen pen = new Pen(Color.FromArgb(200, 80, 0), 30))
                    {
                        g.DrawRectangle(pen, objectRect);
                        this.ProcesarColor(colorDetectado);
                    }
                    g.Dispose();
                }
            }
            return temp;
        }

        private void ProcesarColor(string color)
        {
            switch (color)
            {
                case "rojo":
                    if (rojo)
                    {
                        cadena_final.Add("-");
                        AgregarSimbolo("-");
                        rojo = false;
                        celeste = true;
                        verde = false;
                    }
                    break;
                case "verde":
                    if (verde)
                    {
                        cadena_final.Add(".");
                        AgregarSimbolo(".");
                        verde = false;
                        celeste = true;
                        rojo = false;
                    }
                    break;
                case "celeste":
                default:
                    string codigo = "";
                    if (celeste)
                    {
                        cadena_final.Add("T");
                        AgregarSimbolo("T");
                       
                        lblcaracteres.Text = cadena_final.Count.ToString();
                        if (cadena_final.Count % 10 == 0)
                        {
                            if (cadena_final.Count != 10)
                                codigo = "";
                            for (int i = cadena_final.Count - 10; i < cadena_final.Count; i++)
                            {
                                codigo += cadena_final[i];
                            }
                            lblFinal.Text = lblFinal.Text + this.Decodificar(codigo);
                        }
                        rojo = true;
                        verde = true;
                        celeste = false;
                    }
                    break;
            }
        }

        private Bitmap Zoom(Bitmap original)
        {
            Bitmap copia = new Bitmap(original.Width, original.Height);
            Graphics g = Graphics.FromImage(copia);
            int left = esquina.X + width / 3;
            int top = esquina.Y + height / 3;
            int w = width / 2;
            int h = height / 2;
            Rectangle srcRect = new Rectangle(left, top, w, h);
            Rectangle dstRect = new Rectangle(0, 0, copia.Width, copia.Height);
            g.DrawImage(original, dstRect, srcRect, GraphicsUnit.Pixel);

            return copia;
        }

        public Rectangle objectRect { get; set; }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (chkAzul.Checked)
            {
                colorDialog1.ShowDialog();
                color1 = (Color)colorDialog1.Color;
                hue = color1.GetHue();
                chkAzul.Checked = false;
            }
            if (chkVerde.Checked)
            {
                colorDialog2.ShowDialog();
                color2 = (Color)colorDialog2.Color;
                hue2 = color2.GetHue();
                chkVerde.Checked = false;
            }
            if (chkNaranja.Checked)
            {
                colorDialog3.ShowDialog();
                color3 = (Color)colorDialog3.Color;
                hue3 = color3.GetHue();
                chkNaranja.Checked = false;
            }
            if (chkPantalla.Checked)
            {
                colorDialog4.ShowDialog();
                color4 = (Color)colorDialog4.Color;
                hue = color4.GetHue();
                chkPantalla.Checked = false;
            }
        }
        
        private void AgregarSimbolo(string simbolo)
        {
            lblCadena.Text = lblCadena.Text + simbolo.ToString();
        }

        private string Decodificar(string codigo)
        {
            string letra = "";
            switch (codigo)
            {
                case ".T.T.T.T.T":
                    letra = "a";
                    break;
                case ".T.T.T.T-T":
                    letra = "b";
                    break;
                case ".T.T.T-T.T":
                    letra = "c";
                    break;
                case ".T.T.T-T-T":
                    letra = "d";
                    break;
                case ".T.T-T.T.T":
                    letra = "e";
                    break;
                case ".T.T-T.T-T":
                    letra = "f";
                    break;
                case ".T.T-T-T.T":
                    letra = "g";
                    break;
                case ".T.T-T-T-T":
                    letra = "h";
                    break;
                case ".T-T.T.T.T":
                    letra = "i";
                    break;
                case ".T-T.T.T-T":
                    letra = "j";
                    break;
                case ".T-T.T-T.T":
                    letra = "k";
                    break;
                case ".T-T.T-T-T":
                    letra = "l";
                    break;
                case ".T-T-T.T.T":
                    letra = "m";
                    break;
                case ".T-T-T.T-T":
                    letra = "n";
                    break;
                case ".T-T-T-T.T":
                    letra = "ñ";
                    break;
                case ".T-T-T-T-T":
                    letra = "o";
                    break;
                case "-T.T.T.T.T":
                    letra = "p";
                    break;
                case "-T.T.T.T-T":
                    letra = "q";
                    break;
                case "-T.T.T-T.T":
                    letra = "r";
                    break;
                case "-T.T.T-T-T":
                    letra = "s";
                    break;
                case "-T.T-T.T.T":
                    letra = "t";
                    break;
                case "-T.T-T.T-T":
                    letra = "u";
                    break;
                case "-T.T-T-T.T":
                    letra = "v";
                    break;
                case "-T.T-T-T-T":
                    letra = "w";
                    break;
                case "-T-T.T.T.T":
                    letra = "x";
                    break;
                case "-T-T.T.T-T":
                    letra = "y";
                    break;
                case "-T-T.T-T.T":
                    letra = "z";
                    break;
                case "-T-T.T-T-T":
                    letra = " ";
                    break;
                case "-T-T-T.T.T":
                    letra = ".";
                    break;
                case "-T-T-T.T-T":
                    letra = ",";
                    break;
                case "-T-T-T-T-T":
                    letra = "";
                    MessageBox.Show("Fin de mensaje.");
                    break;
                default:
                    break;
            }
            return letra;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cadena_final.Clear();
            cadena_simbolos.Clear();
            lblCadena.Text = "cadena: ";
            lblFinal.Text = "cadena final: ";
            rojo = true;
            verde = true;
            celeste = false;
        }        
    
    }
}
