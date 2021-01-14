
namespace Asuma
{
    partial class CrearNoticia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearNoticia));
            this.tImage = new System.Windows.Forms.TextBox();
            this.bMensajes = new System.Windows.Forms.Button();
            this.tTitle = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.bExit = new System.Windows.Forms.Button();
            this.bCrearNoticia = new System.Windows.Forms.Button();
            this.lSignOut = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pImage = new System.Windows.Forms.PictureBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.tDescription = new System.Windows.Forms.TextBox();
            this.bEscogerImg = new System.Windows.Forms.Button();
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
            this.pASM = new System.Windows.Forms.PictureBox();
            this.pASUMA = new System.Windows.Forms.PictureBox();
            this.pUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).BeginInit();
            this.pPerfil.SuspendLayout();
            this.menuFlowLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tImage
            // 
            this.tImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tImage.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tImage.Location = new System.Drawing.Point(77, 335);
            this.tImage.Margin = new System.Windows.Forms.Padding(2);
            this.tImage.Name = "tImage";
            this.tImage.Size = new System.Drawing.Size(170, 20);
            this.tImage.TabIndex = 31;
            this.tImage.TextChanged += new System.EventHandler(this.tImage_TextChanged);
            // 
            // bMensajes
            // 
            this.bMensajes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMensajes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMensajes.Location = new System.Drawing.Point(31, 73);
            this.bMensajes.Name = "bMensajes";
            this.bMensajes.Size = new System.Drawing.Size(196, 31);
            this.bMensajes.TabIndex = 1;
            this.bMensajes.Text = "Mensajes Privados";
            this.bMensajes.UseVisualStyleBackColor = true;
            this.bMensajes.Click += new System.EventHandler(this.bMensajes_Click);
            this.bMensajes.MouseEnter += new System.EventHandler(this.bPerfil_MouseEnter);
            this.bMensajes.MouseLeave += new System.EventHandler(this.pPerfil_MouseLeave);
            // 
            // tTitle
            // 
            this.tTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tTitle.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTitle.Location = new System.Drawing.Point(478, 106);
            this.tTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tTitle.MaxLength = 40;
            this.tTitle.Name = "tTitle";
            this.tTitle.Size = new System.Drawing.Size(270, 20);
            this.tTitle.TabIndex = 9;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 857);
            this.splitter1.TabIndex = 40;
            this.splitter1.TabStop = false;
            // 
            // bExit
            // 
            this.bExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(554, 421);
            this.bExit.Margin = new System.Windows.Forms.Padding(2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(137, 26);
            this.bExit.TabIndex = 30;
            this.bExit.Text = "Salir";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bCrearNoticia
            // 
            this.bCrearNoticia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bCrearNoticia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCrearNoticia.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrearNoticia.Location = new System.Drawing.Point(77, 421);
            this.bCrearNoticia.Margin = new System.Windows.Forms.Padding(2);
            this.bCrearNoticia.Name = "bCrearNoticia";
            this.bCrearNoticia.Size = new System.Drawing.Size(137, 26);
            this.bCrearNoticia.TabIndex = 29;
            this.bCrearNoticia.Text = "Crear noticia";
            this.bCrearNoticia.UseVisualStyleBackColor = true;
            this.bCrearNoticia.Click += new System.EventHandler(this.bCrearNoticia_Click);
            // 
            // lSignOut
            // 
            this.lSignOut.AutoSize = true;
            this.lSignOut.BackColor = System.Drawing.Color.Transparent;
            this.lSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lSignOut.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSignOut.Location = new System.Drawing.Point(177, 99);
            this.lSignOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSignOut.Name = "lSignOut";
            this.lSignOut.Size = new System.Drawing.Size(102, 17);
            this.lSignOut.TabIndex = 45;
            this.lSignOut.TabStop = true;
            this.lSignOut.Text = "Cerrar sesión";
            this.lSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lSignOut_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pImage);
            this.panel1.Controls.Add(this.tImage);
            this.panel1.Controls.Add(this.bExit);
            this.panel1.Controls.Add(this.tTitle);
            this.panel1.Controls.Add(this.bCrearNoticia);
            this.panel1.Controls.Add(this.lTitle);
            this.panel1.Controls.Add(this.lDescription);
            this.panel1.Controls.Add(this.tDescription);
            this.panel1.Controls.Add(this.bEscogerImg);
            this.panel1.Location = new System.Drawing.Point(285, 230);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 503);
            this.panel1.TabIndex = 44;
            // 
            // pImage
            // 
            this.pImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pImage.BackColor = System.Drawing.SystemColors.Highlight;
            this.pImage.Location = new System.Drawing.Point(77, 0);
            this.pImage.Margin = new System.Windows.Forms.Padding(2);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(275, 236);
            this.pImage.TabIndex = 12;
            this.pImage.TabStop = false;
            // 
            // lTitle
            // 
            this.lTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(403, 99);
            this.lTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(74, 23);
            this.lTitle.TabIndex = 8;
            this.lTitle.Text = "Título:";
            // 
            // lDescription
            // 
            this.lDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDescription.AutoSize = true;
            this.lDescription.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescription.Location = new System.Drawing.Point(404, 241);
            this.lDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(131, 23);
            this.lDescription.TabIndex = 11;
            this.lDescription.Text = "Descripción:";
            // 
            // tDescription
            // 
            this.tDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tDescription.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescription.Location = new System.Drawing.Point(406, 288);
            this.tDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tDescription.MaxLength = 300;
            this.tDescription.Multiline = true;
            this.tDescription.Name = "tDescription";
            this.tDescription.Size = new System.Drawing.Size(341, 66);
            this.tDescription.TabIndex = 10;
            // 
            // bEscogerImg
            // 
            this.bEscogerImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bEscogerImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEscogerImg.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEscogerImg.Location = new System.Drawing.Point(77, 288);
            this.bEscogerImg.Margin = new System.Windows.Forms.Padding(2);
            this.bEscogerImg.Name = "bEscogerImg";
            this.bEscogerImg.Size = new System.Drawing.Size(169, 34);
            this.bEscogerImg.TabIndex = 32;
            this.bEscogerImg.Text = "Escoger imagen";
            this.bEscogerImg.UseVisualStyleBackColor = true;
            this.bEscogerImg.Click += new System.EventHandler(this.bEscogerImg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pPerfil
            // 
            this.pPerfil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPerfil.Controls.Add(this.bMensajes);
            this.pPerfil.Controls.Add(this.bPerfil);
            this.pPerfil.Location = new System.Drawing.Point(38, 115);
            this.pPerfil.Name = "pPerfil";
            this.pPerfil.Size = new System.Drawing.Size(252, 112);
            this.pPerfil.TabIndex = 46;
            this.pPerfil.Visible = false;
            this.pPerfil.MouseLeave += new System.EventHandler(this.pPerfil_MouseLeave);
            // 
            // bPerfil
            // 
            this.bPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPerfil.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPerfil.Location = new System.Drawing.Point(31, 15);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(196, 31);
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
            this.lUsername.Location = new System.Drawing.Point(176, 60);
            this.lUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(122, 26);
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
            this.menuFlowLayoutPanel.Location = new System.Drawing.Point(15, 145);
            this.menuFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel";
            this.menuFlowLayoutPanel.Size = new System.Drawing.Size(1006, 44);
            this.menuFlowLayoutPanel.TabIndex = 39;
            this.menuFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuFlowLayoutPanel_Paint);
            // 
            // bInicio
            // 
            this.bInicio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bInicio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bInicio.Location = new System.Drawing.Point(2, 2);
            this.bInicio.Margin = new System.Windows.Forms.Padding(2);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(95, 37);
            this.bInicio.TabIndex = 0;
            this.bInicio.Text = "Inicio / Noticias";
            this.bInicio.UseVisualStyleBackColor = false;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // bEventos
            // 
            this.bEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEventos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInfo.Location = new System.Drawing.Point(200, 2);
            this.bInfo.Margin = new System.Windows.Forms.Padding(2);
            this.bInfo.Name = "bInfo";
            this.bInfo.Size = new System.Drawing.Size(95, 37);
            this.bInfo.TabIndex = 2;
            this.bInfo.Text = "Información";
            this.bInfo.UseVisualStyleBackColor = true;
            this.bInfo.Click += new System.EventHandler(this.bInfo_Click);
            // 
            // bContacto
            // 
            this.bContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bContacto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bContacto.Location = new System.Drawing.Point(299, 2);
            this.bContacto.Margin = new System.Windows.Forms.Padding(2);
            this.bContacto.Name = "bContacto";
            this.bContacto.Size = new System.Drawing.Size(95, 37);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 43);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1054, 832);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Noticias";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eventos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Información";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(299, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Contacto";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(2, 879);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pASM
            // 
            this.pASM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pASM.Image = global::Asuma.Properties.Resources.asm2;
            this.pASM.Location = new System.Drawing.Point(1137, 19);
            this.pASM.Margin = new System.Windows.Forms.Padding(2);
            this.pASM.Name = "pASM";
            this.pASM.Size = new System.Drawing.Size(263, 113);
            this.pASM.TabIndex = 43;
            this.pASM.TabStop = false;
            this.pASM.Paint += new System.Windows.Forms.PaintEventHandler(this.pASM_Paint);
            // 
            // pASUMA
            // 
            this.pASUMA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pASUMA.Image = global::Asuma.Properties.Resources.asuma2;
            this.pASUMA.Location = new System.Drawing.Point(672, 19);
            this.pASUMA.Margin = new System.Windows.Forms.Padding(2);
            this.pASUMA.Name = "pASUMA";
            this.pASUMA.Size = new System.Drawing.Size(299, 103);
            this.pASUMA.TabIndex = 42;
            this.pASUMA.TabStop = false;
            this.pASUMA.Paint += new System.Windows.Forms.PaintEventHandler(this.pASUMA_Paint);
            // 
            // pUser
            // 
            this.pUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pUser.Location = new System.Drawing.Point(47, 17);
            this.pUser.Margin = new System.Windows.Forms.Padding(2);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(98, 113);
            this.pUser.TabIndex = 38;
            this.pUser.TabStop = false;
            this.pUser.Click += new System.EventHandler(this.pUser_MouseClick);
            this.pUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pUser_Paint);
            // 
            // CrearNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 857);
            this.Controls.Add(this.menuFlowLayoutPanel);
            this.Controls.Add(this.pPerfil);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pASM);
            this.Controls.Add(this.pASUMA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.pUser);
            this.Controls.Add(this.lSignOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CrearNoticia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearNoticia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.Resize += new System.EventHandler(this.CrearNoticia_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).EndInit();
            this.pPerfil.ResumeLayout(false);
            this.menuFlowLayoutPanel.ResumeLayout(false);
            this.menuFlowLayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tImage;
        private System.Windows.Forms.Button bMensajes;
        private System.Windows.Forms.TextBox tTitle;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bCrearNoticia;
        private System.Windows.Forms.PictureBox pASM;
        private System.Windows.Forms.PictureBox pASUMA;
        private System.Windows.Forms.LinkLabel lSignOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.TextBox tDescription;
        private System.Windows.Forms.Button bEscogerImg;
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
    }
}