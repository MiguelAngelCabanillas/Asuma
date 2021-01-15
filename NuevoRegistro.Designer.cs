
namespace Asuma
{
    partial class NuevoRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoRegistro));
            this.lCode = new System.Windows.Forms.Label();
            this.tCode = new System.Windows.Forms.TextBox();
            this.bRegister = new System.Windows.Forms.Button();
            this.cTerms = new System.Windows.Forms.CheckBox();
            this.lUserType = new System.Windows.Forms.Label();
            this.lRepeatPassword = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lUsername = new System.Windows.Forms.Label();
            this.cUserType = new System.Windows.Forms.ComboBox();
            this.tRepeatPassword = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lCode
            // 
            this.lCode.AutoSize = true;
            this.lCode.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCode.Location = new System.Drawing.Point(256, 358);
            this.lCode.Name = "lCode";
            this.lCode.Size = new System.Drawing.Size(164, 18);
            this.lCode.TabIndex = 28;
            this.lCode.Text = "Introduzca su código";
            this.lCode.Visible = false;
            // 
            // tCode
            // 
            this.tCode.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.tCode.Location = new System.Drawing.Point(462, 353);
            this.tCode.Name = "tCode";
            this.tCode.Size = new System.Drawing.Size(176, 21);
            this.tCode.TabIndex = 27;
            this.tCode.Visible = false;
            // 
            // bRegister
            // 
            this.bRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRegister.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.bRegister.Location = new System.Drawing.Point(416, 460);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(141, 32);
            this.bRegister.TabIndex = 26;
            this.bRegister.Text = "Registrarse";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // cTerms
            // 
            this.cTerms.AutoSize = true;
            this.cTerms.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.cTerms.Location = new System.Drawing.Point(329, 420);
            this.cTerms.Name = "cTerms";
            this.cTerms.Size = new System.Drawing.Size(412, 17);
            this.cTerms.TabIndex = 25;
            this.cTerms.Text = "Acepto los términos y condiciones de uso y la política de privacidad";
            this.cTerms.UseVisualStyleBackColor = true;
            // 
            // lUserType
            // 
            this.lUserType.AutoSize = true;
            this.lUserType.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserType.Location = new System.Drawing.Point(298, 293);
            this.lUserType.Name = "lUserType";
            this.lUserType.Size = new System.Drawing.Size(121, 18);
            this.lUserType.TabIndex = 24;
            this.lUserType.Text = "Tipo de usuario";
            // 
            // lRepeatPassword
            // 
            this.lRepeatPassword.AutoSize = true;
            this.lRepeatPassword.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRepeatPassword.Location = new System.Drawing.Point(262, 228);
            this.lRepeatPassword.Name = "lRepeatPassword";
            this.lRepeatPassword.Size = new System.Drawing.Size(159, 18);
            this.lRepeatPassword.TabIndex = 23;
            this.lRepeatPassword.Text = "Repita la contraseña";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.Location = new System.Drawing.Point(326, 168);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(94, 18);
            this.lPassword.TabIndex = 22;
            this.lPassword.Text = "Contraseña";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(368, 97);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(47, 18);
            this.lEmail.TabIndex = 21;
            this.lEmail.Text = "Email";
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.Location = new System.Drawing.Point(271, 33);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(150, 18);
            this.lUsername.TabIndex = 20;
            this.lUsername.Text = "Nombre de usuario";
            // 
            // cUserType
            // 
            this.cUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cUserType.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.cUserType.FormattingEnabled = true;
            this.cUserType.Items.AddRange(new object[] {
            "Usuario",
            "Docente",
            "ONG"});
            this.cUserType.Location = new System.Drawing.Point(462, 285);
            this.cUserType.Name = "cUserType";
            this.cUserType.Size = new System.Drawing.Size(125, 21);
            this.cUserType.TabIndex = 19;
            this.cUserType.SelectedIndexChanged += new System.EventHandler(this.cUserType_SelectedIndexChanged);
            // 
            // tRepeatPassword
            // 
            this.tRepeatPassword.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.tRepeatPassword.Location = new System.Drawing.Point(462, 222);
            this.tRepeatPassword.Name = "tRepeatPassword";
            this.tRepeatPassword.PasswordChar = '*';
            this.tRepeatPassword.Size = new System.Drawing.Size(176, 21);
            this.tRepeatPassword.TabIndex = 18;
            // 
            // tPassword
            // 
            this.tPassword.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.tPassword.Location = new System.Drawing.Point(462, 168);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(176, 21);
            this.tPassword.TabIndex = 17;
            // 
            // tEmail
            // 
            this.tEmail.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.tEmail.Location = new System.Drawing.Point(462, 97);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(285, 21);
            this.tEmail.TabIndex = 16;
            // 
            // tUsername
            // 
            this.tUsername.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.tUsername.Location = new System.Drawing.Point(462, 33);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(285, 21);
            this.tUsername.TabIndex = 15;
            // 
            // NuevoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1012, 533);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NuevoRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCode;
        private System.Windows.Forms.TextBox tCode;
        private System.Windows.Forms.Button bRegister;
        private System.Windows.Forms.CheckBox cTerms;
        private System.Windows.Forms.Label lUserType;
        private System.Windows.Forms.Label lRepeatPassword;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.ComboBox cUserType;
        private System.Windows.Forms.TextBox tRepeatPassword;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tUsername;
    }
}