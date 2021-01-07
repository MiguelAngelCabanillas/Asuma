namespace Asuma
{
    partial class PruebaFTP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bArchivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bSubir = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(382, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // bArchivo
            // 
            this.bArchivo.Location = new System.Drawing.Point(48, 273);
            this.bArchivo.Name = "bArchivo";
            this.bArchivo.Size = new System.Drawing.Size(286, 20);
            this.bArchivo.TabIndex = 1;
            this.bArchivo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Descargar archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // bSubir
            // 
            this.bSubir.Location = new System.Drawing.Point(48, 301);
            this.bSubir.Name = "bSubir";
            this.bSubir.Size = new System.Drawing.Size(372, 23);
            this.bSubir.TabIndex = 3;
            this.bSubir.Text = "Subir archivo";
            this.bSubir.UseVisualStyleBackColor = true;
            this.bSubir.Click += new System.EventHandler(this.button2_Click);
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(432, 270);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(82, 23);
            this.bVolver.TabIndex = 4;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(432, 301);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(82, 23);
            this.bEliminar.TabIndex = 5;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // PruebaFTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 328);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bSubir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bArchivo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PruebaFTP";
            this.Text = "PruebaFTP";
            this.Load += new System.EventHandler(this.PruebaFTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox bArchivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bSubir;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bEliminar;
    }
}