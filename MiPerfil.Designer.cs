namespace Asuma
{
    partial class MiPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiPerfil));
            this.pUsuario = new System.Windows.Forms.PictureBox();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.bNombre = new System.Windows.Forms.Button();
            this.bMail = new System.Windows.Forms.Button();
            this.bBorrarCuenta = new System.Windows.Forms.Button();
            this.bImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pUsuario
            // 
            this.pUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pUsuario.Image")));
            this.pUsuario.Location = new System.Drawing.Point(168, 128);
            this.pUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.pUsuario.Name = "pUsuario";
            this.pUsuario.Size = new System.Drawing.Size(211, 192);
            this.pUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pUsuario.TabIndex = 0;
            this.pUsuario.TabStop = false;
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(676, 140);
            this.tUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(251, 22);
            this.tUsername.TabIndex = 13;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(676, 266);
            this.tEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(251, 22);
            this.tEmail.TabIndex = 14;
            // 
            // bNombre
            // 
            this.bNombre.Location = new System.Drawing.Point(704, 172);
            this.bNombre.Margin = new System.Windows.Forms.Padding(4);
            this.bNombre.Name = "bNombre";
            this.bNombre.Size = new System.Drawing.Size(203, 25);
            this.bNombre.TabIndex = 15;
            this.bNombre.Text = "Cambiar Nombre de usuario";
            this.bNombre.UseVisualStyleBackColor = true;
            this.bNombre.Click += new System.EventHandler(this.bNombre_Click);
            // 
            // bMail
            // 
            this.bMail.Location = new System.Drawing.Point(704, 298);
            this.bMail.Margin = new System.Windows.Forms.Padding(4);
            this.bMail.Name = "bMail";
            this.bMail.Size = new System.Drawing.Size(203, 25);
            this.bMail.TabIndex = 16;
            this.bMail.Text = "Cambiar correo";
            this.bMail.UseVisualStyleBackColor = true;
            this.bMail.Click += new System.EventHandler(this.bMail_Click);
            // 
            // bBorrarCuenta
            // 
            this.bBorrarCuenta.Location = new System.Drawing.Point(649, 391);
            this.bBorrarCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.bBorrarCuenta.Name = "bBorrarCuenta";
            this.bBorrarCuenta.Size = new System.Drawing.Size(301, 25);
            this.bBorrarCuenta.TabIndex = 17;
            this.bBorrarCuenta.Text = "Darse de baja en la aplicación";
            this.bBorrarCuenta.UseVisualStyleBackColor = true;
            this.bBorrarCuenta.Click += new System.EventHandler(this.bBorrarCuenta_Click);
            // 
            // bImagen
            // 
            this.bImagen.Location = new System.Drawing.Point(168, 352);
            this.bImagen.Margin = new System.Windows.Forms.Padding(4);
            this.bImagen.Name = "bImagen";
            this.bImagen.Size = new System.Drawing.Size(212, 28);
            this.bImagen.TabIndex = 18;
            this.bImagen.Text = "Cambiar imagen";
            this.bImagen.UseVisualStyleBackColor = true;
            this.bImagen.Click += new System.EventHandler(this.bImagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Imagen de perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(737, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(744, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Correo electrónico";
            // 
            // MiPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1065, 522);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.tUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bImagen);
            this.Controls.Add(this.bBorrarCuenta);
            this.Controls.Add(this.bMail);
            this.Controls.Add(this.bNombre);
            this.Controls.Add(this.pUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MiPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiPerfil";
            ((System.ComponentModel.ISupportInitialize)(this.pUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pUsuario;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.Button bNombre;
        private System.Windows.Forms.Button bMail;
        private System.Windows.Forms.Button bBorrarCuenta;
        private System.Windows.Forms.Button bImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}