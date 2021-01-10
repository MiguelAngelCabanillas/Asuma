
namespace Asuma
{
    partial class InfoNoticia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoNoticia));
            this.pPerfil = new System.Windows.Forms.Panel();
            this.bMensajes = new System.Windows.Forms.Button();
            this.bPerfil = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.lSignOut = new System.Windows.Forms.LinkLabel();
            this.bEditarNoticia = new System.Windows.Forms.Button();
            this.lFecha = new System.Windows.Forms.Label();
            this.lFec = new System.Windows.Forms.Label();
            this.tDes = new System.Windows.Forms.TextBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.pNoticia = new System.Windows.Forms.PictureBox();
            this.pASM = new System.Windows.Forms.PictureBox();
            this.pASUMA = new System.Windows.Forms.PictureBox();
            this.menuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bInicio = new System.Windows.Forms.Button();
            this.bEventos = new System.Windows.Forms.Button();
            this.bInfo = new System.Windows.Forms.Button();
            this.bContacto = new System.Windows.Forms.Button();
            this.lUsername = new System.Windows.Forms.Label();
            this.pUser = new System.Windows.Forms.PictureBox();
            this.linitSesion = new System.Windows.Forms.LinkLabel();
            this.pPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pNoticia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).BeginInit();
            this.menuFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pPerfil
            // 
            this.pPerfil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPerfil.Controls.Add(this.bMensajes);
            this.pPerfil.Controls.Add(this.bPerfil);
            this.pPerfil.Location = new System.Drawing.Point(64, 145);
            this.pPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.pPerfil.Name = "pPerfil";
            this.pPerfil.Size = new System.Drawing.Size(315, 139);
            this.pPerfil.TabIndex = 58;
            this.pPerfil.Visible = false;
            this.pPerfil.MouseLeave += new System.EventHandler(this.pPerfil_MouseLeave);
            // 
            // bMensajes
            // 
            this.bMensajes.Location = new System.Drawing.Point(41, 90);
            this.bMensajes.Margin = new System.Windows.Forms.Padding(4);
            this.bMensajes.Name = "bMensajes";
            this.bMensajes.Size = new System.Drawing.Size(245, 28);
            this.bMensajes.TabIndex = 1;
            this.bMensajes.Text = "Mensajes Privados";
            this.bMensajes.UseVisualStyleBackColor = true;
            this.bMensajes.Click += new System.EventHandler(this.bMensajes_Click);
            this.bMensajes.MouseEnter += new System.EventHandler(this.bPerfil_MouseEnter);
            this.bMensajes.MouseLeave += new System.EventHandler(this.bPerfil_MouseLeave);
            // 
            // bPerfil
            // 
            this.bPerfil.Location = new System.Drawing.Point(41, 18);
            this.bPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(245, 28);
            this.bPerfil.TabIndex = 0;
            this.bPerfil.Text = "Mi perfil";
            this.bPerfil.UseVisualStyleBackColor = true;
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click);
            this.bPerfil.MouseEnter += new System.EventHandler(this.bPerfil_MouseEnter);
            this.bPerfil.MouseLeave += new System.EventHandler(this.bPerfil_MouseLeave);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(1491, 926);
            this.bExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(169, 84);
            this.bExit.TabIndex = 56;
            this.bExit.Text = "Salir";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // lSignOut
            // 
            this.lSignOut.AutoSize = true;
            this.lSignOut.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSignOut.Location = new System.Drawing.Point(240, 121);
            this.lSignOut.Name = "lSignOut";
            this.lSignOut.Size = new System.Drawing.Size(122, 20);
            this.lSignOut.TabIndex = 57;
            this.lSignOut.TabStop = true;
            this.lSignOut.Text = "Cerrar sesión";
            this.lSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lSignOut_LinkClicked);
            // 
            // bEditarNoticia
            // 
            this.bEditarNoticia.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditarNoticia.Location = new System.Drawing.Point(64, 926);
            this.bEditarNoticia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEditarNoticia.Name = "bEditarNoticia";
            this.bEditarNoticia.Size = new System.Drawing.Size(169, 84);
            this.bEditarNoticia.TabIndex = 55;
            this.bEditarNoticia.Text = "Editar noticia";
            this.bEditarNoticia.UseVisualStyleBackColor = true;
            this.bEditarNoticia.Click += new System.EventHandler(this.bEditarNoticia_Click);
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.Location = new System.Drawing.Point(421, 740);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(134, 25);
            this.lFecha.TabIndex = 54;
            this.lFecha.Text = "12/12/2012";
            // 
            // lFec
            // 
            this.lFec.AutoSize = true;
            this.lFec.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFec.Location = new System.Drawing.Point(59, 734);
            this.lFec.Name = "lFec";
            this.lFec.Size = new System.Drawing.Size(296, 34);
            this.lFec.TabIndex = 53;
            this.lFec.Text = "Fecha de la noticia:";
            // 
            // tDes
            // 
            this.tDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tDes.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDes.Location = new System.Drawing.Point(540, 342);
            this.tDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tDes.Multiline = true;
            this.tDes.Name = "tDes";
            this.tDes.ReadOnly = true;
            this.tDes.Size = new System.Drawing.Size(837, 258);
            this.tDes.TabIndex = 52;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(532, 288);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(142, 46);
            this.lTitulo.TabIndex = 51;
            this.lTitulo.Text = "Título";
            // 
            // pNoticia
            // 
            this.pNoticia.BackColor = System.Drawing.SystemColors.Highlight;
            this.pNoticia.Location = new System.Drawing.Point(64, 288);
            this.pNoticia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pNoticia.Name = "pNoticia";
            this.pNoticia.Size = new System.Drawing.Size(355, 313);
            this.pNoticia.TabIndex = 50;
            this.pNoticia.TabStop = false;
            // 
            // pASM
            // 
            this.pASM.Image = ((System.Drawing.Image)(resources.GetObject("pASM.Image")));
            this.pASM.InitialImage = ((System.Drawing.Image)(resources.GetObject("pASM.InitialImage")));
            this.pASM.Location = new System.Drawing.Point(1355, 22);
            this.pASM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pASM.Name = "pASM";
            this.pASM.Size = new System.Drawing.Size(351, 139);
            this.pASM.TabIndex = 49;
            this.pASM.TabStop = false;
            this.pASM.Paint += new System.Windows.Forms.PaintEventHandler(this.pASM_Paint);
            // 
            // pASUMA
            // 
            this.pASUMA.Image = ((System.Drawing.Image)(resources.GetObject("pASUMA.Image")));
            this.pASUMA.InitialImage = ((System.Drawing.Image)(resources.GetObject("pASUMA.InitialImage")));
            this.pASUMA.Location = new System.Drawing.Point(733, 22);
            this.pASUMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pASUMA.Name = "pASUMA";
            this.pASUMA.Size = new System.Drawing.Size(399, 127);
            this.pASUMA.TabIndex = 48;
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
            this.menuFlowLayoutPanel.Location = new System.Drawing.Point(24, 178);
            this.menuFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel";
            this.menuFlowLayoutPanel.Size = new System.Drawing.Size(1341, 54);
            this.menuFlowLayoutPanel.TabIndex = 47;
            this.menuFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuFlowLayoutPanel_Paint);
            // 
            // bInicio
            // 
            this.bInicio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInicio.Location = new System.Drawing.Point(3, 2);
            this.bInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(127, 46);
            this.bInicio.TabIndex = 0;
            this.bInicio.Text = "Inicio / Noticias";
            this.bInicio.UseVisualStyleBackColor = true;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // bEventos
            // 
            this.bEventos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEventos.Location = new System.Drawing.Point(136, 2);
            this.bEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEventos.Name = "bEventos";
            this.bEventos.Size = new System.Drawing.Size(127, 46);
            this.bEventos.TabIndex = 1;
            this.bEventos.Text = "Eventos";
            this.bEventos.UseVisualStyleBackColor = true;
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
            this.bInfo.Click += new System.EventHandler(this.bInfo_Click);
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
            this.bContacto.Click += new System.EventHandler(this.bContacto_Click);
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.Location = new System.Drawing.Point(239, 73);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(159, 34);
            this.lUsername.TabIndex = 46;
            this.lUsername.Text = "userName";
            // 
            // pUser
            // 
            this.pUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pUser.Image = ((System.Drawing.Image)(resources.GetObject("pUser.Image")));
            this.pUser.Location = new System.Drawing.Point(85, 22);
            this.pUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(131, 139);
            this.pUser.TabIndex = 45;
            this.pUser.TabStop = false;
            this.pUser.Click += new System.EventHandler(this.pUser_MouseClick);
            this.pUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pUser_Paint);
            // 
            // linitSesion
            // 
            this.linitSesion.AutoSize = true;
            this.linitSesion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linitSesion.Location = new System.Drawing.Point(421, 79);
            this.linitSesion.Name = "linitSesion";
            this.linitSesion.Size = new System.Drawing.Size(146, 25);
            this.linitSesion.TabIndex = 59;
            this.linitSesion.TabStop = true;
            this.linitSesion.Text = "Iniciar sesion";
            this.linitSesion.Click += new System.EventHandler(this.linitSesion_Click);
            // 
            // InfoNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 1061);
            this.Controls.Add(this.linitSesion);
            this.Controls.Add(this.pPerfil);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.lSignOut);
            this.Controls.Add(this.bEditarNoticia);
            this.Controls.Add(this.lFecha);
            this.Controls.Add(this.lFec);
            this.Controls.Add(this.tDes);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.pNoticia);
            this.Controls.Add(this.pASM);
            this.Controls.Add(this.pASUMA);
            this.Controls.Add(this.menuFlowLayoutPanel);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.pUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InfoNoticia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoNoticia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfoNoticia_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.Resize += new System.EventHandler(this.InfoNoticia_Resize);
            this.pPerfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pNoticia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).EndInit();
            this.menuFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pPerfil;
        private System.Windows.Forms.Button bMensajes;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.LinkLabel lSignOut;
        private System.Windows.Forms.Button bEditarNoticia;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lFec;
        private System.Windows.Forms.TextBox tDes;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.PictureBox pNoticia;
        private System.Windows.Forms.PictureBox pASM;
        private System.Windows.Forms.PictureBox pASUMA;
        private System.Windows.Forms.FlowLayoutPanel menuFlowLayoutPanel;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.Button bEventos;
        private System.Windows.Forms.Button bInfo;
        private System.Windows.Forms.Button bContacto;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.PictureBox pUser;
        private System.Windows.Forms.LinkLabel linitSesion;
    }
}