
namespace Asuma
{
    partial class InfoEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoEvento));
            this.menuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bNoticias = new System.Windows.Forms.Button();
            this.bEventos = new System.Windows.Forms.Button();
            this.bInfo = new System.Windows.Forms.Button();
            this.bContacto = new System.Windows.Forms.Button();
            this.lUsername = new System.Windows.Forms.Label();
            this.pUser = new System.Windows.Forms.PictureBox();
            this.pASUMA = new System.Windows.Forms.PictureBox();
            this.pASM = new System.Windows.Forms.PictureBox();
            this.pEvento = new System.Windows.Forms.PictureBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.tDes = new System.Windows.Forms.TextBox();
            this.lOrg = new System.Windows.Forms.Label();
            this.lOrganizadores = new System.Windows.Forms.Label();
            this.lFecha = new System.Windows.Forms.Label();
            this.lFec = new System.Windows.Forms.Label();
            this.lTipoEvento = new System.Windows.Forms.Label();
            this.lTip = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.bSalir = new System.Windows.Forms.Button();
            this.menuFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // menuFlowLayoutPanel
            // 
            this.menuFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuFlowLayoutPanel.Controls.Add(this.bNoticias);
            this.menuFlowLayoutPanel.Controls.Add(this.bEventos);
            this.menuFlowLayoutPanel.Controls.Add(this.bInfo);
            this.menuFlowLayoutPanel.Controls.Add(this.bContacto);
            this.menuFlowLayoutPanel.Location = new System.Drawing.Point(29, 174);
            this.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel";
            this.menuFlowLayoutPanel.Size = new System.Drawing.Size(1342, 54);
            this.menuFlowLayoutPanel.TabIndex = 6;
            this.menuFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuFlowLayoutPanel_Paint);
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
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.Location = new System.Drawing.Point(244, 69);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(159, 34);
            this.lUsername.TabIndex = 5;
            this.lUsername.Text = "userName";
            // 
            // pUser
            // 
            this.pUser.Image = ((System.Drawing.Image)(resources.GetObject("pUser.Image")));
            this.pUser.Location = new System.Drawing.Point(90, 19);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(130, 139);
            this.pUser.TabIndex = 4;
            this.pUser.TabStop = false;
            this.pUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pUser_Paint);
            // 
            // pASUMA
            // 
            this.pASUMA.Image = ((System.Drawing.Image)(resources.GetObject("pASUMA.Image")));
            this.pASUMA.InitialImage = ((System.Drawing.Image)(resources.GetObject("pASUMA.InitialImage")));
            this.pASUMA.Location = new System.Drawing.Point(738, 19);
            this.pASUMA.Name = "pASUMA";
            this.pASUMA.Size = new System.Drawing.Size(399, 127);
            this.pASUMA.TabIndex = 8;
            this.pASUMA.TabStop = false;
            this.pASUMA.Paint += new System.Windows.Forms.PaintEventHandler(this.pASUMA_Paint);
            // 
            // pASM
            // 
            this.pASM.Image = ((System.Drawing.Image)(resources.GetObject("pASM.Image")));
            this.pASM.InitialImage = ((System.Drawing.Image)(resources.GetObject("pASM.InitialImage")));
            this.pASM.Location = new System.Drawing.Point(1359, 19);
            this.pASM.Name = "pASM";
            this.pASM.Size = new System.Drawing.Size(351, 139);
            this.pASM.TabIndex = 9;
            this.pASM.TabStop = false;
            this.pASM.Paint += new System.Windows.Forms.PaintEventHandler(this.pASM_Paint);
            // 
            // pEvento
            // 
            this.pEvento.BackColor = System.Drawing.SystemColors.Control;
            this.pEvento.Location = new System.Drawing.Point(181, 328);
            this.pEvento.Name = "pEvento";
            this.pEvento.Size = new System.Drawing.Size(355, 313);
            this.pEvento.TabIndex = 10;
            this.pEvento.TabStop = false;
            this.pEvento.Paint += new System.Windows.Forms.PaintEventHandler(this.pEvento_Paint);
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(873, 299);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(142, 46);
            this.lTitulo.TabIndex = 11;
            this.lTitulo.Text = "Título";
            // 
            // tDes
            // 
            this.tDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tDes.Location = new System.Drawing.Point(656, 383);
            this.tDes.Multiline = true;
            this.tDes.Name = "tDes";
            this.tDes.ReadOnly = true;
            this.tDes.Size = new System.Drawing.Size(836, 258);
            this.tDes.TabIndex = 12;
            // 
            // lOrg
            // 
            this.lOrg.AutoSize = true;
            this.lOrg.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrg.Location = new System.Drawing.Point(325, 730);
            this.lOrg.Name = "lOrg";
            this.lOrg.Size = new System.Drawing.Size(233, 34);
            this.lOrg.TabIndex = 13;
            this.lOrg.Text = "Organizadores:";
            // 
            // lOrganizadores
            // 
            this.lOrganizadores.AutoSize = true;
            this.lOrganizadores.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrganizadores.Location = new System.Drawing.Point(642, 736);
            this.lOrganizadores.Name = "lOrganizadores";
            this.lOrganizadores.Size = new System.Drawing.Size(454, 25);
            this.lOrganizadores.TabIndex = 14;
            this.lOrganizadores.Text = "Angel Silva, Francisco Nieto, Alberto Padilla";
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.Location = new System.Drawing.Point(642, 820);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(134, 25);
            this.lFecha.TabIndex = 16;
            this.lFecha.Text = "12/12/2012";
            // 
            // lFec
            // 
            this.lFec.AutoSize = true;
            this.lFec.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFec.Location = new System.Drawing.Point(325, 814);
            this.lFec.Name = "lFec";
            this.lFec.Size = new System.Drawing.Size(270, 34);
            this.lFec.TabIndex = 15;
            this.lFec.Text = "Fecha del evento:";
            // 
            // lTipoEvento
            // 
            this.lTipoEvento.AutoSize = true;
            this.lTipoEvento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipoEvento.Location = new System.Drawing.Point(642, 911);
            this.lTipoEvento.Name = "lTipoEvento";
            this.lTipoEvento.Size = new System.Drawing.Size(191, 25);
            this.lTipoEvento.TabIndex = 18;
            this.lTipoEvento.Text = "Dragón/Fantasma";
            // 
            // lTip
            // 
            this.lTip.AutoSize = true;
            this.lTip.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTip.Location = new System.Drawing.Point(325, 905);
            this.lTip.Name = "lTip";
            this.lTip.Size = new System.Drawing.Size(248, 34);
            this.lTip.TabIndex = 17;
            this.lTip.Text = "Tipo del evento:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 1197);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(1237, 803);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(108, 42);
            this.bSalir.TabIndex = 20;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // InfoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2013, 1197);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lTipoEvento);
            this.Controls.Add(this.lTip);
            this.Controls.Add(this.lFecha);
            this.Controls.Add(this.lFec);
            this.Controls.Add(this.lOrganizadores);
            this.Controls.Add(this.lOrg);
            this.Controls.Add(this.tDes);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.pEvento);
            this.Controls.Add(this.pASM);
            this.Controls.Add(this.pASUMA);
            this.Controls.Add(this.menuFlowLayoutPanel);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.pUser);
            this.Name = "InfoEvento";
            this.Text = "InfoEvento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel menuFlowLayoutPanel;
        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.Button bEventos;
        private System.Windows.Forms.Button bInfo;
        private System.Windows.Forms.Button bContacto;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.PictureBox pUser;
        private System.Windows.Forms.PictureBox pASUMA;
        private System.Windows.Forms.PictureBox pASM;
        private System.Windows.Forms.PictureBox pEvento;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.TextBox tDes;
        private System.Windows.Forms.Label lOrg;
        private System.Windows.Forms.Label lOrganizadores;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lFec;
        private System.Windows.Forms.Label lTipoEvento;
        private System.Windows.Forms.Label lTip;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button bSalir;
    }
}