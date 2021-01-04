namespace Asuma
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.tUser = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.bInicio = new System.Windows.Forms.Button();
            this.bRegistrarse = new System.Windows.Forms.Button();
            this.lUserName = new System.Windows.Forms.Label();
            this.lPassWord = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkFPassword = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tUser
            // 
            this.tUser.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUser.Location = new System.Drawing.Point(258, 73);
            this.tUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(149, 20);
            this.tUser.TabIndex = 0;
            this.tUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tUser_KeyPress);
            // 
            // tPassword
            // 
            this.tPassword.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPassword.Location = new System.Drawing.Point(258, 109);
            this.tPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(149, 20);
            this.tPassword.TabIndex = 1;
            this.tPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPassword_KeyPress);
            // 
            // bInicio
            // 
            this.bInicio.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInicio.Location = new System.Drawing.Point(80, 185);
            this.bInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(101, 24);
            this.bInicio.TabIndex = 2;
            this.bInicio.Text = "Iniciar sesion";
            this.bInicio.UseVisualStyleBackColor = true;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // bRegistrarse
            // 
            this.bRegistrarse.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegistrarse.Location = new System.Drawing.Point(306, 185);
            this.bRegistrarse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bRegistrarse.Name = "bRegistrarse";
            this.bRegistrarse.Size = new System.Drawing.Size(101, 24);
            this.bRegistrarse.TabIndex = 4;
            this.bRegistrarse.Text = "Registrarse";
            this.bRegistrarse.UseVisualStyleBackColor = true;
            this.bRegistrarse.Click += new System.EventHandler(this.bRegistrarse_Click);
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserName.Location = new System.Drawing.Point(77, 73);
            this.lUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(163, 18);
            this.lUserName.TabIndex = 5;
            this.lUserName.Text = "Nombre de usuario";
            // 
            // lPassWord
            // 
            this.lPassWord.AutoSize = true;
            this.lPassWord.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassWord.Location = new System.Drawing.Point(77, 111);
            this.lPassWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPassWord.Name = "lPassWord";
            this.lPassWord.Size = new System.Drawing.Size(101, 18);
            this.lPassWord.TabIndex = 6;
            this.lPassWord.Text = "Contraseña";
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(424, 266);
            this.bExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(57, 24);
            this.bExit.TabIndex = 7;
            this.bExit.Text = "Salir";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkFPassword);
            this.panel1.Controls.Add(this.lUserName);
            this.panel1.Controls.Add(this.bExit);
            this.panel1.Controls.Add(this.tUser);
            this.panel1.Controls.Add(this.bRegistrarse);
            this.panel1.Controls.Add(this.lPassWord);
            this.panel1.Controls.Add(this.tPassword);
            this.panel1.Controls.Add(this.bInicio);
            this.panel1.Location = new System.Drawing.Point(35, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 292);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkFPassword
            // 
            this.linkFPassword.AutoSize = true;
            this.linkFPassword.Location = new System.Drawing.Point(303, 144);
            this.linkFPassword.Name = "linkFPassword";
            this.linkFPassword.Size = new System.Drawing.Size(106, 13);
            this.linkFPassword.TabIndex = 8;
            this.linkFPassword.TabStop = true;
            this.linkFPassword.Text = "Olvidé mi contraseña";
            this.linkFPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFPassword_LinkClicked);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(563, 370);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(482, 291);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Resize += new System.EventHandler(this.Inicio_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.Button bRegistrarse;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.Label lPassWord;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkFPassword;
    }
}

