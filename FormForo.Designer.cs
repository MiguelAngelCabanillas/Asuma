﻿
namespace Asuma
{
    partial class FormForo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForo));
            this.lTitulo = new System.Windows.Forms.Label();
            this.bAñadirTema = new System.Windows.Forms.Button();
            this.listaTemas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(72, 47);
            this.lTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(367, 32);
            this.lTitulo.TabIndex = 0;
            this.lTitulo.Text = "Titulo/Nombre del foro";
            // 
            // bAñadirTema
            // 
            this.bAñadirTema.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAñadirTema.Location = new System.Drawing.Point(79, 130);
            this.bAñadirTema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAñadirTema.Name = "bAñadirTema";
            this.bAñadirTema.Size = new System.Drawing.Size(413, 28);
            this.bAñadirTema.TabIndex = 1;
            this.bAñadirTema.Text = "Añadir un nuevo debate al foro\r\n";
            this.bAñadirTema.UseVisualStyleBackColor = true;
            this.bAñadirTema.Click += new System.EventHandler(this.bAñadirTema_Click);
            // 
            // listaTemas
            // 
            this.listaTemas.FormattingEnabled = true;
            this.listaTemas.ItemHeight = 16;
            this.listaTemas.Location = new System.Drawing.Point(79, 213);
            this.listaTemas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaTemas.Name = "listaTemas";
            this.listaTemas.Size = new System.Drawing.Size(1188, 532);
            this.listaTemas.TabIndex = 3;
            // 
            // FormForo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 812);
            this.Controls.Add(this.listaTemas);
            this.Controls.Add(this.bAñadirTema);
            this.Controls.Add(this.lTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormForo";
            this.Text = "Foro";
            this.Load += new System.EventHandler(this.Foro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Button bAñadirTema;
        private System.Windows.Forms.ListBox listaTemas;
    }
}