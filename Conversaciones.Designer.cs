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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversaciones));
            this.tConversacion = new System.Windows.Forms.TextBox();
            this.tEnviar = new System.Windows.Forms.TextBox();
            this.bEnviar = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tConversacion
            // 
            this.tConversacion.Location = new System.Drawing.Point(128, 52);
            this.tConversacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tConversacion.Multiline = true;
            this.tConversacion.Name = "tConversacion";
            this.tConversacion.ReadOnly = true;
            this.tConversacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tConversacion.Size = new System.Drawing.Size(669, 389);
            this.tConversacion.TabIndex = 0;
            // 
            // tEnviar
            // 
            this.tEnviar.Location = new System.Drawing.Point(128, 474);
            this.tEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tEnviar.MaxLength = 255;
            this.tEnviar.Name = "tEnviar";
            this.tEnviar.Size = new System.Drawing.Size(609, 22);
            this.tEnviar.TabIndex = 1;
            this.tEnviar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tEnviar_KeyPress);
            // 
            // bEnviar
            // 
            this.bEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEnviar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnviar.Location = new System.Drawing.Point(747, 474);
            this.bEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(136, 27);
            this.bEnviar.TabIndex = 2;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(120, 11);
            this.lNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(119, 41);
            this.lNombre.TabIndex = 3;
            this.lNombre.Text = "label1";
            // 
            // Conversaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(939, 539);
            this.Controls.Add(this.tConversacion);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.tEnviar);
            this.Controls.Add(this.lNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Conversaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tConversacion;
        private System.Windows.Forms.TextBox tEnviar;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.Label lNombre;
    }
}