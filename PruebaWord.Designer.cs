
namespace Asuma
{
    partial class PruebaWord
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
            this.bDocumento = new System.Windows.Forms.Button();
            this.tSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bDocumento
            // 
            this.bDocumento.Location = new System.Drawing.Point(532, 153);
            this.bDocumento.Name = "bDocumento";
            this.bDocumento.Size = new System.Drawing.Size(224, 70);
            this.bDocumento.TabIndex = 0;
            this.bDocumento.Text = "PULSA";
            this.bDocumento.UseVisualStyleBackColor = true;
            this.bDocumento.Click += new System.EventHandler(this.bDocumento_Click);
            // 
            // tSalida
            // 
            this.tSalida.Location = new System.Drawing.Point(252, 277);
            this.tSalida.Name = "tSalida";
            this.tSalida.Size = new System.Drawing.Size(823, 22);
            this.tSalida.TabIndex = 1;
            // 
            // PruebaWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 549);
            this.Controls.Add(this.tSalida);
            this.Controls.Add(this.bDocumento);
            this.Name = "PruebaWord";
            this.Text = "PruebaWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDocumento;
        private System.Windows.Forms.TextBox tSalida;
    }
}