namespace Asuma
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // tUser
            // 
            this.tUser.Location = new System.Drawing.Point(533, 128);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(100, 22);
            this.tUser.TabIndex = 0;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(533, 201);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(100, 22);
            this.tPassword.TabIndex = 1;
            // 
            // bInicio
            // 
            this.bInicio.Location = new System.Drawing.Point(777, 201);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(75, 23);
            this.bInicio.TabIndex = 2;
            this.bInicio.Text = "Iniciar sesion";
            this.bInicio.UseVisualStyleBackColor = true;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // tCheck
            // 
            this.tCheck.AutoSize = true;
            this.tCheck.Location = new System.Drawing.Point(533, 284);
            this.tCheck.Name = "tCheck";
            this.tCheck.Size = new System.Drawing.Size(98, 21);
            this.tCheck.TabIndex = 3;
            this.tCheck.Text = "checkBox1";
            this.tCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 485);
            this.Controls.Add(this.tCheck);
            this.Controls.Add(this.bInicio);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.CheckBox tCheck;
    }
}

