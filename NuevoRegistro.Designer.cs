
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
            this.lCode.Location = new System.Drawing.Point(342, 441);
            this.lCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCode.Name = "lCode";
            this.lCode.Size = new System.Drawing.Size(212, 23);
            this.lCode.TabIndex = 28;
            this.lCode.Text = "Introduzca su código";
            this.lCode.Visible = false;
            // 
            // tCode
            // 
            this.tCode.Location = new System.Drawing.Point(616, 435);
            this.tCode.Margin = new System.Windows.Forms.Padding(4);
            this.tCode.Name = "tCode";
            this.tCode.Size = new System.Drawing.Size(234, 22);
            this.tCode.TabIndex = 27;
            this.tCode.Visible = false;
            // 
            // bRegister
            // 
            this.bRegister.Location = new System.Drawing.Point(554, 566);
            this.bRegister.Margin = new System.Windows.Forms.Padding(4);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(188, 40);
            this.bRegister.TabIndex = 26;
            this.bRegister.Text = "Registrarse";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // cTerms
            // 
            this.cTerms.AutoSize = true;
            this.cTerms.Location = new System.Drawing.Point(439, 517);
            this.cTerms.Margin = new System.Windows.Forms.Padding(4);
            this.cTerms.Name = "cTerms";
            this.cTerms.Size = new System.Drawing.Size(454, 21);
            this.cTerms.TabIndex = 25;
            this.cTerms.Text = "Acepto los términos y condiciones de uso y la política de privacidad";
            this.cTerms.UseVisualStyleBackColor = true;
            // 
            // lUserType
            // 
            this.lUserType.AutoSize = true;
            this.lUserType.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserType.Location = new System.Drawing.Point(397, 361);
            this.lUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUserType.Name = "lUserType";
            this.lUserType.Size = new System.Drawing.Size(160, 23);
            this.lUserType.TabIndex = 24;
            this.lUserType.Text = "Tipo de usuario";
            // 
            // lRepeatPassword
            // 
            this.lRepeatPassword.AutoSize = true;
            this.lRepeatPassword.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRepeatPassword.Location = new System.Drawing.Point(350, 281);
            this.lRepeatPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRepeatPassword.Name = "lRepeatPassword";
            this.lRepeatPassword.Size = new System.Drawing.Size(205, 23);
            this.lRepeatPassword.TabIndex = 23;
            this.lRepeatPassword.Text = "Repita la contraseña";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.Location = new System.Drawing.Point(435, 207);
            this.lPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(117, 23);
            this.lPassword.TabIndex = 22;
            this.lPassword.Text = "Contraseña";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(491, 119);
            this.lEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(63, 23);
            this.lEmail.TabIndex = 21;
            this.lEmail.Text = "Email";
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.Location = new System.Drawing.Point(361, 41);
            this.lUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(193, 23);
            this.lUsername.TabIndex = 20;
            this.lUsername.Text = "Nombre de usuario";
            // 
            // cUserType
            // 
            this.cUserType.FormattingEnabled = true;
            this.cUserType.Items.AddRange(new object[] {
            "Usuario",
            "Docente",
            "ONG"});
            this.cUserType.Location = new System.Drawing.Point(616, 351);
            this.cUserType.Margin = new System.Windows.Forms.Padding(4);
            this.cUserType.Name = "cUserType";
            this.cUserType.Size = new System.Drawing.Size(165, 24);
            this.cUserType.TabIndex = 19;
            this.cUserType.SelectedIndexChanged += new System.EventHandler(this.cUserType_SelectedIndexChanged);
            // 
            // tRepeatPassword
            // 
            this.tRepeatPassword.Location = new System.Drawing.Point(616, 273);
            this.tRepeatPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tRepeatPassword.Name = "tRepeatPassword";
            this.tRepeatPassword.PasswordChar = '*';
            this.tRepeatPassword.Size = new System.Drawing.Size(234, 22);
            this.tRepeatPassword.TabIndex = 18;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(616, 207);
            this.tPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(234, 22);
            this.tPassword.TabIndex = 17;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(616, 119);
            this.tEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(379, 22);
            this.tEmail.TabIndex = 16;
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(616, 41);
            this.tUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(379, 22);
            this.tUsername.TabIndex = 15;
            // 
            // NuevoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1349, 656);
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