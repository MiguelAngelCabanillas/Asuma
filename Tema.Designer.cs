
namespace Asuma
{
    partial class Tema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tema));
            this.lTituloForo = new System.Windows.Forms.Label();
            this.lTituloTema = new System.Windows.Forms.Label();
            this.panelMensajes = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lTituloForo
            // 
            this.lTituloForo.AutoSize = true;
            this.lTituloForo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTituloForo.Location = new System.Drawing.Point(59, 41);
            this.lTituloForo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTituloForo.Name = "lTituloForo";
            this.lTituloForo.Size = new System.Drawing.Size(367, 32);
            this.lTituloForo.TabIndex = 0;
            this.lTituloForo.Text = "Titulo/Nombre del foro";
            // 
            // lTituloTema
            // 
            this.lTituloTema.AutoSize = true;
            this.lTituloTema.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTituloTema.Location = new System.Drawing.Point(61, 122);
            this.lTituloTema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTituloTema.Name = "lTituloTema";
            this.lTituloTema.Size = new System.Drawing.Size(284, 25);
            this.lTituloTema.TabIndex = 1;
            this.lTituloTema.Text = "Titulo/Nombre del tema\r\n";
            // 
            // panelMensajes
            // 
            this.panelMensajes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMensajes.Location = new System.Drawing.Point(65, 176);
            this.panelMensajes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMensajes.Name = "panelMensajes";
            this.panelMensajes.Size = new System.Drawing.Size(1663, 590);
            this.panelMensajes.TabIndex = 2;
            // 
            // Tema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 806);
            this.Controls.Add(this.panelMensajes);
            this.Controls.Add(this.lTituloTema);
            this.Controls.Add(this.lTituloForo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tema";
            this.Text = "Tema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTituloForo;
        private System.Windows.Forms.Label lTituloTema;
        private System.Windows.Forms.Panel panelMensajes;
    }
}