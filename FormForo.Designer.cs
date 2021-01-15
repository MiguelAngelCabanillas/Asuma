
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
            this.tituloTema = new System.Windows.Forms.TextBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(96, 58);
            this.lTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(407, 36);
            this.lTitulo.TabIndex = 0;
            this.lTitulo.Text = "Titulo/Nombre del foro";
            // 
            // bAñadirTema
            // 
            this.bAñadirTema.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAñadirTema.Location = new System.Drawing.Point(103, 124);
            this.bAñadirTema.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bAñadirTema.Name = "bAñadirTema";
            this.bAñadirTema.Size = new System.Drawing.Size(551, 34);
            this.bAñadirTema.TabIndex = 1;
            this.bAñadirTema.Text = "Añadir un nuevo debate al foro\r\n";
            this.bAñadirTema.UseVisualStyleBackColor = true;
            this.bAñadirTema.Click += new System.EventHandler(this.bAñadirTema_Click);
            // 
            // listaTemas
            // 
            this.listaTemas.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaTemas.FormattingEnabled = true;
            this.listaTemas.ItemHeight = 29;
            this.listaTemas.Location = new System.Drawing.Point(105, 260);
            this.listaTemas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listaTemas.Name = "listaTemas";
            this.listaTemas.Size = new System.Drawing.Size(1236, 468);
            this.listaTemas.TabIndex = 3;
            this.listaTemas.DoubleClick += new System.EventHandler(this.listaTemas_DoubleClick);
            // 
            // tituloTema
            // 
            this.tituloTema.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTema.Location = new System.Drawing.Point(695, 132);
            this.tituloTema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tituloTema.Name = "tituloTema";
            this.tituloTema.Size = new System.Drawing.Size(477, 24);
            this.tituloTema.TabIndex = 4;
            // 
            // bEliminar
            // 
            this.bEliminar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.Location = new System.Drawing.Point(105, 181);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(551, 34);
            this.bEliminar.TabIndex = 5;
            this.bEliminar.Text = "Eliminar debate seleccionado";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // FormForo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 812);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.tituloTema);
            this.Controls.Add(this.listaTemas);
            this.Controls.Add(this.bAñadirTema);
            this.Controls.Add(this.lTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormForo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foro";
            this.Load += new System.EventHandler(this.Foro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Button bAñadirTema;
        private System.Windows.Forms.ListBox listaTemas;
        private System.Windows.Forms.TextBox tituloTema;
        private System.Windows.Forms.Button bEliminar;
    }
}