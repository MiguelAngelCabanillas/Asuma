namespace Asuma
{
    partial class Mensajes
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
            this.bEnviar = new System.Windows.Forms.Button();
            this.tbMensaje = new System.Windows.Forms.TextBox();
            this.lbMensajes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bEnviar
            // 
            this.bEnviar.Location = new System.Drawing.Point(79, 447);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(75, 23);
            this.bEnviar.TabIndex = 0;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // tbMensaje
            // 
            this.tbMensaje.Location = new System.Drawing.Point(207, 449);
            this.tbMensaje.Name = "tbMensaje";
            this.tbMensaje.Size = new System.Drawing.Size(407, 20);
            this.tbMensaje.TabIndex = 1;
            // 
            // lbMensajes
            // 
            this.lbMensajes.Enabled = false;
            this.lbMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensajes.FormattingEnabled = true;
            this.lbMensajes.ItemHeight = 16;
            this.lbMensajes.Location = new System.Drawing.Point(79, 56);
            this.lbMensajes.Name = "lbMensajes";
            this.lbMensajes.Size = new System.Drawing.Size(535, 324);
            this.lbMensajes.TabIndex = 2;
            // 
            // Mensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 511);
            this.Controls.Add(this.lbMensajes);
            this.Controls.Add(this.tbMensaje);
            this.Controls.Add(this.bEnviar);
            this.Name = "Mensajes";
            this.Text = "Mensajes";
            this.Load += new System.EventHandler(this.Mensajes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.TextBox tbMensaje;
        private System.Windows.Forms.ListBox lbMensajes;
    }
}