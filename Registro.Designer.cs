namespace Asuma
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.tUsername = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tRepeatPassword = new System.Windows.Forms.TextBox();
            this.cUserType = new System.Windows.Forms.ComboBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lRepeatPassword = new System.Windows.Forms.Label();
            this.lUserType = new System.Windows.Forms.Label();
            this.cTerms = new System.Windows.Forms.CheckBox();
            this.bRegister = new System.Windows.Forms.Button();
            this.tCode = new System.Windows.Forms.TextBox();
            this.lCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(430, 26);
            this.tUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(379, 29);
            this.tUsername.TabIndex = 0;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(430, 104);
            this.tEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(379, 29);
            this.tEmail.TabIndex = 1;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(430, 192);
            this.tPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(234, 29);
            this.tPassword.TabIndex = 2;
            // 
            // tRepeatPassword
            // 
            this.tRepeatPassword.Location = new System.Drawing.Point(430, 258);
            this.tRepeatPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tRepeatPassword.Name = "tRepeatPassword";
            this.tRepeatPassword.PasswordChar = '*';
            this.tRepeatPassword.Size = new System.Drawing.Size(234, 29);
            this.tRepeatPassword.TabIndex = 3;
            // 
            // cUserType
            // 
            this.cUserType.FormattingEnabled = true;
            this.cUserType.Items.AddRange(new object[] {
            "Usuario",
            "Docente",
            "ONG"});
            this.cUserType.Location = new System.Drawing.Point(430, 336);
            this.cUserType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cUserType.Name = "cUserType";
            this.cUserType.Size = new System.Drawing.Size(165, 30);
            this.cUserType.TabIndex = 5;
            this.cUserType.SelectedIndexChanged += new System.EventHandler(this.cUserType_SelectedIndexChanged);
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.Location = new System.Drawing.Point(175, 26);
            this.lUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(193, 23);
            this.lUsername.TabIndex = 6;
            this.lUsername.Text = "Nombre de usuario";
            this.lUsername.Click += new System.EventHandler(this.lUsername_Click);
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(305, 104);
            this.lEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(63, 23);
            this.lEmail.TabIndex = 7;
            this.lEmail.Text = "Email";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.Location = new System.Drawing.Point(249, 192);
            this.lPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(117, 23);
            this.lPassword.TabIndex = 8;
            this.lPassword.Text = "Contraseña";
            // 
            // lRepeatPassword
            // 
            this.lRepeatPassword.AutoSize = true;
            this.lRepeatPassword.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRepeatPassword.Location = new System.Drawing.Point(164, 266);
            this.lRepeatPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRepeatPassword.Name = "lRepeatPassword";
            this.lRepeatPassword.Size = new System.Drawing.Size(205, 23);
            this.lRepeatPassword.TabIndex = 9;
            this.lRepeatPassword.Text = "Repita la contraseña";
            // 
            // lUserType
            // 
            this.lUserType.AutoSize = true;
            this.lUserType.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserType.Location = new System.Drawing.Point(211, 346);
            this.lUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUserType.Name = "lUserType";
            this.lUserType.Size = new System.Drawing.Size(160, 23);
            this.lUserType.TabIndex = 10;
            this.lUserType.Text = "Tipo de usuario";
            // 
            // cTerms
            // 
            this.cTerms.AutoSize = true;
            this.cTerms.Location = new System.Drawing.Point(253, 502);
            this.cTerms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cTerms.Name = "cTerms";
            this.cTerms.Size = new System.Drawing.Size(687, 27);
            this.cTerms.TabIndex = 11;
            this.cTerms.Text = "Acepto los términos y condiciones de uso y la política de privacidad";
            this.cTerms.UseVisualStyleBackColor = true;
            // 
            // bRegister
            // 
            this.bRegister.Location = new System.Drawing.Point(476, 592);
            this.bRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(188, 40);
            this.bRegister.TabIndex = 12;
            this.bRegister.Text = "Registrarse";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // tCode
            // 
            this.tCode.Location = new System.Drawing.Point(430, 420);
            this.tCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tCode.Name = "tCode";
            this.tCode.Size = new System.Drawing.Size(234, 29);
            this.tCode.TabIndex = 13;
            this.tCode.Visible = false;
            // 
            // lCode
            // 
            this.lCode.AutoSize = true;
            this.lCode.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCode.Location = new System.Drawing.Point(156, 426);
            this.lCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCode.Name = "lCode";
            this.lCode.Size = new System.Drawing.Size(212, 23);
            this.lCode.TabIndex = 14;
            this.lCode.Text = "Introduzca su código";
            this.lCode.Visible = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1119, 645);
            this.Controls.Add(this.lCode);
            this.Controls.Add(this.tCode);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.cTerms);
            this.Controls.Add(this.lUserType);
            this.Controls.Add(this.lRepeatPassword);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.cUserType);
            this.Controls.Add(this.tRepeatPassword);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.tUsername);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tRepeatPassword;
        private System.Windows.Forms.ComboBox cUserType;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lRepeatPassword;
        private System.Windows.Forms.Label lUserType;
        private System.Windows.Forms.CheckBox cTerms;
        private System.Windows.Forms.Button bRegister;
        private System.Windows.Forms.TextBox tCode;
        private System.Windows.Forms.Label lCode;
    }
}