namespace Asuma
{
    partial class Recuperacion
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
            this.components = new System.ComponentModel.Container();
            this.lRecuperacion = new System.Windows.Forms.Label();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.bSend = new System.Windows.Forms.Button();
            this.tRecover = new System.Windows.Forms.TextBox();
            this.lRecoverInfo = new System.Windows.Forms.Label();
            this.bRecover = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lRecuperacion
            // 
            this.lRecuperacion.AutoSize = true;
            this.lRecuperacion.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecuperacion.Location = new System.Drawing.Point(418, 46);
            this.lRecuperacion.Name = "lRecuperacion";
            this.lRecuperacion.Size = new System.Drawing.Size(439, 46);
            this.lRecuperacion.TabIndex = 0;
            this.lRecuperacion.Text = "Recuperar contraseña";
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(643, 157);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(237, 22);
            this.tUsername.TabIndex = 1;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(643, 237);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(237, 22);
            this.tEmail.TabIndex = 2;
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.Location = new System.Drawing.Point(422, 156);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(202, 23);
            this.lUsername.TabIndex = 3;
            this.lUsername.Text = "Nombre de usuario:";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(429, 235);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(195, 23);
            this.lEmail.TabIndex = 4;
            this.lEmail.Text = "Correo electrónico:";
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(746, 282);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(134, 39);
            this.bSend.TabIndex = 5;
            this.bSend.Text = "Enviar mensaje";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // tRecover
            // 
            this.tRecover.Location = new System.Drawing.Point(534, 437);
            this.tRecover.Name = "tRecover";
            this.tRecover.Size = new System.Drawing.Size(221, 22);
            this.tRecover.TabIndex = 6;
            // 
            // lRecoverInfo
            // 
            this.lRecoverInfo.AutoSize = true;
            this.lRecoverInfo.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecoverInfo.Location = new System.Drawing.Point(400, 380);
            this.lRecoverInfo.Name = "lRecoverInfo";
            this.lRecoverInfo.Size = new System.Drawing.Size(510, 23);
            this.lRecoverInfo.TabIndex = 7;
            this.lRecoverInfo.Text = "Introduzca el código recibido por correo electrónico";
            // 
            // bRecover
            // 
            this.bRecover.Location = new System.Drawing.Point(800, 432);
            this.bRecover.Name = "bRecover";
            this.bRecover.Size = new System.Drawing.Size(98, 27);
            this.bRecover.TabIndex = 8;
            this.bRecover.Text = "Recuperar";
            this.bRecover.UseVisualStyleBackColor = true;
            this.bRecover.Click += new System.EventHandler(this.bRecover_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Recuperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1265, 630);
            this.Controls.Add(this.bRecover);
            this.Controls.Add(this.lRecoverInfo);
            this.Controls.Add(this.tRecover);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.tUsername);
            this.Controls.Add(this.lRecuperacion);
            this.MaximizeBox = false;
            this.Name = "Recuperacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lRecuperacion;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.TextBox tRecover;
        private System.Windows.Forms.Label lRecoverInfo;
        private System.Windows.Forms.Button bRecover;
        private System.Windows.Forms.Timer timer;
    }
}