namespace HomePainter
{
    partial class AcercaDeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDeForm));
            this.picboxHomePainterLogo = new System.Windows.Forms.PictureBox();
            this.lblHomePainter = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDerechosReservados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxHomePainterLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxHomePainterLogo
            // 
            this.picboxHomePainterLogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxHomePainterLogo.Image")));
            this.picboxHomePainterLogo.Location = new System.Drawing.Point(12, 12);
            this.picboxHomePainterLogo.Name = "picboxHomePainterLogo";
            this.picboxHomePainterLogo.Size = new System.Drawing.Size(200, 200);
            this.picboxHomePainterLogo.TabIndex = 0;
            this.picboxHomePainterLogo.TabStop = false;
            // 
            // lblHomePainter
            // 
            this.lblHomePainter.AutoSize = true;
            this.lblHomePainter.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePainter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHomePainter.Location = new System.Drawing.Point(218, 35);
            this.lblHomePainter.Name = "lblHomePainter";
            this.lblHomePainter.Size = new System.Drawing.Size(181, 34);
            this.lblHomePainter.TabIndex = 1;
            this.lblHomePainter.Text = "HomePainter";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Franklin Gothic Heavy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(227, 69);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(63, 15);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "version 1.0";
            // 
            // lblDerechosReservados
            // 
            this.lblDerechosReservados.AutoSize = true;
            this.lblDerechosReservados.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerechosReservados.ForeColor = System.Drawing.Color.DimGray;
            this.lblDerechosReservados.Location = new System.Drawing.Point(227, 199);
            this.lblDerechosReservados.Name = "lblDerechosReservados";
            this.lblDerechosReservados.Size = new System.Drawing.Size(274, 12);
            this.lblDerechosReservados.TabIndex = 3;
            this.lblDerechosReservados.Text = "© 2017 HomeSierra Corp. Todos los derechos reservados.";
            // 
            // AcercaDeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 226);
            this.Controls.Add(this.lblDerechosReservados);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblHomePainter);
            this.Controls.Add(this.picboxHomePainterLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AcercaDeForm";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.picboxHomePainterLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxHomePainterLogo;
        private System.Windows.Forms.Label lblHomePainter;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDerechosReservados;
    }
}