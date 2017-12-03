namespace TSEReader
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InitialNumber = new System.Windows.Forms.TextBox();
            this.LastNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InitButton = new System.Windows.Forms.Button();
            this.InitTime = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ImagesDownload = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Directory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TSEReader.Properties.Resources.alianza2;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde MER#";
            // 
            // InitialNumber
            // 
            this.InitialNumber.Location = new System.Drawing.Point(109, 155);
            this.InitialNumber.Name = "InitialNumber";
            this.InitialNumber.Size = new System.Drawing.Size(75, 22);
            this.InitialNumber.TabIndex = 2;
            this.InitialNumber.Text = "1";
            // 
            // LastNumber
            // 
            this.LastNumber.Location = new System.Drawing.Point(283, 155);
            this.LastNumber.Name = "LastNumber";
            this.LastNumber.Size = new System.Drawing.Size(100, 22);
            this.LastNumber.TabIndex = 4;
            this.LastNumber.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta MER#";
            // 
            // InitButton
            // 
            this.InitButton.Location = new System.Drawing.Point(413, 245);
            this.InitButton.Name = "InitButton";
            this.InitButton.Size = new System.Drawing.Size(95, 35);
            this.InitButton.TabIndex = 5;
            this.InitButton.Text = "Iniciar";
            this.InitButton.UseVisualStyleBackColor = true;
            this.InitButton.Click += new System.EventHandler(this.InitButton_Click);
            // 
            // InitTime
            // 
            this.InitTime.AutoSize = true;
            this.InitTime.Location = new System.Drawing.Point(12, 254);
            this.InitTime.Name = "InitTime";
            this.InitTime.Size = new System.Drawing.Size(44, 17);
            this.InitTime.TabIndex = 6;
            this.InitTime.Text = "Inicio:";
            // 
            // EndTime
            // 
            this.EndTime.AutoSize = true;
            this.EndTime.Location = new System.Drawing.Point(151, 254);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(31, 17);
            this.EndTime.TabIndex = 7;
            this.EndTime.Text = "Fin:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(514, 245);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(95, 35);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Salir";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descargar imagenes:";
            // 
            // ImagesDownload
            // 
            this.ImagesDownload.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImagesDownload.FormattingEnabled = true;
            this.ImagesDownload.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.ImagesDownload.Location = new System.Drawing.Point(538, 155);
            this.ImagesDownload.Name = "ImagesDownload";
            this.ImagesDownload.Size = new System.Drawing.Size(71, 24);
            this.ImagesDownload.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Directorio Imagenes:";
            // 
            // Directory
            // 
            this.Directory.Location = new System.Drawing.Point(154, 187);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(411, 22);
            this.Directory.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Directory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ImagesDownload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.InitTime);
            this.Controls.Add(this.InitButton);
            this.Controls.Add(this.LastNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InitialNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lector de Datos TSE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InitialNumber;
        private System.Windows.Forms.TextBox LastNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InitButton;
        private System.Windows.Forms.Label InitTime;
        private System.Windows.Forms.Label EndTime;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ImagesDownload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Directory;
        private System.Windows.Forms.Button button1;
    }
}

