
namespace Asuma
{
    partial class Test_Conocimiento_Edicion
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
            this.checkedListBoxQ1 = new System.Windows.Forms.CheckedListBox();
            this.lQ1 = new System.Windows.Forms.Label();
            this.lNameCurso = new System.Windows.Forms.Label();
            this.lTestName = new System.Windows.Forms.Label();
            this.textBoxPregunta = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bFinalizar_Test = new System.Windows.Forms.Button();
            this.bEliminarPregunta = new System.Windows.Forms.Button();
            this.bAñadir_Pregunta = new System.Windows.Forms.Button();
            this.bAñadir_Respuesta = new System.Windows.Forms.Button();
            this.textBoxRespuesta = new System.Windows.Forms.TextBox();
            this.bEliminar_Respuesta = new System.Windows.Forms.Button();
            this.bActualizarPregunta = new System.Windows.Forms.Button();
            this.checkBoxSelecM = new System.Windows.Forms.CheckBox();
            this.checkBoxCorrecta = new System.Windows.Forms.CheckBox();
            this.bNueva_Pregunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxQ1
            // 
            this.checkedListBoxQ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxQ1.CheckOnClick = true;
            this.checkedListBoxQ1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxQ1.FormattingEnabled = true;
            this.checkedListBoxQ1.Location = new System.Drawing.Point(44, 183);
            this.checkedListBoxQ1.Name = "checkedListBoxQ1";
            this.checkedListBoxQ1.Size = new System.Drawing.Size(510, 121);
            this.checkedListBoxQ1.TabIndex = 13;
            this.checkedListBoxQ1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxQ1_ItemCheck);
            // 
            // lQ1
            // 
            this.lQ1.AutoSize = true;
            this.lQ1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQ1.Location = new System.Drawing.Point(41, 125);
            this.lQ1.Name = "lQ1";
            this.lQ1.Size = new System.Drawing.Size(98, 18);
            this.lQ1.TabIndex = 12;
            this.lQ1.Text = "Pregunta0:";
            // 
            // lNameCurso
            // 
            this.lNameCurso.AutoSize = true;
            this.lNameCurso.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameCurso.Location = new System.Drawing.Point(343, 25);
            this.lNameCurso.Name = "lNameCurso";
            this.lNameCurso.Size = new System.Drawing.Size(187, 25);
            this.lNameCurso.TabIndex = 11;
            this.lNameCurso.Text = "Curso de Prueba";
            // 
            // lTestName
            // 
            this.lTestName.AutoSize = true;
            this.lTestName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTestName.Location = new System.Drawing.Point(40, 27);
            this.lTestName.Name = "lTestName";
            this.lTestName.Size = new System.Drawing.Size(241, 23);
            this.lTestName.TabIndex = 10;
            this.lTestName.Text = "Test de conocimiento";
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.Location = new System.Drawing.Point(167, 126);
            this.textBoxPregunta.Name = "textBoxPregunta";
            this.textBoxPregunta.Size = new System.Drawing.Size(376, 20);
            this.textBoxPregunta.TabIndex = 14;
            this.textBoxPregunta.Text = "Pregunta0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(612, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(269, 172);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // bFinalizar_Test
            // 
            this.bFinalizar_Test.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFinalizar_Test.Location = new System.Drawing.Point(12, 410);
            this.bFinalizar_Test.Name = "bFinalizar_Test";
            this.bFinalizar_Test.Size = new System.Drawing.Size(195, 28);
            this.bFinalizar_Test.TabIndex = 16;
            this.bFinalizar_Test.Text = "Finalizar Test";
            this.bFinalizar_Test.UseVisualStyleBackColor = true;
            this.bFinalizar_Test.Click += new System.EventHandler(this.bFinalizar_Test_Click);
            // 
            // bEliminarPregunta
            // 
            this.bEliminarPregunta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminarPregunta.Location = new System.Drawing.Point(234, 367);
            this.bEliminarPregunta.Name = "bEliminarPregunta";
            this.bEliminarPregunta.Size = new System.Drawing.Size(195, 28);
            this.bEliminarPregunta.TabIndex = 17;
            this.bEliminarPregunta.Text = "Eliminar Pregunta";
            this.bEliminarPregunta.UseVisualStyleBackColor = true;
            this.bEliminarPregunta.Click += new System.EventHandler(this.bEliminarPregunta_Click);
            // 
            // bAñadir_Pregunta
            // 
            this.bAñadir_Pregunta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAñadir_Pregunta.Location = new System.Drawing.Point(456, 367);
            this.bAñadir_Pregunta.Name = "bAñadir_Pregunta";
            this.bAñadir_Pregunta.Size = new System.Drawing.Size(195, 28);
            this.bAñadir_Pregunta.TabIndex = 18;
            this.bAñadir_Pregunta.Text = "Añadir Pregunta";
            this.bAñadir_Pregunta.UseVisualStyleBackColor = true;
            this.bAñadir_Pregunta.Click += new System.EventHandler(this.bAñadir_Pregunta_Click);
            // 
            // bAñadir_Respuesta
            // 
            this.bAñadir_Respuesta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAñadir_Respuesta.Location = new System.Drawing.Point(579, 276);
            this.bAñadir_Respuesta.Name = "bAñadir_Respuesta";
            this.bAñadir_Respuesta.Size = new System.Drawing.Size(141, 28);
            this.bAñadir_Respuesta.TabIndex = 19;
            this.bAñadir_Respuesta.Text = "Añadir Respuesta";
            this.bAñadir_Respuesta.UseVisualStyleBackColor = true;
            this.bAñadir_Respuesta.Click += new System.EventHandler(this.bAñadir_Respuesta_Click);
            // 
            // textBoxRespuesta
            // 
            this.textBoxRespuesta.Location = new System.Drawing.Point(579, 224);
            this.textBoxRespuesta.Name = "textBoxRespuesta";
            this.textBoxRespuesta.Size = new System.Drawing.Size(220, 20);
            this.textBoxRespuesta.TabIndex = 20;
            this.textBoxRespuesta.Text = "Respuesta0";
            // 
            // bEliminar_Respuesta
            // 
            this.bEliminar_Respuesta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar_Respuesta.Location = new System.Drawing.Point(740, 276);
            this.bEliminar_Respuesta.Name = "bEliminar_Respuesta";
            this.bEliminar_Respuesta.Size = new System.Drawing.Size(141, 28);
            this.bEliminar_Respuesta.TabIndex = 22;
            this.bEliminar_Respuesta.Text = "Eliminar Respuesta";
            this.bEliminar_Respuesta.UseVisualStyleBackColor = true;
            this.bEliminar_Respuesta.Click += new System.EventHandler(this.bEliminar_Respuesta_Click);
            // 
            // bActualizarPregunta
            // 
            this.bActualizarPregunta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bActualizarPregunta.Location = new System.Drawing.Point(676, 367);
            this.bActualizarPregunta.Name = "bActualizarPregunta";
            this.bActualizarPregunta.Size = new System.Drawing.Size(195, 28);
            this.bActualizarPregunta.TabIndex = 23;
            this.bActualizarPregunta.Text = "Actualizar Pregunta";
            this.bActualizarPregunta.UseVisualStyleBackColor = true;
            this.bActualizarPregunta.Click += new System.EventHandler(this.bActualizarPregunta_Click);
            // 
            // checkBoxSelecM
            // 
            this.checkBoxSelecM.AutoSize = true;
            this.checkBoxSelecM.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSelecM.Location = new System.Drawing.Point(44, 64);
            this.checkBoxSelecM.Name = "checkBoxSelecM";
            this.checkBoxSelecM.Size = new System.Drawing.Size(136, 18);
            this.checkBoxSelecM.TabIndex = 25;
            this.checkBoxSelecM.Text = "Selección Múltiple";
            this.checkBoxSelecM.UseVisualStyleBackColor = true;
            // 
            // checkBoxCorrecta
            // 
            this.checkBoxCorrecta.AutoSize = true;
            this.checkBoxCorrecta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCorrecta.Location = new System.Drawing.Point(805, 226);
            this.checkBoxCorrecta.Name = "checkBoxCorrecta";
            this.checkBoxCorrecta.Size = new System.Drawing.Size(80, 18);
            this.checkBoxCorrecta.TabIndex = 26;
            this.checkBoxCorrecta.Text = "Correcta";
            this.checkBoxCorrecta.UseVisualStyleBackColor = true;
            // 
            // bNueva_Pregunta
            // 
            this.bNueva_Pregunta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNueva_Pregunta.Location = new System.Drawing.Point(12, 367);
            this.bNueva_Pregunta.Name = "bNueva_Pregunta";
            this.bNueva_Pregunta.Size = new System.Drawing.Size(195, 28);
            this.bNueva_Pregunta.TabIndex = 27;
            this.bNueva_Pregunta.Text = "Limpiar";
            this.bNueva_Pregunta.UseVisualStyleBackColor = true;
            this.bNueva_Pregunta.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // Test_Conocimiento_Edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.bNueva_Pregunta);
            this.Controls.Add(this.checkBoxCorrecta);
            this.Controls.Add(this.checkBoxSelecM);
            this.Controls.Add(this.bActualizarPregunta);
            this.Controls.Add(this.bEliminar_Respuesta);
            this.Controls.Add(this.textBoxRespuesta);
            this.Controls.Add(this.bAñadir_Respuesta);
            this.Controls.Add(this.bAñadir_Pregunta);
            this.Controls.Add(this.bEliminarPregunta);
            this.Controls.Add(this.bFinalizar_Test);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBoxPregunta);
            this.Controls.Add(this.checkedListBoxQ1);
            this.Controls.Add(this.lQ1);
            this.Controls.Add(this.lNameCurso);
            this.Controls.Add(this.lTestName);
            this.Name = "Test_Conocimiento_Edicion";
            this.Text = "Test_Conocimiento_Edicion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBoxQ1;
        private System.Windows.Forms.Label lQ1;
        private System.Windows.Forms.Label lNameCurso;
        private System.Windows.Forms.Label lTestName;
        private System.Windows.Forms.TextBox textBoxPregunta;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bFinalizar_Test;
        private System.Windows.Forms.Button bEliminarPregunta;
        private System.Windows.Forms.Button bAñadir_Pregunta;
        private System.Windows.Forms.Button bAñadir_Respuesta;
        private System.Windows.Forms.TextBox textBoxRespuesta;
        private System.Windows.Forms.Button bEliminar_Respuesta;
        private System.Windows.Forms.Button bActualizarPregunta;
        private System.Windows.Forms.CheckBox checkBoxSelecM;
        private System.Windows.Forms.CheckBox checkBoxCorrecta;
        private System.Windows.Forms.Button bNueva_Pregunta;
    }
}