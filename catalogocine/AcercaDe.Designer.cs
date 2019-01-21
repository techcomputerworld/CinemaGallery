namespace catalogocine
{
    partial class AcercaDe
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
            this.lbCinemaGallery = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelWeb = new System.Windows.Forms.LinkLabel();
            this.btAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCinemaGallery
            // 
            this.lbCinemaGallery.AutoSize = true;
            this.lbCinemaGallery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCinemaGallery.Location = new System.Drawing.Point(23, 29);
            this.lbCinemaGallery.Name = "lbCinemaGallery";
            this.lbCinemaGallery.Size = new System.Drawing.Size(100, 16);
            this.lbCinemaGallery.TabIndex = 0;
            this.lbCinemaGallery.Text = "Cinema Gallery";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cinema Gallery esta \r\nDiseñado y desarrollado por \r\ntechcomputerworld.com\r\nTrabaj" +
                "amos para que pueda tener\r\nun buen catalogo de peliculas\r\nCopyright Techcomputer" +
                "world.com";
            // 
            // linkLabelWeb
            // 
            this.linkLabelWeb.AutoSize = true;
            this.linkLabelWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelWeb.Location = new System.Drawing.Point(144, 29);
            this.linkLabelWeb.Name = "linkLabelWeb";
            this.linkLabelWeb.Size = new System.Drawing.Size(150, 16);
            this.linkLabelWeb.TabIndex = 2;
            this.linkLabelWeb.TabStop = true;
            this.linkLabelWeb.Text = "techcomputerworld.com";
            this.linkLabelWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWeb_LinkClicked);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(124, 222);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 3;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // AcercaDe
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 269);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.linkLabelWeb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCinemaGallery);
            this.Location = new System.Drawing.Point(200, 150);
            this.Name = "AcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AcercaDe";
            this.Load += new System.EventHandler(this.AcercaDe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCinemaGallery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelWeb;
        private System.Windows.Forms.Button btAceptar;
    }
}