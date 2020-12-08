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
            this.tUser = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.bInicio = new System.Windows.Forms.Button();
            this.tCheck = new System.Windows.Forms.CheckBox();
            this.bRegistrarse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tUser
            // 
            this.tUser.Location = new System.Drawing.Point(649, 143);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(100, 22);
            this.tUser.TabIndex = 0;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(649, 203);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(100, 22);
            this.tPassword.TabIndex = 1;
            // 
            // bInicio
            // 
            this.bInicio.Location = new System.Drawing.Point(465, 292);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(135, 30);
            this.bInicio.TabIndex = 2;
            this.bInicio.Text = "Iniciar sesion";
            this.bInicio.UseVisualStyleBackColor = true;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // tCheck
            // 
            this.tCheck.AutoSize = true;
            this.tCheck.Location = new System.Drawing.Point(870, 178);
            this.tCheck.Name = "tCheck";
            this.tCheck.Size = new System.Drawing.Size(98, 21);
            this.tCheck.TabIndex = 3;
            this.tCheck.Text = "checkBox1";
            this.tCheck.UseVisualStyleBackColor = true;
            // 
            // bRegistrarse
            // 
            this.bRegistrarse.Location = new System.Drawing.Point(746, 292);
            this.bRegistrarse.Name = "bRegistrarse";
            this.bRegistrarse.Size = new System.Drawing.Size(135, 30);
            this.bRegistrarse.TabIndex = 4;
            this.bRegistrarse.Text = "Registrarse";
            this.bRegistrarse.UseVisualStyleBackColor = true;
            this.bRegistrarse.Click += new System.EventHandler(this.bRegistrarse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // BGuest
            // 
            this.BGuest.Location = new System.Drawing.Point(590, 339);
            this.BGuest.Name = "BGuest";
            this.BGuest.Size = new System.Drawing.Size(159, 30);
            this.BGuest.TabIndex = 7;
            this.BGuest.Text = "Entrar como invitado";
            this.BGuest.UseVisualStyleBackColor = true;
            this.BGuest.Click += new System.EventHandler(this.BGuest_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 485);
            this.Controls.Add(this.BGuest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRegistrarse);
            this.Controls.Add(this.tCheck);
            this.Controls.Add(this.bInicio);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tUser);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.CheckBox tCheck;
        private System.Windows.Forms.Button bRegistrarse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BGuest;
    }
}

