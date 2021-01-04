namespace Asuma
{
    partial class ListaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaUsuarios));
            this.panelParticipantes = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelParticipantes
            // 
            this.panelParticipantes.AutoScroll = true;
            this.panelParticipantes.Location = new System.Drawing.Point(32, 24);
            this.panelParticipantes.Margin = new System.Windows.Forms.Padding(2);
            this.panelParticipantes.Name = "panelParticipantes";
            this.panelParticipantes.Size = new System.Drawing.Size(843, 501);
            this.panelParticipantes.TabIndex = 45;
            // 
            // ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(910, 553);
            this.Controls.Add(this.panelParticipantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaUsuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelParticipantes;
    }
}