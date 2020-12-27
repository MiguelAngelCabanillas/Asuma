namespace Asuma
{
    partial class EditarEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarEvento));
            this.pASUMA = new System.Windows.Forms.PictureBox();
            this.lSignOut = new System.Windows.Forms.LinkLabel();
            this.lUsername = new System.Windows.Forms.Label();
            this.pUser = new System.Windows.Forms.PictureBox();
            this.pASM = new System.Windows.Forms.PictureBox();
            this.menuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bInicio = new System.Windows.Forms.Button();
            this.bEventos = new System.Windows.Forms.Button();
            this.bInfo = new System.Windows.Forms.Button();
            this.bContacto = new System.Windows.Forms.Button();
            this.tImage = new System.Windows.Forms.TextBox();
            this.tTitle = new System.Windows.Forms.TextBox();
            this.bExit = new System.Windows.Forms.Button();
            this.linkVideochat = new System.Windows.Forms.LinkLabel();
            this.lVideochat = new System.Windows.Forms.Label();
            this.linkEntries = new System.Windows.Forms.LinkLabel();
            this.lEntries = new System.Windows.Forms.Label();
            this.tDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lDate = new System.Windows.Forms.Label();
            this.tOrganizer = new System.Windows.Forms.TextBox();
            this.lOrganizador = new System.Windows.Forms.Label();
            this.pImage = new System.Windows.Forms.PictureBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.tDescription = new System.Windows.Forms.TextBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.bConfirmEvent = new System.Windows.Forms.Button();
            this.bDeleteEvent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bEscogerImg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pPerfil = new System.Windows.Forms.Panel();
            this.bMensajes = new System.Windows.Forms.Button();
            this.bPerfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).BeginInit();
            this.menuFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.pPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // pASUMA
            // 
            this.pASUMA.Image = ((System.Drawing.Image)(resources.GetObject("pASUMA.Image")));
            this.pASUMA.InitialImage = ((System.Drawing.Image)(resources.GetObject("pASUMA.InitialImage")));
            this.pASUMA.Location = new System.Drawing.Point(739, 18);
            this.pASUMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pASUMA.Name = "pASUMA";
            this.pASUMA.Size = new System.Drawing.Size(399, 127);
            this.pASUMA.TabIndex = 19;
            this.pASUMA.TabStop = false;
            this.pASUMA.Paint += new System.Windows.Forms.PaintEventHandler(this.pASUMA_Paint);
            // 
            // lSignOut
            // 
            this.lSignOut.AutoSize = true;
            this.lSignOut.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSignOut.Location = new System.Drawing.Point(245, 117);
            this.lSignOut.Name = "lSignOut";
            this.lSignOut.Size = new System.Drawing.Size(122, 20);
            this.lSignOut.TabIndex = 15;
            this.lSignOut.TabStop = true;
            this.lSignOut.Text = "Cerrar sesión";
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.Location = new System.Drawing.Point(244, 69);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(159, 34);
            this.lUsername.TabIndex = 17;
            this.lUsername.Text = "userName";
            // 
            // pUser
            // 
            this.pUser.Image = ((System.Drawing.Image)(resources.GetObject("pUser.Image")));
            this.pUser.Location = new System.Drawing.Point(72, 16);
            this.pUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(131, 139);
            this.pUser.TabIndex = 16;
            this.pUser.TabStop = false;
            this.pUser.Click += new System.EventHandler(this.pUser_MouseClick);
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
            this.pASM.TabIndex = 20;
            this.pASM.TabStop = false;
            this.pASM.Paint += new System.Windows.Forms.PaintEventHandler(this.pASM_Paint);
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
            this.menuFlowLayoutPanel.TabIndex = 18;
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
            this.bInicio.Text = "Inicio";
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
            // tImage
            // 
            this.tImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tImage.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tImage.Location = new System.Drawing.Point(103, 362);
            this.tImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tImage.Name = "tImage";
            this.tImage.Size = new System.Drawing.Size(225, 23);
            this.tImage.TabIndex = 48;
            // 
            // tTitle
            // 
            this.tTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tTitle.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTitle.Location = new System.Drawing.Point(637, 46);
            this.tTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tTitle.MaxLength = 40;
            this.tTitle.Name = "tTitle";
            this.tTitle.Size = new System.Drawing.Size(225, 23);
            this.tTitle.TabIndex = 32;
            // 
            // bExit
            // 
            this.bExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bExit.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(739, 762);
            this.bExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(183, 32);
            this.bExit.TabIndex = 47;
            this.bExit.Text = "Salir";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // linkVideochat
            // 
            this.linkVideochat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkVideochat.AutoSize = true;
            this.linkVideochat.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkVideochat.Location = new System.Drawing.Point(517, 666);
            this.linkVideochat.Name = "linkVideochat";
            this.linkVideochat.Size = new System.Drawing.Size(137, 17);
            this.linkVideochat.TabIndex = 46;
            this.linkVideochat.TabStop = true;
            this.linkVideochat.Text = "Enlace a videochat";
            this.linkVideochat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVideochat_LinkClicked);
            // 
            // lVideochat
            // 
            this.lVideochat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lVideochat.AutoSize = true;
            this.lVideochat.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVideochat.Location = new System.Drawing.Point(336, 654);
            this.lVideochat.Name = "lVideochat";
            this.lVideochat.Size = new System.Drawing.Size(141, 29);
            this.lVideochat.TabIndex = 45;
            this.lVideochat.Text = "Videochat:";
            // 
            // linkEntries
            // 
            this.linkEntries.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkEntries.AutoSize = true;
            this.linkEntries.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEntries.Location = new System.Drawing.Point(517, 604);
            this.linkEntries.Name = "linkEntries";
            this.linkEntries.Size = new System.Drawing.Size(112, 17);
            this.linkEntries.TabIndex = 44;
            this.linkEntries.TabStop = true;
            this.linkEntries.Text = "Añadir entrada";
            // 
            // lEntries
            // 
            this.lEntries.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lEntries.AutoSize = true;
            this.lEntries.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEntries.Location = new System.Drawing.Point(348, 594);
            this.lEntries.Name = "lEntries";
            this.lEntries.Size = new System.Drawing.Size(129, 29);
            this.lEntries.TabIndex = 43;
            this.lEntries.Text = "Entradas:";
            // 
            // tDatePicker
            // 
            this.tDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tDatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tDatePicker.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDatePicker.Location = new System.Drawing.Point(444, 478);
            this.tDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tDatePicker.Name = "tDatePicker";
            this.tDatePicker.Size = new System.Drawing.Size(409, 23);
            this.tDatePicker.TabIndex = 40;
            this.tDatePicker.Value = new System.DateTime(2020, 12, 9, 0, 0, 0, 0);
            // 
            // lDate
            // 
            this.lDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.Location = new System.Drawing.Point(180, 473);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(225, 29);
            this.lDate.TabIndex = 39;
            this.lDate.Text = "Fecha del evento:";
            // 
            // tOrganizer
            // 
            this.tOrganizer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tOrganizer.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tOrganizer.Location = new System.Drawing.Point(444, 418);
            this.tOrganizer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tOrganizer.MaxLength = 40;
            this.tOrganizer.Name = "tOrganizer";
            this.tOrganizer.Size = new System.Drawing.Size(409, 23);
            this.tOrganizer.TabIndex = 38;
            // 
            // lOrganizador
            // 
            this.lOrganizador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lOrganizador.AutoSize = true;
            this.lOrganizador.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrganizador.Location = new System.Drawing.Point(235, 412);
            this.lOrganizador.Name = "lOrganizador";
            this.lOrganizador.Size = new System.Drawing.Size(170, 29);
            this.lOrganizador.TabIndex = 37;
            this.lOrganizador.Text = "Organizador:";
            // 
            // pImage
            // 
            this.pImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pImage.BackColor = System.Drawing.SystemColors.Highlight;
            this.pImage.Location = new System.Drawing.Point(103, 0);
            this.pImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(367, 290);
            this.pImage.TabIndex = 35;
            this.pImage.TabStop = false;
            // 
            // lDescription
            // 
            this.lDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDescription.AutoSize = true;
            this.lDescription.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescription.Location = new System.Drawing.Point(537, 140);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(163, 29);
            this.lDescription.TabIndex = 34;
            this.lDescription.Text = "Descripción:";
            // 
            // tDescription
            // 
            this.tDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tDescription.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescription.Location = new System.Drawing.Point(541, 197);
            this.tDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tDescription.MaxLength = 300;
            this.tDescription.Multiline = true;
            this.tDescription.Name = "tDescription";
            this.tDescription.Size = new System.Drawing.Size(453, 80);
            this.tDescription.TabIndex = 33;
            // 
            // lTitulo
            // 
            this.lTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(537, 39);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(90, 29);
            this.lTitulo.TabIndex = 49;
            this.lTitulo.Text = "Titulo:";
            // 
            // bConfirmEvent
            // 
            this.bConfirmEvent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bConfirmEvent.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConfirmEvent.Location = new System.Drawing.Point(103, 762);
            this.bConfirmEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bConfirmEvent.Name = "bConfirmEvent";
            this.bConfirmEvent.Size = new System.Drawing.Size(183, 32);
            this.bConfirmEvent.TabIndex = 50;
            this.bConfirmEvent.Text = "Confirmar cambios";
            this.bConfirmEvent.UseVisualStyleBackColor = true;
            this.bConfirmEvent.Click += new System.EventHandler(this.bConfirmEvent_Click);
            // 
            // bDeleteEvent
            // 
            this.bDeleteEvent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bDeleteEvent.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteEvent.Location = new System.Drawing.Point(421, 762);
            this.bDeleteEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDeleteEvent.Name = "bDeleteEvent";
            this.bDeleteEvent.Size = new System.Drawing.Size(183, 32);
            this.bDeleteEvent.TabIndex = 51;
            this.bDeleteEvent.Text = "Eliminar evento";
            this.bDeleteEvent.UseVisualStyleBackColor = true;
            this.bDeleteEvent.Click += new System.EventHandler(this.bDeleteEvent_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bEscogerImg);
            this.panel1.Controls.Add(this.pImage);
            this.panel1.Controls.Add(this.bDeleteEvent);
            this.panel1.Controls.Add(this.lTitulo);
            this.panel1.Controls.Add(this.bExit);
            this.panel1.Controls.Add(this.bConfirmEvent);
            this.panel1.Controls.Add(this.tTitle);
            this.panel1.Controls.Add(this.tImage);
            this.panel1.Controls.Add(this.linkVideochat);
            this.panel1.Controls.Add(this.lDescription);
            this.panel1.Controls.Add(this.lVideochat);
            this.panel1.Controls.Add(this.tDescription);
            this.panel1.Controls.Add(this.linkEntries);
            this.panel1.Controls.Add(this.lOrganizador);
            this.panel1.Controls.Add(this.lEntries);
            this.panel1.Controls.Add(this.tOrganizer);
            this.panel1.Controls.Add(this.lDate);
            this.panel1.Controls.Add(this.tDatePicker);
            this.panel1.Location = new System.Drawing.Point(388, 266);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 796);
            this.panel1.TabIndex = 52;
            // 
            // bEscogerImg
            // 
            this.bEscogerImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bEscogerImg.Location = new System.Drawing.Point(104, 304);
            this.bEscogerImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEscogerImg.Name = "bEscogerImg";
            this.bEscogerImg.Size = new System.Drawing.Size(225, 42);
            this.bEscogerImg.TabIndex = 53;
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
            this.pPerfil.Location = new System.Drawing.Point(65, 142);
            this.pPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pPerfil.Name = "pPerfil";
            this.pPerfil.Size = new System.Drawing.Size(315, 139);
            this.pPerfil.TabIndex = 53;
            this.pPerfil.Visible = false;
            this.pPerfil.MouseLeave += new System.EventHandler(this.pPerfil_MouseLeave);
            // 
            // bMensajes
            // 
            this.bMensajes.Location = new System.Drawing.Point(41, 90);
            this.bMensajes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // EditarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1895, 1239);
            this.Controls.Add(this.pPerfil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pASUMA);
            this.Controls.Add(this.lSignOut);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.pUser);
            this.Controls.Add(this.pASM);
            this.Controls.Add(this.menuFlowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditarEvento";
            this.Text = "EditarEvento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditarEvento_Load);
            this.Resize += new System.EventHandler(this.EditarEvento_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).EndInit();
            this.menuFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pPerfil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pASUMA;
        private System.Windows.Forms.LinkLabel lSignOut;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.PictureBox pUser;
        private System.Windows.Forms.PictureBox pASM;
        private System.Windows.Forms.FlowLayoutPanel menuFlowLayoutPanel;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.Button bEventos;
        private System.Windows.Forms.Button bInfo;
        private System.Windows.Forms.Button bContacto;
        private System.Windows.Forms.TextBox tImage;
        private System.Windows.Forms.TextBox tTitle;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.LinkLabel linkVideochat;
        private System.Windows.Forms.Label lVideochat;
        private System.Windows.Forms.LinkLabel linkEntries;
        private System.Windows.Forms.Label lEntries;
        private System.Windows.Forms.DateTimePicker tDatePicker;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.TextBox tOrganizer;
        private System.Windows.Forms.Label lOrganizador;
        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.TextBox tDescription;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Button bConfirmEvent;
        private System.Windows.Forms.Button bDeleteEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bEscogerImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pPerfil;
        private System.Windows.Forms.Button bMensajes;
        private System.Windows.Forms.Button bPerfil;
    }
}