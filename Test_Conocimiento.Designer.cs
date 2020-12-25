
namespace Asuma
{
    partial class Test_Conocimiento
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
            this.lTestName = new System.Windows.Forms.Label();
            this.lNameCurso = new System.Windows.Forms.Label();
            this.bEnviar = new System.Windows.Forms.Button();
            this.panelPregyRes = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lTestName
            // 
            this.lTestName.AutoSize = true;
            this.lTestName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTestName.Location = new System.Drawing.Point(12, 22);
            this.lTestName.Name = "lTestName";
            this.lTestName.Size = new System.Drawing.Size(241, 23);
            this.lTestName.TabIndex = 0;
            this.lTestName.Text = "Test de conocimiento";
            // 
            // lNameCurso
            // 
            this.lNameCurso.AutoSize = true;
            this.lNameCurso.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameCurso.Location = new System.Drawing.Point(339, 20);
            this.lNameCurso.Name = "lNameCurso";
            this.lNameCurso.Size = new System.Drawing.Size(187, 25);
            this.lNameCurso.TabIndex = 1;
            this.lNameCurso.Text = "Curso de Prueba";
            // 
            // bEnviar
            // 
            this.bEnviar.Location = new System.Drawing.Point(16, 498);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(139, 32);
            this.bEnviar.TabIndex = 8;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // panelPregyRes
            // 
            this.panelPregyRes.AutoScroll = true;
            this.panelPregyRes.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.panelPregyRes.Location = new System.Drawing.Point(16, 57);
            this.panelPregyRes.Name = "panelPregyRes";
            this.panelPregyRes.Size = new System.Drawing.Size(876, 435);
            this.panelPregyRes.TabIndex = 12;
            // 
            // Test_Conocimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 542);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.lNameCurso);
            this.Controls.Add(this.lTestName);
            this.Controls.Add(this.panelPregyRes);
            this.Name = "Test_Conocimiento";
            this.Text = "Test_Conocimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTestName;
        private System.Windows.Forms.Label lNameCurso;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.Panel panelPregyRes;
    }
}