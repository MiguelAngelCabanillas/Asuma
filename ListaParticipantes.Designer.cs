
namespace Asuma
{
    partial class ListaParticipantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaParticipantes));
            this.bMensajes = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pASM = new System.Windows.Forms.PictureBox();
            this.pASUMA = new System.Windows.Forms.PictureBox();
            this.lSignOut = new System.Windows.Forms.LinkLabel();
            this.panelParticipantes = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pPerfil = new System.Windows.Forms.Panel();
            this.bPerfil = new System.Windows.Forms.Button();
            this.lUsername = new System.Windows.Forms.Label();
            this.menuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bInicio = new System.Windows.Forms.Button();
            this.bEventos = new System.Windows.Forms.Button();
            this.bInfo = new System.Windows.Forms.Button();
            this.bContacto = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pUser = new System.Windows.Forms.PictureBox();
            this.bExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).BeginInit();
            this.pPerfil.SuspendLayout();
            this.menuFlowLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            this.SuspendLayout();
            // 
            // bMensajes
            // 
            this.bMensajes.Location = new System.Drawing.Point(41, 102);
            this.bMensajes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bMensajes.Name = "bMensajes";
            this.bMensajes.Size = new System.Drawing.Size(245, 28);
            this.bMensajes.TabIndex = 1;
            this.bMensajes.Text = "Mensajes Privados";
            this.bMensajes.UseVisualStyleBackColor = true;
            this.bMensajes.Click += new System.EventHandler(this.bMensajes_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 1055);
            this.splitter1.TabIndex = 40;
            this.splitter1.TabStop = false;
            // 
            // pASM
            // 
            this.pASM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pASM.Image = ((System.Drawing.Image)(resources.GetObject("pASM.Image")));
            this.pASM.InitialImage = ((System.Drawing.Image)(resources.GetObject("pASM.InitialImage")));
            this.pASM.Location = new System.Drawing.Point(1413, 18);
            this.pASM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pASM.Name = "pASM";
            this.pASM.Size = new System.Drawing.Size(351, 139);
            this.pASM.TabIndex = 43;
            this.pASM.TabStop = false;
            this.pASM.Paint += new System.Windows.Forms.PaintEventHandler(this.pASM_Paint);
            // 
            // pASUMA
            // 
            this.pASUMA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pASUMA.Image = ((System.Drawing.Image)(resources.GetObject("pASUMA.Image")));
            this.pASUMA.InitialImage = ((System.Drawing.Image)(resources.GetObject("pASUMA.InitialImage")));
            this.pASUMA.Location = new System.Drawing.Point(795, 18);
            this.pASUMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pASUMA.Name = "pASUMA";
            this.pASUMA.Size = new System.Drawing.Size(399, 127);
            this.pASUMA.TabIndex = 42;
            this.pASUMA.TabStop = false;
            this.pASUMA.Paint += new System.Windows.Forms.PaintEventHandler(this.pASUMA_Paint);
            // 
            // lSignOut
            // 
            this.lSignOut.AutoSize = true;
            this.lSignOut.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSignOut.Location = new System.Drawing.Point(244, 117);
            this.lSignOut.Name = "lSignOut";
            this.lSignOut.Size = new System.Drawing.Size(122, 20);
            this.lSignOut.TabIndex = 45;
            this.lSignOut.TabStop = true;
            this.lSignOut.Text = "Cerrar sesión";
            this.lSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lSignOut_LinkClicked);
            // 
            // panelParticipantes
            // 
            this.panelParticipantes.AutoScroll = true;
            this.panelParticipantes.Location = new System.Drawing.Point(387, 266);
            this.panelParticipantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelParticipantes.Name = "panelParticipantes";
            this.panelParticipantes.Size = new System.Drawing.Size(1000, 796);
            this.panelParticipantes.TabIndex = 44;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pPerfil
            // 
            this.pPerfil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPerfil.Controls.Add(this.bMensajes);
            this.pPerfil.Controls.Add(this.bPerfil);
            this.pPerfil.Location = new System.Drawing.Point(65, 154);
            this.pPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pPerfil.Name = "pPerfil";
            this.pPerfil.Size = new System.Drawing.Size(315, 139);
            this.pPerfil.TabIndex = 46;
            this.pPerfil.Visible = false;
            this.pPerfil.MouseLeave += new System.EventHandler(this.pPerfil_MouseLeave);
            // 
            // bPerfil
            // 
            this.bPerfil.Location = new System.Drawing.Point(41, 31);
            this.bPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(245, 28);
            this.bPerfil.TabIndex = 0;
            this.bPerfil.Text = "Mi perfil";
            this.bPerfil.UseVisualStyleBackColor = true;
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click);
            this.bPerfil.MouseEnter += new System.EventHandler(this.bPerfil_MouseEnter);
            this.bPerfil.MouseLeave += new System.EventHandler(this.bPerfil_MouseLeave);
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.Location = new System.Drawing.Point(243, 69);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(159, 34);
            this.lUsername.TabIndex = 41;
            this.lUsername.Text = "userName";
            // 
            // menuFlowLayoutPanel
            // 
            this.menuFlowLayoutPanel.Controls.Add(this.bInicio);
            this.menuFlowLayoutPanel.Controls.Add(this.bEventos);
            this.menuFlowLayoutPanel.Controls.Add(this.bInfo);
            this.menuFlowLayoutPanel.Controls.Add(this.bContacto);
            this.menuFlowLayoutPanel.Controls.Add(this.flowLayoutPanel1);
            this.menuFlowLayoutPanel.Controls.Add(this.checkBox1);
            this.menuFlowLayoutPanel.Location = new System.Drawing.Point(28, 174);
            this.menuFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel";
            this.menuFlowLayoutPanel.Size = new System.Drawing.Size(1341, 54);
            this.menuFlowLayoutPanel.TabIndex = 39;
            // 
            // bInicio
            // 
            this.bInicio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInicio.Location = new System.Drawing.Point(3, 2);
            this.bInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(127, 46);
            this.bInicio.TabIndex = 0;
            this.bInicio.TabStop = false;
            this.bInicio.Text = "Inicio / Noticias";
            this.bInicio.UseVisualStyleBackColor = true;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // bEventos
            // 
            this.bEventos.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 52);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1405, 1024);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Noticias";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eventos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Información";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(402, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Contacto";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 1080);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pUser
            // 
            this.pUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pUser.Image = ((System.Drawing.Image)(resources.GetObject("pUser.Image")));
            this.pUser.Location = new System.Drawing.Point(71, 16);
            this.pUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(131, 139);
            this.pUser.TabIndex = 38;
            this.pUser.TabStop = false;
            this.pUser.Click += new System.EventHandler(this.pUser_MouseClick);
            this.pUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pUser_Paint);
            // 
            // bExit
            // 
            this.bExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bExit.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(2023, 1284);
            this.bExit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(244, 39);
            this.bExit.TabIndex = 47;
            this.bExit.Text = "Salir";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // ListaParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2367, 1371);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pASM);
            this.Controls.Add(this.pASUMA);
            this.Controls.Add(this.lSignOut);
            this.Controls.Add(this.panelParticipantes);
            this.Controls.Add(this.pPerfil);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.menuFlowLayoutPanel);
            this.Controls.Add(this.pUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListaParticipantes";
            this.Text = "ListaParticipantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.Resize += new System.EventHandler(this.ListaParticipantes_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).EndInit();
            this.pPerfil.ResumeLayout(false);
            this.menuFlowLayoutPanel.ResumeLayout(false);
            this.menuFlowLayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bMensajes;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pASM;
        private System.Windows.Forms.PictureBox pASUMA;
        private System.Windows.Forms.LinkLabel lSignOut;
        private System.Windows.Forms.Panel panelParticipantes;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pPerfil;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.FlowLayoutPanel menuFlowLayoutPanel;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.Button bEventos;
        private System.Windows.Forms.Button bInfo;
        private System.Windows.Forms.Button bContacto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pUser;
        private System.Windows.Forms.Button bExit;
    }
}