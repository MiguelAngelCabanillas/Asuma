namespace Asuma
{
    partial class Mensajeria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensajeria));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bAcceder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lConversaciones = new System.Windows.Forms.Label();
            this.bBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // bAcceder
            // 
            this.bAcceder.Location = new System.Drawing.Point(228, 384);
            this.bAcceder.Name = "bAcceder";
            this.bAcceder.Size = new System.Drawing.Size(93, 23);
            this.bAcceder.TabIndex = 1;
            this.bAcceder.Text = "Ir al Chat";
            this.bAcceder.UseVisualStyleBackColor = true;
            this.bAcceder.Click += new System.EventHandler(this.bAcceder_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(470, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear nuevo Chat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lConversaciones
            // 
            this.lConversaciones.AutoSize = true;
            this.lConversaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lConversaciones.Location = new System.Drawing.Point(221, 31);
            this.lConversaciones.Name = "lConversaciones";
            this.lConversaciones.Size = new System.Drawing.Size(357, 37);
            this.lConversaciones.TabIndex = 3;
            this.lConversaciones.Text = "Conversaciones Activas";
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(360, 384);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 23);
            this.bBorrar.TabIndex = 4;
            this.bBorrar.Text = "Borrar Chat";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // Mensajeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(777, 434);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.lConversaciones);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bAcceder);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mensajeria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensajeria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bAcceder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lConversaciones;
        private System.Windows.Forms.Button bBorrar;
    }
}