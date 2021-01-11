
namespace Asuma
{
    partial class Cuestionario_Satisfaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuestionario_Satisfaccion));
            this.bEnviar = new System.Windows.Forms.Button();
            this.lNameCurso = new System.Windows.Forms.Label();
            this.lTestName = new System.Windows.Forms.Label();
            this.lQ1 = new System.Windows.Forms.Label();
            this.CLB_Q1 = new System.Windows.Forms.CheckedListBox();
            this.lQ2 = new System.Windows.Forms.Label();
            this.CLB_Q2 = new System.Windows.Forms.CheckedListBox();
            this.CLB_Q3 = new System.Windows.Forms.CheckedListBox();
            this.lQ3 = new System.Windows.Forms.Label();
            this.CLB_Q4 = new System.Windows.Forms.CheckedListBox();
            this.lQ4 = new System.Windows.Forms.Label();
            this.CLB_Q5 = new System.Windows.Forms.CheckedListBox();
            this.lQ5 = new System.Windows.Forms.Label();
            this.CLB_Q6 = new System.Windows.Forms.CheckedListBox();
            this.lQ6 = new System.Windows.Forms.Label();
            this.lQ7 = new System.Windows.Forms.Label();
            this.RTB_Q7 = new System.Windows.Forms.RichTextBox();
            this.bSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bEnviar
            // 
            this.bEnviar.Location = new System.Drawing.Point(16, 1142);
            this.bEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(185, 39);
            this.bEnviar.TabIndex = 15;
            this.bEnviar.TabStop = false;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // lNameCurso
            // 
            this.lNameCurso.AutoSize = true;
            this.lNameCurso.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameCurso.Location = new System.Drawing.Point(632, 17);
            this.lNameCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNameCurso.Name = "lNameCurso";
            this.lNameCurso.Size = new System.Drawing.Size(240, 32);
            this.lNameCurso.TabIndex = 14;
            this.lNameCurso.Text = "Curso de Prueba";
            // 
            // lTestName
            // 
            this.lTestName.AutoSize = true;
            this.lTestName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTestName.Location = new System.Drawing.Point(16, 20);
            this.lTestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTestName.Name = "lTestName";
            this.lTestName.Size = new System.Drawing.Size(391, 29);
            this.lTestName.TabIndex = 0;
            this.lTestName.Text = "Cuestionario de Satisfacción";
            // 
            // lQ1
            // 
            this.lQ1.AutoSize = true;
            this.lQ1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ1.Location = new System.Drawing.Point(17, 86);
            this.lQ1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lQ1.Name = "lQ1";
            this.lQ1.Size = new System.Drawing.Size(440, 25);
            this.lQ1.TabIndex = 16;
            this.lQ1.Text = "¿Cómo te enteraste de nuestro programa?";
            // 
            // CLB_Q1
            // 
            this.CLB_Q1.CheckOnClick = true;
            this.CLB_Q1.FormattingEnabled = true;
            this.CLB_Q1.Items.AddRange(new object[] {
            "Folleto impreso",
            "Promoción por correo electrónico",
            "En la Aplicación",
            "Facebook",
            "Twitter",
            "Periódico"});
            this.CLB_Q1.Location = new System.Drawing.Point(21, 130);
            this.CLB_Q1.Margin = new System.Windows.Forms.Padding(4);
            this.CLB_Q1.Name = "CLB_Q1";
            this.CLB_Q1.Size = new System.Drawing.Size(613, 123);
            this.CLB_Q1.TabIndex = 17;
            // 
            // lQ2
            // 
            this.lQ2.AutoSize = true;
            this.lQ2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ2.Location = new System.Drawing.Point(17, 276);
            this.lQ2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lQ2.Name = "lQ2";
            this.lQ2.Size = new System.Drawing.Size(842, 25);
            this.lQ2.TabIndex = 18;
            this.lQ2.Text = "¿Qué tan satisfecho estás con el material didáctico utilizado durante el programa" +
    "?";
            // 
            // CLB_Q2
            // 
            this.CLB_Q2.CheckOnClick = true;
            this.CLB_Q2.FormattingEnabled = true;
            this.CLB_Q2.Items.AddRange(new object[] {
            "Muy insatisfecho",
            "Insatisfecho",
            "Neutral",
            "Satisfecho",
            "Muy satisfecho"});
            this.CLB_Q2.Location = new System.Drawing.Point(21, 315);
            this.CLB_Q2.Margin = new System.Windows.Forms.Padding(4);
            this.CLB_Q2.Name = "CLB_Q2";
            this.CLB_Q2.Size = new System.Drawing.Size(613, 106);
            this.CLB_Q2.TabIndex = 19;
            this.CLB_Q2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLB_Q2_ItemCheck);
            // 
            // CLB_Q3
            // 
            this.CLB_Q3.CheckOnClick = true;
            this.CLB_Q3.FormattingEnabled = true;
            this.CLB_Q3.Items.AddRange(new object[] {
            "Sí",
            "No",
            "Prefiero no decir"});
            this.CLB_Q3.Location = new System.Drawing.Point(20, 470);
            this.CLB_Q3.Margin = new System.Windows.Forms.Padding(4);
            this.CLB_Q3.Name = "CLB_Q3";
            this.CLB_Q3.Size = new System.Drawing.Size(613, 72);
            this.CLB_Q3.TabIndex = 21;
            this.CLB_Q3.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLB_Q3_ItemCheck);
            // 
            // lQ3
            // 
            this.lQ3.AutoSize = true;
            this.lQ3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ3.Location = new System.Drawing.Point(16, 431);
            this.lQ3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lQ3.Name = "lQ3";
            this.lQ3.Size = new System.Drawing.Size(1062, 25);
            this.lQ3.TabIndex = 20;
            this.lQ3.Text = "¿Crees que la duración del programa fue suficiente como para satisfacer tus expec" +
    "tativas de formación?";
            // 
            // CLB_Q4
            // 
            this.CLB_Q4.CheckOnClick = true;
            this.CLB_Q4.FormattingEnabled = true;
            this.CLB_Q4.Items.AddRange(new object[] {
            "Sí",
            "No",
            "Prefiero no decir"});
            this.CLB_Q4.Location = new System.Drawing.Point(21, 604);
            this.CLB_Q4.Margin = new System.Windows.Forms.Padding(4);
            this.CLB_Q4.Name = "CLB_Q4";
            this.CLB_Q4.Size = new System.Drawing.Size(613, 72);
            this.CLB_Q4.TabIndex = 23;
            this.CLB_Q4.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLB_Q4_ItemCheck);
            // 
            // lQ4
            // 
            this.lQ4.AutoSize = true;
            this.lQ4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ4.Location = new System.Drawing.Point(17, 565);
            this.lQ4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lQ4.Name = "lQ4";
            this.lQ4.Size = new System.Drawing.Size(743, 25);
            this.lQ4.TabIndex = 22;
            this.lQ4.Text = "¿Se explicó claramente el objetivo del programa antes de la inscripción?";
            // 
            // CLB_Q5
            // 
            this.CLB_Q5.CheckOnClick = true;
            this.CLB_Q5.FormattingEnabled = true;
            this.CLB_Q5.Items.AddRange(new object[] {
            "Sí",
            "No",
            "Prefiero no decir"});
            this.CLB_Q5.Location = new System.Drawing.Point(20, 725);
            this.CLB_Q5.Margin = new System.Windows.Forms.Padding(4);
            this.CLB_Q5.Name = "CLB_Q5";
            this.CLB_Q5.Size = new System.Drawing.Size(613, 72);
            this.CLB_Q5.TabIndex = 25;
            this.CLB_Q5.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLB_Q5_ItemCheck);
            // 
            // lQ5
            // 
            this.lQ5.AutoSize = true;
            this.lQ5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ5.Location = new System.Drawing.Point(16, 686);
            this.lQ5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lQ5.Name = "lQ5";
            this.lQ5.Size = new System.Drawing.Size(604, 25);
            this.lQ5.TabIndex = 24;
            this.lQ5.Text = "¿Te sentiste satisfecho después de completar el programa?\r\n";
            // 
            // CLB_Q6
            // 
            this.CLB_Q6.CheckOnClick = true;
            this.CLB_Q6.FormattingEnabled = true;
            this.CLB_Q6.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.CLB_Q6.Location = new System.Drawing.Point(21, 846);
            this.CLB_Q6.Margin = new System.Windows.Forms.Padding(4);
            this.CLB_Q6.Name = "CLB_Q6";
            this.CLB_Q6.Size = new System.Drawing.Size(613, 55);
            this.CLB_Q6.TabIndex = 27;
            this.CLB_Q6.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLB_Q6_ItemCheck);
            // 
            // lQ6
            // 
            this.lQ6.AutoSize = true;
            this.lQ6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ6.Location = new System.Drawing.Point(17, 806);
            this.lQ6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lQ6.Name = "lQ6";
            this.lQ6.Size = new System.Drawing.Size(643, 25);
            this.lQ6.TabIndex = 26;
            this.lQ6.Text = "¿Estarías interesado en inscribirte en otro curso con nosotros?\r\n";
            // 
            // lQ7
            // 
            this.lQ7.AutoSize = true;
            this.lQ7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ7.Location = new System.Drawing.Point(17, 911);
            this.lQ7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lQ7.Name = "lQ7";
            this.lQ7.Size = new System.Drawing.Size(818, 25);
            this.lQ7.TabIndex = 28;
            this.lQ7.Text = "¿Tienes alguna sugerencia o comentario que nos ayude a mejorar el programa?";
            // 
            // RTB_Q7
            // 
            this.RTB_Q7.Location = new System.Drawing.Point(21, 956);
            this.RTB_Q7.Margin = new System.Windows.Forms.Padding(4);
            this.RTB_Q7.Name = "RTB_Q7";
            this.RTB_Q7.Size = new System.Drawing.Size(1168, 155);
            this.RTB_Q7.TabIndex = 29;
            this.RTB_Q7.TabStop = false;
            this.RTB_Q7.Text = "";
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(1101, 1142);
            this.bSalir.Margin = new System.Windows.Forms.Padding(4);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(185, 39);
            this.bSalir.TabIndex = 30;
            this.bSalir.TabStop = false;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // Cuestionario_Satisfaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1313, 925);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.RTB_Q7);
            this.Controls.Add(this.lQ7);
            this.Controls.Add(this.CLB_Q6);
            this.Controls.Add(this.lQ6);
            this.Controls.Add(this.CLB_Q5);
            this.Controls.Add(this.lQ5);
            this.Controls.Add(this.CLB_Q4);
            this.Controls.Add(this.lQ4);
            this.Controls.Add(this.CLB_Q3);
            this.Controls.Add(this.lQ3);
            this.Controls.Add(this.CLB_Q2);
            this.Controls.Add(this.lQ2);
            this.Controls.Add(this.CLB_Q1);
            this.Controls.Add(this.lQ1);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.lNameCurso);
            this.Controls.Add(this.lTestName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Cuestionario_Satisfaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuestionario_Satisfaccion";
            this.Load += new System.EventHandler(this.Cuestionario_Satisfaccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.Label lNameCurso;
        private System.Windows.Forms.Label lTestName;
        private System.Windows.Forms.Label lQ1;
        private System.Windows.Forms.CheckedListBox CLB_Q1;
        private System.Windows.Forms.Label lQ2;
        private System.Windows.Forms.CheckedListBox CLB_Q2;
        private System.Windows.Forms.CheckedListBox CLB_Q3;
        private System.Windows.Forms.Label lQ3;
        private System.Windows.Forms.CheckedListBox CLB_Q4;
        private System.Windows.Forms.Label lQ4;
        private System.Windows.Forms.CheckedListBox CLB_Q5;
        private System.Windows.Forms.Label lQ5;
        private System.Windows.Forms.CheckedListBox CLB_Q6;
        private System.Windows.Forms.Label lQ6;
        private System.Windows.Forms.Label lQ7;
        private System.Windows.Forms.RichTextBox RTB_Q7;
        private System.Windows.Forms.Button bSalir;
    }
}