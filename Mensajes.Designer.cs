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
            this.label1 = new System.Windows.Forms.Label();
            this.bSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bEnviar
            // 
            this.bEnviar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnviar.Location = new System.Drawing.Point(107, 545);
            this.bEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(71, 28);
            this.bEnviar.TabIndex = 0;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = false;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // tbMensaje
            // 
            this.tbMensaje.Location = new System.Drawing.Point(107, 495);
            this.tbMensaje.Margin = new System.Windows.Forms.Padding(4);
            this.tbMensaje.Name = "tbMensaje";
            this.tbMensaje.Size = new System.Drawing.Size(800, 25);
            this.tbMensaje.TabIndex = 1;
            this.tbMensaje.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMensaje_KeyDown);
            // 
            // lbMensajes
            // 
            this.lbMensajes.FormattingEnabled = true;
            this.lbMensajes.HorizontalScrollbar = true;
            this.lbMensajes.ItemHeight = 16;
            this.lbMensajes.Location = new System.Drawing.Point(107, 95);
            this.lbMensajes.Margin = new System.Windows.Forms.Padding(4);
            this.lbMensajes.Name = "lbMensajes";
            this.lbMensajes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbMensajes.Size = new System.Drawing.Size(800, 372);
            this.lbMensajes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
            // 
            // bSalir
            // 
            this.bSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.Location = new System.Drawing.Point(837, 545);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(70, 28);
            this.bSalir.TabIndex = 6;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // Mensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1022, 629);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMensajes);
            this.Controls.Add(this.tbMensaje);
            this.Controls.Add(this.bEnviar);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSalir;
    }
}