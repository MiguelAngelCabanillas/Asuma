﻿
namespace Asuma
{
    partial class Surveys_Evento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Surveys_Evento));
            this.LB_Surveys = new System.Windows.Forms.ListBox();
            this.bVisualizar = new System.Windows.Forms.Button();
            this.lSurveys = new System.Windows.Forms.Label();
            this.bSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Surveys
            // 
            this.LB_Surveys.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Surveys.FormattingEnabled = true;
            this.LB_Surveys.ItemHeight = 16;
            this.LB_Surveys.Location = new System.Drawing.Point(28, 83);
            this.LB_Surveys.Name = "LB_Surveys";
            this.LB_Surveys.Size = new System.Drawing.Size(295, 372);
            this.LB_Surveys.TabIndex = 0;
            // 
            // bVisualizar
            // 
            this.bVisualizar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVisualizar.Location = new System.Drawing.Point(28, 501);
            this.bVisualizar.Name = "bVisualizar";
            this.bVisualizar.Size = new System.Drawing.Size(137, 26);
            this.bVisualizar.TabIndex = 1;
            this.bVisualizar.Text = "Visualizar";
            this.bVisualizar.UseVisualStyleBackColor = true;
            this.bVisualizar.Click += new System.EventHandler(this.bVisualizar_Click);
            // 
            // lSurveys
            // 
            this.lSurveys.AutoSize = true;
            this.lSurveys.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSurveys.Location = new System.Drawing.Point(24, 42);
            this.lSurveys.Name = "lSurveys";
            this.lSurveys.Size = new System.Drawing.Size(326, 23);
            this.lSurveys.TabIndex = 2;
            this.lSurveys.Text = "Cuestionarios de satisfacción\r\n";
            // 
            // bSalir
            // 
            this.bSalir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.Location = new System.Drawing.Point(185, 501);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(137, 26);
            this.bSalir.TabIndex = 7;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // Surveys_Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 564);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.lSurveys);
            this.Controls.Add(this.bVisualizar);
            this.Controls.Add(this.LB_Surveys);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Surveys_Evento";
            this.Text = "Surveys_Evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Surveys;
        private System.Windows.Forms.Button bVisualizar;
        private System.Windows.Forms.Label lSurveys;
        private System.Windows.Forms.Button bSalir;
    }
}