namespace Asuma
{
    partial class Eventos
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
            this.bCrearEvento = new System.Windows.Forms.Button();
            this.bMisEventos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bCrearEvento
            // 
            this.bCrearEvento.Location = new System.Drawing.Point(501, 463);
            this.bCrearEvento.Name = "bCrearEvento";
            this.bCrearEvento.Size = new System.Drawing.Size(83, 23);
            this.bCrearEvento.TabIndex = 0;
            this.bCrearEvento.Text = "Crear Evento";
            this.bCrearEvento.UseVisualStyleBackColor = true;
            // 
            // bMisEventos
            // 
            this.bMisEventos.Location = new System.Drawing.Point(186, 463);
            this.bMisEventos.Name = "bMisEventos";
            this.bMisEventos.Size = new System.Drawing.Size(83, 23);
            this.bMisEventos.TabIndex = 1;
            this.bMisEventos.Text = "Mis eventos";
            this.bMisEventos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(186, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 346);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bMisEventos);
            this.Controls.Add(this.bCrearEvento);
            this.Name = "Eventos";
            this.Text = "Eventos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCrearEvento;
        private System.Windows.Forms.Button bMisEventos;
        private System.Windows.Forms.Panel panel1;
    }
}