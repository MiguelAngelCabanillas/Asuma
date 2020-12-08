namespace Asuma
{
    partial class Principal
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
            this.linitSesion = new System.Windows.Forms.LinkLabel();
            this.lSesionIniciada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linitSesion
            // 
            this.linitSesion.AutoSize = true;
            this.linitSesion.Location = new System.Drawing.Point(116, 20);
            this.linitSesion.Name = "linitSesion";
            this.linitSesion.Size = new System.Drawing.Size(90, 17);
            this.linitSesion.TabIndex = 0;
            this.linitSesion.TabStop = true;
            this.linitSesion.Text = "Iniciar sesion";
            this.linitSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linitSesion_LinkClicked);
            // 
            // lSesionIniciada
            // 
            this.lSesionIniciada.AutoSize = true;
            this.lSesionIniciada.Location = new System.Drawing.Point(116, 20);
            this.lSesionIniciada.Name = "lSesionIniciada";
            this.lSesionIniciada.Size = new System.Drawing.Size(103, 17);
            this.lSesionIniciada.TabIndex = 1;
            this.lSesionIniciada.Text = "Sesion iniciada";
            this.lSesionIniciada.Click += new System.EventHandler(this.lSesionIniciada_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 763);
            this.Controls.Add(this.lSesionIniciada);
            this.Controls.Add(this.linitSesion);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linitSesion;
        private System.Windows.Forms.Label lSesionIniciada;
    }
}