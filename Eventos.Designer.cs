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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eventos));
            this.bMyEvents = new System.Windows.Forms.Button();
            this.panelEventos = new System.Windows.Forms.Panel();
            this.pUser = new System.Windows.Forms.PictureBox();
            this.pASM = new System.Windows.Forms.PictureBox();
            this.pASUMA = new System.Windows.Forms.PictureBox();
            this.menuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bInicio = new System.Windows.Forms.Button();
            this.bEventos = new System.Windows.Forms.Button();
            this.bInfo = new System.Windows.Forms.Button();
            this.bContacto = new System.Windows.Forms.Button();
            this.lUsername = new System.Windows.Forms.Label();
            this.lSignOut = new System.Windows.Forms.LinkLabel();
            this.linitSesion = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).BeginInit();
            this.menuFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bMyEvents
            // 
            this.bMyEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bMyEvents.Location = new System.Drawing.Point(1469, 718);
            this.bMyEvents.Margin = new System.Windows.Forms.Padding(4);
            this.bMyEvents.Name = "bMyEvents";
            this.bMyEvents.Size = new System.Drawing.Size(169, 84);
            this.bMyEvents.TabIndex = 1;
            this.bMyEvents.Text = "Mis eventos";
            this.bMyEvents.UseVisualStyleBackColor = true;
            this.bMyEvents.Click += new System.EventHandler(this.bMyEvents_Click);
            // 
            // panelEventos
            // 
            this.panelEventos.AutoScroll = true;
            this.panelEventos.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.panelEventos.Location = new System.Drawing.Point(239, 282);
            this.panelEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEventos.Name = "panelEventos";
            this.panelEventos.Size = new System.Drawing.Size(1247, 519);
            this.panelEventos.TabIndex = 31;
            this.panelEventos.Resize += new System.EventHandler(this.panelEventos_Resize);
            // 
            // pUser
            // 
            this.pUser.Image = ((System.Drawing.Image)(resources.GetObject("pUser.Image")));
            this.pUser.Location = new System.Drawing.Point(72, 16);
            this.pUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(131, 139);
            this.pUser.TabIndex = 34;
            this.pUser.TabStop = false;
            this.pUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pUser_Paint);
            // 
            // pASM
            // 
            this.pASM.Image = ((System.Drawing.Image)(resources.GetObject("pASM.Image")));
            this.pASM.InitialImage = ((System.Drawing.Image)(resources.GetObject("pASM.InitialImage")));
            this.pASM.Location = new System.Drawing.Point(1359, 18);
            this.pASM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pASM.Name = "pASM";
            this.pASM.Size = new System.Drawing.Size(351, 139);
            this.pASM.TabIndex = 38;
            this.pASM.TabStop = false;
            this.pASM.Paint += new System.Windows.Forms.PaintEventHandler(this.pASM_Paint);
            // 
            // pASUMA
            // 
            this.pASUMA.Image = ((System.Drawing.Image)(resources.GetObject("pASUMA.Image")));
            this.pASUMA.InitialImage = ((System.Drawing.Image)(resources.GetObject("pASUMA.InitialImage")));
            this.pASUMA.Location = new System.Drawing.Point(739, 18);
            this.pASUMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pASUMA.Name = "pASUMA";
            this.pASUMA.Size = new System.Drawing.Size(399, 127);
            this.pASUMA.TabIndex = 37;
            this.pASUMA.TabStop = false;
            this.pASUMA.Paint += new System.Windows.Forms.PaintEventHandler(this.pASUMA_Paint);
            // 
            // menuFlowLayoutPanel
            // 
            this.menuFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuFlowLayoutPanel.Controls.Add(this.bInicio);
            this.menuFlowLayoutPanel.Controls.Add(this.bEventos);
            this.menuFlowLayoutPanel.Controls.Add(this.bInfo);
            this.menuFlowLayoutPanel.Controls.Add(this.bContacto);
            this.menuFlowLayoutPanel.Location = new System.Drawing.Point(29, 174);
            this.menuFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel";
            this.menuFlowLayoutPanel.Size = new System.Drawing.Size(1341, 54);
            this.menuFlowLayoutPanel.TabIndex = 36;
            // 
            // bInicio
            // 
            this.bInicio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInicio.Location = new System.Drawing.Point(3, 2);
            this.bInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(127, 46);
            this.bInicio.TabIndex = 0;
            this.bInicio.Text = "Inicio";
            this.bInicio.UseVisualStyleBackColor = true;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // bEventos
            // 
            this.bEventos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bEventos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bEventos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEventos.Location = new System.Drawing.Point(136, 2);
            this.bEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEventos.Name = "bEventos";
            this.bEventos.Size = new System.Drawing.Size(127, 46);
            this.bEventos.TabIndex = 1;
            this.bEventos.Text = "Eventos";
            this.bEventos.UseVisualStyleBackColor = false;
            this.bEventos.Click += new System.EventHandler(this.bEventos_Click);
            // 
            // bInfo
            // 
            this.bInfo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInfo.Location = new System.Drawing.Point(269, 2);
            this.bInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bInfo.Name = "bInfo";
            this.bInfo.Size = new System.Drawing.Size(127, 46);
            this.bInfo.TabIndex = 2;
            this.bInfo.Text = "Información";
            this.bInfo.UseVisualStyleBackColor = true;
            // 
            // bContacto
            // 
            this.bContacto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bContacto.Location = new System.Drawing.Point(402, 2);
            this.bContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bContacto.Name = "bContacto";
            this.bContacto.Size = new System.Drawing.Size(127, 46);
            this.bContacto.TabIndex = 3;
            this.bContacto.Text = "Contacto";
            this.bContacto.UseVisualStyleBackColor = true;
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.Location = new System.Drawing.Point(244, 69);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(159, 34);
            this.lUsername.TabIndex = 35;
            this.lUsername.Text = "userName";
            // 
            // lSignOut
            // 
            this.lSignOut.AutoSize = true;
            this.lSignOut.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSignOut.Location = new System.Drawing.Point(246, 117);
            this.lSignOut.Name = "lSignOut";
            this.lSignOut.Size = new System.Drawing.Size(122, 20);
            this.lSignOut.TabIndex = 33;
            this.lSignOut.TabStop = true;
            this.lSignOut.Text = "Cerrar sesión";
            this.lSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lSignOut_LinkClicked);
            // 
            // linitSesion
            // 
            this.linitSesion.AutoSize = true;
            this.linitSesion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linitSesion.Location = new System.Drawing.Point(429, 79);
            this.linitSesion.Name = "linitSesion";
            this.linitSesion.Size = new System.Drawing.Size(146, 25);
            this.linitSesion.TabIndex = 32;
            this.linitSesion.TabStop = true;
            this.linitSesion.Text = "Iniciar sesion";
            this.linitSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linitSesion_LinkClicked);
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pUser);
            this.Controls.Add(this.pASM);
            this.Controls.Add(this.pASUMA);
            this.Controls.Add(this.menuFlowLayoutPanel);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.lSignOut);
            this.Controls.Add(this.linitSesion);
            this.Controls.Add(this.panelEventos);
            this.Controls.Add(this.bMyEvents);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Eventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Eventos_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).EndInit();
            this.menuFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bMyEvents;
        private System.Windows.Forms.Panel panelEventos;
        private System.Windows.Forms.PictureBox pUser;
        private System.Windows.Forms.PictureBox pASM;
        private System.Windows.Forms.PictureBox pASUMA;
        private System.Windows.Forms.FlowLayoutPanel menuFlowLayoutPanel;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.Button bEventos;
        private System.Windows.Forms.Button bInfo;
        private System.Windows.Forms.Button bContacto;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.LinkLabel lSignOut;
        private System.Windows.Forms.LinkLabel linitSesion;
    }
}