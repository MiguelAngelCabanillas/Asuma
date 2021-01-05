
namespace Asuma
{
    partial class Tests_Curso
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
            this.lTestConocimiento = new System.Windows.Forms.Label();
            this.bVisualizar = new System.Windows.Forms.Button();
            this.LB_Tests = new System.Windows.Forms.ListBox();
            this.bSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTestConocimiento
            // 
            this.lTestConocimiento.AutoSize = true;
            this.lTestConocimiento.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTestConocimiento.Location = new System.Drawing.Point(34, 49);
            this.lTestConocimiento.Name = "lTestConocimiento";
            this.lTestConocimiento.Size = new System.Drawing.Size(252, 23);
            this.lTestConocimiento.TabIndex = 5;
            this.lTestConocimiento.Text = "Tests de conocimiento";
            // 
            // bVisualizar
            // 
            this.bVisualizar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVisualizar.Location = new System.Drawing.Point(38, 508);
            this.bVisualizar.Name = "bVisualizar";
            this.bVisualizar.Size = new System.Drawing.Size(138, 36);
            this.bVisualizar.TabIndex = 4;
            this.bVisualizar.Text = "Visualizar";
            this.bVisualizar.UseVisualStyleBackColor = true;
            this.bVisualizar.Click += new System.EventHandler(this.bVisualizar_Click);
            // 
            // LB_Tests
            // 
            this.LB_Tests.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Tests.FormattingEnabled = true;
            this.LB_Tests.ItemHeight = 16;
            this.LB_Tests.Location = new System.Drawing.Point(38, 90);
            this.LB_Tests.Name = "LB_Tests";
            this.LB_Tests.Size = new System.Drawing.Size(295, 388);
            this.LB_Tests.TabIndex = 3;
            // 
            // bSalir
            // 
            this.bSalir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.Location = new System.Drawing.Point(195, 508);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(138, 36);
            this.bSalir.TabIndex = 6;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // Tests_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 564);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.lTestConocimiento);
            this.Controls.Add(this.bVisualizar);
            this.Controls.Add(this.LB_Tests);
            this.Name = "Tests_Curso";
            this.Text = "Tests_Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTestConocimiento;
        private System.Windows.Forms.Button bVisualizar;
        private System.Windows.Forms.ListBox LB_Tests;
        private System.Windows.Forms.Button bSalir;
    }
}