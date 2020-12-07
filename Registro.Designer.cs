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
            this.tUsername.Location = new System.Drawing.Point(604, 103);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(277, 22);
            this.tUsername.TabIndex = 0;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(604, 160);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(277, 22);
            this.tEmail.TabIndex = 1;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(604, 224);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(171, 22);
            this.tPassword.TabIndex = 2;
            // 
            // tRepeatPassword
            // 
            this.tRepeatPassword.Location = new System.Drawing.Point(604, 272);
            this.tRepeatPassword.Name = "tRepeatPassword";
            this.tRepeatPassword.Size = new System.Drawing.Size(171, 22);
            this.tRepeatPassword.TabIndex = 3;
            // 
            // cUserType
            // 
            this.cUserType.FormattingEnabled = true;
            this.cUserType.Items.AddRange(new object[] {
            "Usuario",
            "Profesor",
            "ONG"});
            this.cUserType.Location = new System.Drawing.Point(604, 329);
            this.cUserType.Name = "cUserType";
            this.cUserType.Size = new System.Drawing.Size(121, 24);
            this.cUserType.TabIndex = 5;
            this.cUserType.SelectedIndexChanged += new System.EventHandler(this.cUserType_SelectedIndexChanged);
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(397, 103);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(129, 17);
            this.lUsername.TabIndex = 6;
            this.lUsername.Text = "Nombre de usuario";
            this.lUsername.Click += new System.EventHandler(this.lUsername_Click);
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(484, 163);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(42, 17);
            this.lEmail.TabIndex = 7;
            this.lEmail.Text = "Email";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(445, 224);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(81, 17);
            this.lPassword.TabIndex = 8;
            this.lPassword.Text = "Contraseña";
            // 
            // lRepeatPassword
            // 
            this.lRepeatPassword.AutoSize = true;
            this.lRepeatPassword.Location = new System.Drawing.Point(397, 277);
            this.lRepeatPassword.Name = "lRepeatPassword";
            this.lRepeatPassword.Size = new System.Drawing.Size(139, 17);
            this.lRepeatPassword.TabIndex = 9;
            this.lRepeatPassword.Text = "Repita la contraseña";
            // 
            // lUserType
            // 
            this.lUserType.AutoSize = true;
            this.lUserType.Location = new System.Drawing.Point(419, 336);
            this.lUserType.Name = "lUserType";
            this.lUserType.Size = new System.Drawing.Size(107, 17);
            this.lUserType.TabIndex = 10;
            this.lUserType.Text = "Tipo de usuario";
            // 
            // cTerms
            // 
            this.cTerms.AutoSize = true;
            this.cTerms.Location = new System.Drawing.Point(604, 452);
            this.cTerms.Name = "cTerms";
            this.cTerms.Size = new System.Drawing.Size(454, 21);
            this.cTerms.TabIndex = 11;
            this.cTerms.Text = "Acepto los términos y condiciones de uso y la política de privacidad";
            this.cTerms.UseVisualStyleBackColor = true;
            // 
            // bRegister
            // 
            this.bRegister.Location = new System.Drawing.Point(604, 515);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(137, 29);
            this.bRegister.TabIndex = 12;
            this.bRegister.Text = "Registrarse";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // tCode
            // 
            this.tCode.Location = new System.Drawing.Point(604, 390);
            this.tCode.Name = "tCode";
            this.tCode.Size = new System.Drawing.Size(171, 22);
            this.tCode.TabIndex = 13;
            this.tCode.Visible = false;
            // 
            // lCode
            // 
            this.lCode.AutoSize = true;
            this.lCode.Location = new System.Drawing.Point(387, 395);
            this.lCode.Name = "lCode";
            this.lCode.Size = new System.Drawing.Size(139, 17);
            this.lCode.TabIndex = 14;
            this.lCode.Text = "Introduzca su código";
            this.lCode.Visible = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 632);
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
            this.Name = "Registro";
            this.Text = "registro";
            this.Load += new System.EventHandler(this.Registro_Load);
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