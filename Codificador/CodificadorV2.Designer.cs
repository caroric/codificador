namespace ProyectoCOM
{
    partial class CodificadorV2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGenerar = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.cmbTiempo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTiempo = new System.Windows.Forms.TrackBar();
            this.lblTiempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTiempo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGenerar
            // 
            this.txtGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtGenerar.Location = new System.Drawing.Point(208, 63);
            this.txtGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenerar.Name = "txtGenerar";
            this.txtGenerar.Size = new System.Drawing.Size(1179, 27);
            this.txtGenerar.TabIndex = 4;
            this.txtGenerar.TextChanged += new System.EventHandler(this.txtGenerar_TextChanged);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblMensaje.Location = new System.Drawing.Point(16, 67);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(174, 22);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "Mensaje a codificar: ";
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.Location = new System.Drawing.Point(-2, 93);
            this.picture.Margin = new System.Windows.Forms.Padding(4);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(1626, 656);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 5;
            this.picture.TabStop = false;
            // 
            // cmbTiempo
            // 
            this.cmbTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiempo.FormattingEnabled = true;
            this.cmbTiempo.Items.AddRange(new object[] {
            "0,5",
            "1",
            "1,5",
            "2",
            "2,5",
            "3"});
            this.cmbTiempo.Location = new System.Drawing.Point(208, 6);
            this.cmbTiempo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTiempo.Name = "cmbTiempo";
            this.cmbTiempo.Size = new System.Drawing.Size(160, 24);
            this.cmbTiempo.TabIndex = 8;
            this.cmbTiempo.SelectedIndexChanged += new System.EventHandler(this.cmbTiempo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tiempo:";
            // 
            // tbTiempo
            // 
            this.tbTiempo.Location = new System.Drawing.Point(392, 6);
            this.tbTiempo.Maximum = 11;
            this.tbTiempo.Name = "tbTiempo";
            this.tbTiempo.Size = new System.Drawing.Size(174, 56);
            this.tbTiempo.TabIndex = 10;
            this.tbTiempo.Scroll += new System.EventHandler(this.tbTiempo_Scroll);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTiempo.Location = new System.Drawing.Point(573, 9);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 22);
            this.lblTiempo.TabIndex = 11;
            // 
            // CodificadorV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 746);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.tbTiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTiempo);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.txtGenerar);
            this.Controls.Add(this.lblMensaje);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CodificadorV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codificador";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTiempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGenerar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.ComboBox cmbTiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbTiempo;
        private System.Windows.Forms.Label lblTiempo;
    }
}