
namespace Asuma
{
    partial class Contacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contacto));
            this.lReason = new System.Windows.Forms.Label();
            this.lMessage = new System.Windows.Forms.Label();
            this.cReason = new System.Windows.Forms.ComboBox();
            this.tMessage = new System.Windows.Forms.TextBox();
            this.tSend = new System.Windows.Forms.Button();
            this.menuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bInicio = new System.Windows.Forms.Button();
            this.bEventos = new System.Windows.Forms.Button();
            this.bInfo = new System.Windows.Forms.Button();
            this.bContacto = new System.Windows.Forms.Button();
            this.pASM = new System.Windows.Forms.PictureBox();
            this.pASUMA = new System.Windows.Forms.PictureBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.linitSesion = new System.Windows.Forms.LinkLabel();
            this.lInfo = new System.Windows.Forms.Label();
            this.lSignOut = new System.Windows.Forms.LinkLabel();
            this.pUser = new System.Windows.Forms.PictureBox();
            this.lName = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.bNotificar = new System.Windows.Forms.Button();
            this.menuFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lReason
            // 
            this.lReason.AutoSize = true;
            this.lReason.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReason.Location = new System.Drawing.Point(642, 504);
            this.lReason.Name = "lReason";
            this.lReason.Size = new System.Drawing.Size(195, 23);
            this.lReason.TabIndex = 0;
            this.lReason.Text = "Razón de contacto:";
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.Location = new System.Drawing.Point(740, 587);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(97, 23);
            this.lMessage.TabIndex = 1;
            this.lMessage.Text = "Mensaje:";
            // 
            // cReason
            // 
            this.cReason.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cReason.FormattingEnabled = true;
            this.cReason.Items.AddRange(new object[] {
            "Problema",
            "Sugerencia",
            "Duda"});
            this.cReason.Location = new System.Drawing.Point(843, 502);
            this.cReason.Name = "cReason";
            this.cReason.Size = new System.Drawing.Size(162, 28);
            this.cReason.TabIndex = 2;
            // 
            // tMessage
            // 
            this.tMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tMessage.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMessage.Location = new System.Drawing.Point(843, 587);
            this.tMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tMessage.MaxLength = 300;
            this.tMessage.Multiline = true;
            this.tMessage.Name = "tMessage";
            this.tMessage.Size = new System.Drawing.Size(453, 174);
            this.tMessage.TabIndex = 11;
            this.tMessage.Text = "\r\n";
            // 
            // tSend
            // 
            this.tSend.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSend.Location = new System.Drawing.Point(843, 791);
            this.tSend.Name = "tSend";
            this.tSend.Size = new System.Drawing.Size(183, 32);
            this.tSend.TabIndex = 12;
            this.tSend.Text = "Enviar mensaje";
            this.tSend.UseVisualStyleBackColor = true;
            this.tSend.Click += new System.EventHandler(this.tSend_Click);
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
            this.menuFlowLayoutPanel.TabIndex = 13;
            this.menuFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuFlowLayoutPanel_Paint_1);
            // 
            // bInicio
            // 
            this.bInicio.BackColor = System.Drawing.Color.Transparent;
            this.bInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.bInicio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInicio.Location = new System.Drawing.Point(3, 2);
            this.bInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(127, 46);
            this.bInicio.TabIndex = 0;
            this.bInicio.Text = "Inicio";
            this.bInicio.UseVisualStyleBackColor = false;
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
            this.bContacto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bContacto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bContacto.Location = new System.Drawing.Point(402, 2);
            this.bContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bContacto.Name = "bContacto";
            this.bContacto.Size = new System.Drawing.Size(127, 46);
            this.bContacto.TabIndex = 3;
            this.bContacto.Text = "Contacto";
            this.bContacto.UseVisualStyleBackColor = false;
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
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.Location = new System.Drawing.Point(244, 69);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(159, 34);
            this.lUsername.TabIndex = 18;
            this.lUsername.Text = "userName";
            // 
            // linitSesion
            // 
            this.linitSesion.AutoSize = true;
            this.linitSesion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linitSesion.Location = new System.Drawing.Point(429, 79);
            this.linitSesion.Name = "linitSesion";
            this.linitSesion.Size = new System.Drawing.Size(146, 25);
            this.linitSesion.TabIndex = 15;
            this.linitSesion.TabStop = true;
            this.linitSesion.Text = "Iniciar sesion";
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInfo.Location = new System.Drawing.Point(426, 283);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(1094, 46);
            this.lInfo.TabIndex = 21;
            this.lInfo.Text = "¿Algún problema o duda? Contacta con el administrador";
            // 
            // lSignOut
            // 
            this.lSignOut.AutoSize = true;
            this.lSignOut.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSignOut.Location = new System.Drawing.Point(245, 117);
            this.lSignOut.Name = "lSignOut";
            this.lSignOut.Size = new System.Drawing.Size(122, 20);
            this.lSignOut.TabIndex = 35;
            this.lSignOut.TabStop = true;
            this.lSignOut.Text = "Cerrar sesión";
            // 
            // pUser
            // 
            this.pUser.Image = ((System.Drawing.Image)(resources.GetObject("pUser.Image")));
            this.pUser.Location = new System.Drawing.Point(72, 16);
            this.pUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(131, 139);
            this.pUser.TabIndex = 36;
            this.pUser.TabStop = false;
            this.pUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pUser_Paint);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(743, 404);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(94, 23);
            this.lName.TabIndex = 37;
            this.lName.Text = "Nombre:";
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tName.Location = new System.Drawing.Point(843, 405);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(231, 28);
            this.tName.TabIndex = 38;
            // 
            // bNotificar
            // 
            this.bNotificar.Location = new System.Drawing.Point(81, 381);
            this.bNotificar.Name = "bNotificar";
            this.bNotificar.Size = new System.Drawing.Size(131, 46);
            this.bNotificar.TabIndex = 39;
            this.bNotificar.Text = "Notificar usuarios";
            this.bNotificar.UseVisualStyleBackColor = true;
            this.bNotificar.Click += new System.EventHandler(this.bNotificar_Click);
            // 
            // Contacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.bNotificar);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lSignOut);
            this.Controls.Add(this.pUser);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.pASM);
            this.Controls.Add(this.pASUMA);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.linitSesion);
            this.Controls.Add(this.menuFlowLayoutPanel);
            this.Controls.Add(this.tSend);
            this.Controls.Add(this.tMessage);
            this.Controls.Add(this.cReason);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.lReason);
            this.Name = "Contacto";
            this.Text = "Contacto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Contacto_Resize);
            this.menuFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pASM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASUMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lReason;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.ComboBox cReason;
        private System.Windows.Forms.TextBox tMessage;
        private System.Windows.Forms.Button tSend;
        private System.Windows.Forms.FlowLayoutPanel menuFlowLayoutPanel;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.Button bEventos;
        private System.Windows.Forms.Button bInfo;
        private System.Windows.Forms.Button bContacto;
        private System.Windows.Forms.PictureBox pASM;
        private System.Windows.Forms.PictureBox pASUMA;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.LinkLabel linitSesion;
        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.LinkLabel lSignOut;
        private System.Windows.Forms.PictureBox pUser;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Button bNotificar;
    }
}