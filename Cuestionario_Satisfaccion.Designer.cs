
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
            this.bEnviar.Location = new System.Drawing.Point(12, 928);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(139, 32);
            this.bEnviar.TabIndex = 15;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // lNameCurso
            // 
            this.lNameCurso.AutoSize = true;
            this.lNameCurso.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameCurso.Location = new System.Drawing.Point(474, 14);
            this.lNameCurso.Name = "lNameCurso";
            this.lNameCurso.Size = new System.Drawing.Size(187, 25);
            this.lNameCurso.TabIndex = 14;
            this.lNameCurso.Text = "Curso de Prueba";
            // 
            // lTestName
            // 
            this.lTestName.AutoSize = true;
            this.lTestName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTestName.Location = new System.Drawing.Point(12, 16);
            this.lTestName.Name = "lTestName";
            this.lTestName.Size = new System.Drawing.Size(318, 23);
            this.lTestName.TabIndex = 13;
            this.lTestName.Text = "Cuestionario de Satisfacción";
            // 
            // lQ1
            // 
            this.lQ1.AutoSize = true;
            this.lQ1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ1.Location = new System.Drawing.Point(13, 70);
            this.lQ1.Name = "lQ1";
            this.lQ1.Size = new System.Drawing.Size(357, 18);
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
            this.CLB_Q1.Location = new System.Drawing.Point(16, 106);
            this.CLB_Q1.Name = "CLB_Q1";
            this.CLB_Q1.Size = new System.Drawing.Size(461, 94);
            this.CLB_Q1.TabIndex = 17;
            // 
            // lQ2
            // 
            this.lQ2.AutoSize = true;
            this.lQ2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ2.Location = new System.Drawing.Point(13, 224);
            this.lQ2.Name = "lQ2";
            this.lQ2.Size = new System.Drawing.Size(691, 18);
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
            this.CLB_Q2.Location = new System.Drawing.Point(16, 256);
            this.CLB_Q2.Name = "CLB_Q2";
            this.CLB_Q2.Size = new System.Drawing.Size(461, 79);
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
            this.CLB_Q3.Location = new System.Drawing.Point(15, 382);
            this.CLB_Q3.Name = "CLB_Q3";
            this.CLB_Q3.Size = new System.Drawing.Size(461, 49);
            this.CLB_Q3.TabIndex = 21;
            this.CLB_Q3.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLB_Q3_ItemCheck);
            // 
            // lQ3
            // 
            this.lQ3.AutoSize = true;
            this.lQ3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ3.Location = new System.Drawing.Point(12, 350);
            this.lQ3.Name = "lQ3";
            this.lQ3.Size = new System.Drawing.Size(867, 18);
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
            this.CLB_Q4.Location = new System.Drawing.Point(16, 491);
            this.CLB_Q4.Name = "CLB_Q4";
            this.CLB_Q4.Size = new System.Drawing.Size(461, 49);
            this.CLB_Q4.TabIndex = 23;
            this.CLB_Q4.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLB_Q4_ItemCheck);
            // 
            // lQ4
            // 
            this.lQ4.AutoSize = true;
            this.lQ4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ4.Location = new System.Drawing.Point(13, 459);
            this.lQ4.Name = "lQ4";
            this.lQ4.Size = new System.Drawing.Size(605, 18);
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
            this.CLB_Q5.Location = new System.Drawing.Point(15, 589);
            this.CLB_Q5.Name = "CLB_Q5";
            this.CLB_Q5.Size = new System.Drawing.Size(461, 49);
            this.CLB_Q5.TabIndex = 25;
            this.CLB_Q5.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLB_Q5_ItemCheck);
            // 
            // lQ5
            // 
            this.lQ5.AutoSize = true;
            this.lQ5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ5.Location = new System.Drawing.Point(12, 557);
            this.lQ5.Name = "lQ5";
            this.lQ5.Size = new System.Drawing.Size(498, 18);
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
            this.CLB_Q6.Location = new System.Drawing.Point(16, 687);
            this.CLB_Q6.Name = "CLB_Q6";
            this.CLB_Q6.Size = new System.Drawing.Size(461, 34);
            this.CLB_Q6.TabIndex = 27;
            this.CLB_Q6.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLB_Q6_ItemCheck);
            // 
            // lQ6
            // 
            this.lQ6.AutoSize = true;
            this.lQ6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ6.Location = new System.Drawing.Point(13, 655);
            this.lQ6.Name = "lQ6";
            this.lQ6.Size = new System.Drawing.Size(523, 18);
            this.lQ6.TabIndex = 26;
            this.lQ6.Text = "¿Estarías interesado en inscribirte en otro curso con nosotros?\r\n";
            // 
            // lQ7
            // 
            this.lQ7.AutoSize = true;
            this.lQ7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ7.Location = new System.Drawing.Point(13, 740);
            this.lQ7.Name = "lQ7";
            this.lQ7.Size = new System.Drawing.Size(663, 18);
            this.lQ7.TabIndex = 28;
            this.lQ7.Text = "¿Tienes alguna sugerencia o comentario que nos ayude a mejorar el programa?";
            // 
            // RTB_Q7
            // 
            this.RTB_Q7.Location = new System.Drawing.Point(16, 777);
            this.RTB_Q7.Name = "RTB_Q7";
            this.RTB_Q7.Size = new System.Drawing.Size(877, 127);
            this.RTB_Q7.TabIndex = 29;
            this.RTB_Q7.Text = "";
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(826, 928);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(139, 32);
            this.bSalir.TabIndex = 30;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // Cuestionario_Satisfaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(977, 972);
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