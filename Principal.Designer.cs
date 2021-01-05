namespace Asuma
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.linitSesion = new System.Windows.Forms.LinkLabel();
            this.lSignOut = new System.Windows.Forms.LinkLabel();
            this.pASM = new System.Windows.Forms.PictureBox();
            this.pASUMA = new System.Windows.Forms.PictureBox();
            this.menuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bInicio = new System.Windows.Forms.Button();
            this.bEventos = new System.Windows.Forms.Button();
            this.bInfo = new System.Windows.Forms.Button();
            this.bContacto = new System.Windows.Forms.Button();
            this.lUsername = new System.Windows.Forms.Label();
            this.pUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkGesUsers = new System.Windows.Forms.LinkLabel();
            this.mcEventos = new System.Windows.Forms.MonthCalendar();
            this.bCrearNoticia = new System.Windows.Forms.Button();
            this.pNoticias = new System.Windows.Forms.Panel();
            this.pPerfil = new System.Windows.Forms.Panel();
            this.lNoticias = new System.Windows.Forms.Label();
            this.bMensajes = new System.Windows.Forms.Button();
            this.bPerfil = new System.Windows.Forms.Button();
            this.lCalendario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).BeginInit();
            this.menuFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.pPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // linitSesion
            // 
            this.linitSesion.AutoSize = true;
            this.linitSesion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linitSesion.Location = new System.Drawing.Point(322, 64);
            this.linitSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linitSesion.Name = "linitSesion";
            this.linitSesion.Size = new System.Drawing.Size(118, 18);
            this.linitSesion.TabIndex = 0;
            this.linitSesion.TabStop = true;
            this.linitSesion.Text = "Iniciar sesion";
            this.linitSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linitSesion_LinkClicked);
            // 
            // lSignOut
            // 
            this.lSignOut.AutoSize = true;
            this.lSignOut.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSignOut.Location = new System.Drawing.Point(184, 95);
            this.lSignOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSignOut.Name = "lSignOut";
            this.lSignOut.Size = new System.Drawing.Size(102, 17);
            this.lSignOut.TabIndex = 8;
            this.lSignOut.TabStop = true;
            this.lSignOut.Text = "Cerrar sesión";
            this.lSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lSignOut_LinkClicked);
            // 
            // pASM
            // 
            this.pASM.Image = ((System.Drawing.Image)(resources.GetObject("pASM.Image")));
            this.pASM.InitialImage = ((System.Drawing.Image)(resources.GetObject("pASM.InitialImage")));
            this.pASM.Location = new System.Drawing.Point(1019, 15);
            this.pASM.Margin = new System.Windows.Forms.Padding(2);
            this.pASM.Name = "pASM";
            this.pASM.Size = new System.Drawing.Size(263, 113);
            this.pASM.TabIndex = 14;
            this.pASM.TabStop = false;
            this.pASM.Paint += new System.Windows.Forms.PaintEventHandler(this.pASM_Paint);
            // 
            // pASUMA
            // 
            this.pASUMA.Image = ((System.Drawing.Image)(resources.GetObject("pASUMA.Image")));
            this.pASUMA.InitialImage = ((System.Drawing.Image)(resources.GetObject("pASUMA.InitialImage")));
            this.pASUMA.Location = new System.Drawing.Point(554, 15);
            this.pASUMA.Margin = new System.Windows.Forms.Padding(2);
            this.pASUMA.Name = "pASUMA";
            this.pASUMA.Size = new System.Drawing.Size(299, 103);
            this.pASUMA.TabIndex = 13;
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
            this.menuFlowLayoutPanel.Location = new System.Drawing.Point(22, 141);
            this.menuFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel";
            this.menuFlowLayoutPanel.Size = new System.Drawing.Size(1006, 44);
            this.menuFlowLayoutPanel.TabIndex = 12;
            this.menuFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuFlowLayoutPanel_Paint_1);
            // 
            // bInicio
            // 
            this.bInicio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bInicio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInicio.Location = new System.Drawing.Point(2, 2);
            this.bInicio.Margin = new System.Windows.Forms.Padding(2);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(95, 37);
            this.bInicio.TabIndex = 0;
            this.bInicio.Text = "Inicio";
            this.bInicio.UseVisualStyleBackColor = false;
            // 
            // bEventos
            // 
            this.bEventos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEventos.Location = new System.Drawing.Point(101, 2);
            this.bEventos.Margin = new System.Windows.Forms.Padding(2);
            this.bEventos.Name = "bEventos";
            this.bEventos.Size = new System.Drawing.Size(95, 37);
            this.bEventos.TabIndex = 1;
            this.bEventos.Text = "Eventos";
            this.bEventos.UseVisualStyleBackColor = true;
            this.bEventos.Click += new System.EventHandler(this.bEventos_Click);
            // 
            // bInfo
            // 
            this.bInfo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInfo.Location = new System.Drawing.Point(200, 2);
            this.bInfo.Margin = new System.Windows.Forms.Padding(2);
            this.bInfo.Name = "bInfo";
            this.bInfo.Size = new System.Drawing.Size(95, 37);
            this.bInfo.TabIndex = 2;
            this.bInfo.Text = "Información";
            this.bInfo.UseVisualStyleBackColor = true;
            // 
            // bContacto
            // 
            this.bContacto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bContacto.Location = new System.Drawing.Point(299, 2);
            this.bContacto.Margin = new System.Windows.Forms.Padding(2);
            this.bContacto.Name = "bContacto";
            this.bContacto.Size = new System.Drawing.Size(95, 37);
            this.bContacto.TabIndex = 3;
            this.bContacto.Text = "Contacto";
            this.bContacto.UseVisualStyleBackColor = true;
            this.bContacto.Click += new System.EventHandler(this.bContacto_Click);
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.Location = new System.Drawing.Point(183, 56);
            this.lUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(122, 26);
            this.lUsername.TabIndex = 11;
            this.lUsername.Text = "userName";
            // 
            // pUser
            // 
            this.pUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pUser.Image = ((System.Drawing.Image)(resources.GetObject("pUser.Image")));
            this.pUser.Location = new System.Drawing.Point(54, 13);
            this.pUser.Margin = new System.Windows.Forms.Padding(2);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(98, 113);
            this.pUser.TabIndex = 10;
            this.pUser.TabStop = false;
            this.pUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pUser_Paint);
            this.pUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pUser_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lCalendario);
            this.panel1.Controls.Add(this.linkGesUsers);
            this.panel1.Controls.Add(this.mcEventos);
            this.panel1.Controls.Add(this.bCrearNoticia);
            this.panel1.Controls.Add(this.pNoticias);
            this.panel1.Controls.Add(this.pPerfil);
            this.panel1.Controls.Add(this.lSignOut);
            this.panel1.Controls.Add(this.pUser);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1435, 890);
            this.panel1.TabIndex = 15;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // linkGesUsers
            // 
            this.linkGesUsers.AutoSize = true;
            this.linkGesUsers.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGesUsers.Location = new System.Drawing.Point(319, 95);
            this.linkGesUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkGesUsers.Name = "linkGesUsers";
            this.linkGesUsers.Size = new System.Drawing.Size(149, 17);
            this.linkGesUsers.TabIndex = 15;
            this.linkGesUsers.TabStop = true;
            this.linkGesUsers.Text = "Gestión de usuarios";
            // 
            // mcEventos
            // 
            this.mcEventos.Location = new System.Drawing.Point(1450, 400);
            this.mcEventos.Name = "mcEventos";
            this.mcEventos.TabIndex = 14;
            this.mcEventos.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcEventos_DateSelected);
            // 
            // bCrearNoticia
            // 
            this.bCrearNoticia.Location = new System.Drawing.Point(676, 379);
            this.bCrearNoticia.Margin = new System.Windows.Forms.Padding(2);
            this.bCrearNoticia.Name = "bCrearNoticia";
            this.bCrearNoticia.Size = new System.Drawing.Size(90, 49);
            this.bCrearNoticia.TabIndex = 13;
            this.bCrearNoticia.Text = "Crear Noticia";
            this.bCrearNoticia.UseVisualStyleBackColor = true;
            this.bCrearNoticia.Click += new System.EventHandler(this.bCrearNoticia_Click);
            // 
            // pNoticias
            // 
            this.pNoticias.AutoScroll = true;
            this.pNoticias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNoticias.Location = new System.Drawing.Point(19, 233);
            this.pNoticias.Margin = new System.Windows.Forms.Padding(2);
            this.pNoticias.Name = "pNoticias";
            this.pNoticias.Size = new System.Drawing.Size(600, 422);
            this.pNoticias.TabIndex = 12;
            this.pNoticias.Resize += new System.EventHandler(this.pNoticias_Resize);
            // 
            // pPerfil
            // 
            this.pPerfil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPerfil.Controls.Add(this.lNoticias);
            this.pPerfil.Controls.Add(this.bMensajes);
            this.pPerfil.Controls.Add(this.bPerfil);
            this.pPerfil.Location = new System.Drawing.Point(38, 115);
            this.pPerfil.Name = "pPerfil";
            this.pPerfil.Size = new System.Drawing.Size(237, 113);
            this.pPerfil.TabIndex = 11;
            this.pPerfil.Visible = false;
            this.pPerfil.MouseLeave += new System.EventHandler(this.pPerfil_MouseLeave);
            // 
            // lNoticias
            // 
            this.lNoticias.AutoSize = true;
            this.lNoticias.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNoticias.Location = new System.Drawing.Point(-22, 73);
            this.lNoticias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNoticias.Name = "lNoticias";
            this.lNoticias.Size = new System.Drawing.Size(200, 34);
            this.lNoticias.TabIndex = 16;
            this.lNoticias.Text = "Últimas noticias";
            // 
            // bMensajes
            // 
            this.bMensajes.Location = new System.Drawing.Point(31, 73);
            this.bMensajes.Name = "bMensajes";
            this.bMensajes.Size = new System.Drawing.Size(184, 23);
            this.bMensajes.TabIndex = 1;
            this.bMensajes.Text = "Mensajes Privados";
            this.bMensajes.UseVisualStyleBackColor = true;
            this.bMensajes.Click += new System.EventHandler(this.bMensajes_Click);
            this.bMensajes.MouseEnter += new System.EventHandler(this.bPerfil_MouseEnter);
            this.bMensajes.MouseLeave += new System.EventHandler(this.bPerfil_MouseLeave);
            // 
            // bPerfil
            // 
            this.bPerfil.Location = new System.Drawing.Point(31, 15);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(184, 23);
            this.bPerfil.TabIndex = 0;
            this.bPerfil.Text = "Mi perfil";
            this.bPerfil.UseVisualStyleBackColor = true;
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click);
            this.bPerfil.MouseEnter += new System.EventHandler(this.bPerfil_MouseEnter);
            this.bPerfil.MouseLeave += new System.EventHandler(this.bPerfil_MouseLeave);
            // 
            // lCalendario
            // 
            this.lCalendario.AutoSize = true;
            this.lCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCalendario.Location = new System.Drawing.Point(884, 250);
            this.lCalendario.Name = "lCalendario";
            this.lCalendario.Size = new System.Drawing.Size(126, 25);
            this.lCalendario.TabIndex = 16;
            this.lCalendario.Text = "Calendario";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.pASM);
            this.Controls.Add(this.pASUMA);
            this.Controls.Add(this.menuFlowLayoutPanel);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.linitSesion);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Resize += new System.EventHandler(this.Principal_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).EndInit();
            this.menuFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pPerfil.ResumeLayout(false);
            this.pPerfil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linitSesion;
        private System.Windows.Forms.LinkLabel lSignOut;
        private System.Windows.Forms.PictureBox pASM;
        private System.Windows.Forms.PictureBox pASUMA;
        private System.Windows.Forms.FlowLayoutPanel menuFlowLayoutPanel;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.Button bEventos;
        private System.Windows.Forms.Button bInfo;
        private System.Windows.Forms.Button bContacto;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.PictureBox pUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pPerfil;
        private System.Windows.Forms.Button bMensajes;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Panel pNoticias;
        private System.Windows.Forms.Button bCrearNoticia;
        private System.Windows.Forms.MonthCalendar mcEventos;
        private System.Windows.Forms.Label lNoticias;
        private System.Windows.Forms.LinkLabel linkGesUsers;
        private System.Windows.Forms.Label lCalendario;
    }
}