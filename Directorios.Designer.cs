namespace Asuma
{
    partial class Directorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Directorios));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bArchivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.tCrear = new System.Windows.Forms.TextBox();
            this.bCrear = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(117, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(509, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // bArchivo
            // 
            this.bArchivo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bArchivo.Location = new System.Drawing.Point(64, 336);
            this.bArchivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bArchivo.Name = "bArchivo";
            this.bArchivo.Size = new System.Drawing.Size(365, 24);
            this.bArchivo.TabIndex = 1;
            this.bArchivo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(443, 336);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ir a carpeta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bVolver
            // 
            this.bVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolver.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVolver.Location = new System.Drawing.Point(585, 336);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(133, 28);
            this.bVolver.TabIndex = 3;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // tCrear
            // 
            this.tCrear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCrear.Location = new System.Drawing.Point(64, 370);
            this.tCrear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tCrear.Name = "tCrear";
            this.tCrear.Size = new System.Drawing.Size(365, 24);
            this.tCrear.TabIndex = 4;
            // 
            // bCrear
            // 
            this.bCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCrear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrear.Location = new System.Drawing.Point(443, 368);
            this.bCrear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(127, 28);
            this.bCrear.TabIndex = 5;
            this.bCrear.Text = "Crear carpeta";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBorrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(585, 369);
            this.bBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(133, 26);
            this.bBorrar.TabIndex = 6;
            this.bBorrar.Text = "Borrar carpeta";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // Directorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 404);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.tCrear);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bArchivo);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Directorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivos";
            this.Load += new System.EventHandler(this.PruebaFTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox bArchivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.TextBox tCrear;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.Button bBorrar;
    }
}