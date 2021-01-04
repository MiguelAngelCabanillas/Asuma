
namespace Asuma
{
    partial class CambiarPassword
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
            this.lPassword = new System.Windows.Forms.Label();
            this.lRepeatedPassword = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tRepeatedPassword = new System.Windows.Forms.TextBox();
            this.cShow = new System.Windows.Forms.CheckBox();
            this.bChange = new System.Windows.Forms.Button();
            this.lRecuperacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.Location = new System.Drawing.Point(248, 189);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(296, 23);
            this.lPassword.TabIndex = 0;
            this.lPassword.Text = "Introduzca nueva contraseña:";
            // 
            // lRepeatedPassword
            // 
            this.lRepeatedPassword.AutoSize = true;
            this.lRepeatedPassword.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRepeatedPassword.Location = new System.Drawing.Point(290, 279);
            this.lRepeatedPassword.Name = "lRepeatedPassword";
            this.lRepeatedPassword.Size = new System.Drawing.Size(254, 23);
            this.lRepeatedPassword.TabIndex = 1;
            this.lRepeatedPassword.Text = "Repita nueva contraseña:";
            // 
            // tPassword
            // 
            this.tPassword.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPassword.Location = new System.Drawing.Point(561, 191);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(221, 23);
            this.tPassword.TabIndex = 2;
            // 
            // tRepeatedPassword
            // 
            this.tRepeatedPassword.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRepeatedPassword.Location = new System.Drawing.Point(561, 281);
            this.tRepeatedPassword.Name = "tRepeatedPassword";
            this.tRepeatedPassword.PasswordChar = '*';
            this.tRepeatedPassword.Size = new System.Drawing.Size(221, 23);
            this.tRepeatedPassword.TabIndex = 3;
            // 
            // cShow
            // 
            this.cShow.AutoSize = true;
            this.cShow.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cShow.Location = new System.Drawing.Point(792, 242);
            this.cShow.Name = "cShow";
            this.cShow.Size = new System.Drawing.Size(167, 21);
            this.cShow.TabIndex = 4;
            this.cShow.Text = "Mostrar contraseña";
            this.cShow.UseVisualStyleBackColor = true;
            this.cShow.CheckedChanged += new System.EventHandler(this.cShow_CheckedChanged);
            // 
            // bChange
            // 
            this.bChange.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChange.Location = new System.Drawing.Point(658, 360);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(107, 46);
            this.bChange.TabIndex = 5;
            this.bChange.Text = "Cambiar contraseña";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // lRecuperacion
            // 
            this.lRecuperacion.AutoSize = true;
            this.lRecuperacion.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecuperacion.Location = new System.Drawing.Point(366, 53);
            this.lRecuperacion.Name = "lRecuperacion";
            this.lRecuperacion.Size = new System.Drawing.Size(404, 46);
            this.lRecuperacion.TabIndex = 7;
            this.lRecuperacion.Text = "Cambiar contraseña";
            // 
            // CambiarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1143, 588);
            this.Controls.Add(this.lRecuperacion);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.cShow);
            this.Controls.Add(this.tRepeatedPassword);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.lRepeatedPassword);
            this.Controls.Add(this.lPassword);
            this.MaximizeBox = false;
            this.Name = "CambiarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lRepeatedPassword;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tRepeatedPassword;
        private System.Windows.Forms.CheckBox cShow;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.Label lRecuperacion;
    }
}