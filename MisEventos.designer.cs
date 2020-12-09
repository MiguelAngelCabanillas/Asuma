
namespace Asuma
{
    partial class MisEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MisEventos));
            this.pUser = new System.Windows.Forms.PictureBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.menuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bNoticias = new System.Windows.Forms.Button();
            this.bEventos = new System.Windows.Forms.Button();
            this.bInfo = new System.Windows.Forms.Button();
            this.bContacto = new System.Windows.Forms.Button();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.bMisEventos = new System.Windows.Forms.Button();
            this.bCrearEvento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            this.menuFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pUser
            // 
            this.pUser.Image = ((System.Drawing.Image)(resources.GetObject("pUser.Image")));
            this.pUser.Location = new System.Drawing.Point(25, 22);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(80, 77);
            this.pUser.TabIndex = 0;
            this.pUser.TabStop = false;
            this.pUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pUser_Paint);
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(124, 51);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(73, 17);
            this.lUsername.TabIndex = 1;
            this.lUsername.Text = "userName";
            // 
            // menuFlowLayoutPanel
            // 
            this.menuFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuFlowLayoutPanel.Controls.Add(this.bNoticias);
            this.menuFlowLayoutPanel.Controls.Add(this.bEventos);
            this.menuFlowLayoutPanel.Controls.Add(this.bInfo);
            this.menuFlowLayoutPanel.Controls.Add(this.bContacto);
            this.menuFlowLayoutPanel.Location = new System.Drawing.Point(25, 116);
            this.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel";
            this.menuFlowLayoutPanel.Size = new System.Drawing.Size(1342, 54);
            this.menuFlowLayoutPanel.TabIndex = 2;
            this.menuFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // bNoticias
            // 
            this.bNoticias.Location = new System.Drawing.Point(3, 3);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(127, 45);
            this.bNoticias.TabIndex = 0;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            // 
            // bEventos
            // 
            this.bEventos.Location = new System.Drawing.Point(136, 3);
            this.bEventos.Name = "bEventos";
            this.bEventos.Size = new System.Drawing.Size(127, 45);
            this.bEventos.TabIndex = 1;
            this.bEventos.Text = "Eventos";
            this.bEventos.UseVisualStyleBackColor = true;
            // 
            // bInfo
            // 
            this.bInfo.Location = new System.Drawing.Point(269, 3);
            this.bInfo.Name = "bInfo";
            this.bInfo.Size = new System.Drawing.Size(127, 45);
            this.bInfo.TabIndex = 2;
            this.bInfo.Text = "Información";
            this.bInfo.UseVisualStyleBackColor = true;
            // 
            // bContacto
            // 
            this.bContacto.Location = new System.Drawing.Point(402, 3);
            this.bContacto.Name = "bContacto";
            this.bContacto.Size = new System.Drawing.Size(127, 45);
            this.bContacto.TabIndex = 3;
            this.bContacto.Text = "Contacto";
            this.bContacto.UseVisualStyleBackColor = true;
            // 
            // pLogo
            // 
            this.pLogo.Image = ((System.Drawing.Image)(resources.GetObject("pLogo.Image")));
            this.pLogo.Location = new System.Drawing.Point(522, 30);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(479, 69);
            this.pLogo.TabIndex = 3;
            this.pLogo.TabStop = false;
            this.pLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pLogo_Paint);
            // 
            // bMisEventos
            // 
            this.bMisEventos.Location = new System.Drawing.Point(25, 586);
            this.bMisEventos.Name = "bMisEventos";
            this.bMisEventos.Size = new System.Drawing.Size(148, 43);
            this.bMisEventos.TabIndex = 4;
            this.bMisEventos.Text = "Mis Eventos";
            this.bMisEventos.UseVisualStyleBackColor = true;
            this.bMisEventos.Paint += new System.Windows.Forms.PaintEventHandler(this.bMisEventos_Paint);
            // 
            // bCrearEvento
            // 
            this.bCrearEvento.Location = new System.Drawing.Point(1219, 586);
            this.bCrearEvento.Name = "bCrearEvento";
            this.bCrearEvento.Size = new System.Drawing.Size(148, 43);
            this.bCrearEvento.TabIndex = 5;
            this.bCrearEvento.Text = "Crear Evento";
            this.bCrearEvento.UseVisualStyleBackColor = true;
            this.bCrearEvento.Paint += new System.Windows.Forms.PaintEventHandler(this.bCrearEvento_Paint);
            // 
            // MisEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1391, 658);
            this.Controls.Add(this.bCrearEvento);
            this.Controls.Add(this.bMisEventos);
            this.Controls.Add(this.pLogo);
            this.Controls.Add(this.menuFlowLayoutPanel);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.pUser);
            this.Name = "MisEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MisEventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MisEventos_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MisEventos_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            this.menuFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pUser;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.FlowLayoutPanel menuFlowLayoutPanel;
        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.Button bEventos;
        private System.Windows.Forms.Button bInfo;
        private System.Windows.Forms.Button bContacto;
        private System.Windows.Forms.PictureBox pLogo;
        private System.Windows.Forms.Button bMisEventos;
        private System.Windows.Forms.Button bCrearEvento;
    }
}