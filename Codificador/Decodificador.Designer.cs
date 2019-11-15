
namespace ProyectoCOM
{
    partial class FormDecodificador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.vspWebcam = new AForge.Controls.VideoSourcePlayer();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new AForge.Controls.PictureBox();
            this.chkAzul = new System.Windows.Forms.CheckBox();
            this.chkNaranja = new System.Windows.Forms.CheckBox();
            this.chkVerde = new System.Windows.Forms.CheckBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.pictureBox2 = new AForge.Controls.PictureBox();
            this.pictureBox3 = new AForge.Controls.PictureBox();
            this.lblCadena = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog4 = new System.Windows.Forms.ColorDialog();
            this.colorDialog5 = new System.Windows.Forms.ColorDialog();
            this.lblcaracteres = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbTracking = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPantalla = new System.Windows.Forms.CheckBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.pbRecepcion = new AForge.Controls.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTracking)).BeginInit();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecepcion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(452, 20);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(215, 37);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar transmisión";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.Location = new System.Drawing.Point(452, 63);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(215, 37);
            this.btnDetener.TabIndex = 3;
            this.btnDetener.Text = "Detener transmisión";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(924, 135);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(222, 216);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 4;
            this.picture.TabStop = false;
            // 
            // vspWebcam
            // 
            this.vspWebcam.Location = new System.Drawing.Point(12, 135);
            this.vspWebcam.Name = "vspWebcam";
            this.vspWebcam.Size = new System.Drawing.Size(222, 216);
            this.vspWebcam.TabIndex = 2;
            this.vspWebcam.Text = "videoSourcePlayer1";
            this.vspWebcam.VideoSource = null;
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(214, 20);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(97, 63);
            this.btnColor.TabIndex = 12;
            this.btnColor.Text = "Elegir Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(240, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // chkAzul
            // 
            this.chkAzul.AutoSize = true;
            this.chkAzul.Location = new System.Drawing.Point(15, 18);
            this.chkAzul.Name = "chkAzul";
            this.chkAzul.Size = new System.Drawing.Size(80, 17);
            this.chkAzul.TabIndex = 15;
            this.chkAzul.Text = "AMARILLO";
            this.chkAzul.UseVisualStyleBackColor = true;
            // 
            // chkNaranja
            // 
            this.chkNaranja.AutoSize = true;
            this.chkNaranja.Location = new System.Drawing.Point(15, 63);
            this.chkNaranja.Name = "chkNaranja";
            this.chkNaranja.Size = new System.Drawing.Size(55, 17);
            this.chkNaranja.TabIndex = 16;
            this.chkNaranja.Text = "ROJO";
            this.chkNaranja.UseVisualStyleBackColor = true;
            // 
            // chkVerde
            // 
            this.chkVerde.AutoSize = true;
            this.chkVerde.Location = new System.Drawing.Point(15, 41);
            this.chkVerde.Name = "chkVerde";
            this.chkVerde.Size = new System.Drawing.Size(54, 17);
            this.chkVerde.TabIndex = 17;
            this.chkVerde.Text = "AZUL";
            this.chkVerde.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = null;
            this.pictureBox2.Location = new System.Drawing.Point(471, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(222, 216);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = null;
            this.pictureBox3.Location = new System.Drawing.Point(696, 135);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(222, 216);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // lblCadena
            // 
            this.lblCadena.AutoSize = true;
            this.lblCadena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblCadena.Location = new System.Drawing.Point(12, 382);
            this.lblCadena.Name = "lblCadena";
            this.lblCadena.Size = new System.Drawing.Size(81, 20);
            this.lblCadena.TabIndex = 24;
            this.lblCadena.Text = "cadena: ";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblFinal.Location = new System.Drawing.Point(12, 413);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(123, 20);
            this.lblFinal.TabIndex = 25;
            this.lblFinal.Text = "cadena final: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Amarillo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Azul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(799, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Rojo";
            // 
            // lblcaracteres
            // 
            this.lblcaracteres.AutoSize = true;
            this.lblcaracteres.Location = new System.Drawing.Point(1010, 388);
            this.lblcaracteres.Name = "lblcaracteres";
            this.lblcaracteres.Size = new System.Drawing.Size(35, 13);
            this.lblcaracteres.TabIndex = 31;
            this.lblcaracteres.Text = "label1";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(729, 22);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 78);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbTracking
            // 
            this.pbTracking.Location = new System.Drawing.Point(1152, 135);
            this.pbTracking.Name = "pbTracking";
            this.pbTracking.Size = new System.Drawing.Size(222, 216);
            this.pbTracking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTracking.TabIndex = 33;
            this.pbTracking.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1249, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tracking";
            // 
            // chkPantalla
            // 
            this.chkPantalla.AutoSize = true;
            this.chkPantalla.Location = new System.Drawing.Point(15, 87);
            this.chkPantalla.Name = "chkPantalla";
            this.chkPantalla.Size = new System.Drawing.Size(146, 17);
            this.chkPantalla.TabIndex = 35;
            this.chkPantalla.Text = "CONTORNO PANTALLA";
            this.chkPantalla.UseVisualStyleBackColor = true;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.chkAzul);
            this.gbFiltros.Controls.Add(this.chkPantalla);
            this.gbFiltros.Controls.Add(this.chkNaranja);
            this.gbFiltros.Controls.Add(this.chkVerde);
            this.gbFiltros.ForeColor = System.Drawing.Color.Black;
            this.gbFiltros.Location = new System.Drawing.Point(12, 10);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(2);
            this.gbFiltros.Size = new System.Drawing.Size(175, 109);
            this.gbFiltros.TabIndex = 37;
            this.gbFiltros.TabStop = false;
            // 
            // pbRecepcion
            // 
            this.pbRecepcion.Image = null;
            this.pbRecepcion.Location = new System.Drawing.Point(273, 388);
            this.pbRecepcion.Name = "pbRecepcion";
            this.pbRecepcion.Size = new System.Drawing.Size(1000, 1000);
            this.pbRecepcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRecepcion.TabIndex = 38;
            this.pbRecepcion.TabStop = false;
            this.pbRecepcion.Visible = false;
            // 
            // FormDecodificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.pbRecepcion);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbTracking);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblcaracteres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblCadena);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.vspWebcam);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnIniciar);
            this.Name = "FormDecodificador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decodificador";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTracking)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecepcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.PictureBox picture;
        private AForge.Controls.VideoSourcePlayer vspWebcam;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private AForge.Controls.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkAzul;
        private System.Windows.Forms.CheckBox chkNaranja;
        private System.Windows.Forms.CheckBox chkVerde;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private AForge.Controls.PictureBox pictureBox2;
        private AForge.Controls.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblCadena;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog4;
        private System.Windows.Forms.ColorDialog colorDialog5;
        private System.Windows.Forms.Label lblcaracteres;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pbTracking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkPantalla;
        private System.Windows.Forms.GroupBox gbFiltros;
        private AForge.Controls.PictureBox pbRecepcion;
    }
}

