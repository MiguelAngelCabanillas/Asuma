namespace Asuma
{
    partial class Conversaciones
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
            this.tConversacion = new System.Windows.Forms.TextBox();
            this.tEnviar = new System.Windows.Forms.TextBox();
            this.bEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tConversacion
            // 
            this.tConversacion.Location = new System.Drawing.Point(96, 42);
            this.tConversacion.Multiline = true;
            this.tConversacion.Name = "tConversacion";
            this.tConversacion.ReadOnly = true;
            this.tConversacion.Size = new System.Drawing.Size(503, 317);
            this.tConversacion.TabIndex = 0;
            // 
            // tEnviar
            // 
            this.tEnviar.Location = new System.Drawing.Point(96, 385);
            this.tEnviar.MaxLength = 255;
            this.tEnviar.Name = "tEnviar";
            this.tEnviar.Size = new System.Drawing.Size(458, 20);
            this.tEnviar.TabIndex = 1;
            this.tEnviar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tEnviar_KeyPress);
            // 
            // bEnviar
            // 
            this.bEnviar.Location = new System.Drawing.Point(576, 385);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(75, 20);
            this.bEnviar.TabIndex = 2;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // Conversaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 438);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.tEnviar);
            this.Controls.Add(this.tConversacion);
            this.Name = "Conversaciones";
            this.Text = "Conversaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tConversacion;
        private System.Windows.Forms.TextBox tEnviar;
        private System.Windows.Forms.Button bEnviar;
    }
}