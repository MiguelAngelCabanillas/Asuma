
namespace Asuma
{
    partial class Notificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notificacion));
            this.tMessage = new System.Windows.Forms.TextBox();
            this.lMessage = new System.Windows.Forms.Label();
            this.lSubject = new System.Windows.Forms.Label();
            this.tSubject = new System.Windows.Forms.TextBox();
            this.lInfo = new System.Windows.Forms.Label();
            this.tSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tMessage
            // 
            this.tMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tMessage.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMessage.Location = new System.Drawing.Point(512, 227);
            this.tMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tMessage.MaxLength = 0;
            this.tMessage.Multiline = true;
            this.tMessage.Name = "tMessage";
            this.tMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tMessage.Size = new System.Drawing.Size(453, 174);
            this.tMessage.TabIndex = 15;
            this.tMessage.Text = "\r\n";
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.Location = new System.Drawing.Point(366, 229);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(97, 23);
            this.lMessage.TabIndex = 13;
            this.lMessage.Text = "Mensaje:";
            // 
            // lSubject
            // 
            this.lSubject.AutoSize = true;
            this.lSubject.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSubject.Location = new System.Drawing.Point(378, 149);
            this.lSubject.Name = "lSubject";
            this.lSubject.Size = new System.Drawing.Size(85, 23);
            this.lSubject.TabIndex = 12;
            this.lSubject.Text = "Asunto:";
            // 
            // tSubject
            // 
            this.tSubject.Location = new System.Drawing.Point(512, 150);
            this.tSubject.Name = "tSubject";
            this.tSubject.Size = new System.Drawing.Size(225, 22);
            this.tSubject.TabIndex = 16;
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInfo.Location = new System.Drawing.Point(361, 39);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(514, 46);
            this.lInfo.TabIndex = 22;
            this.lInfo.Text = "Notificación a los usuarios";
            // 
            // tSend
            // 
            this.tSend.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSend.Location = new System.Drawing.Point(512, 440);
            this.tSend.Name = "tSend";
            this.tSend.Size = new System.Drawing.Size(183, 32);
            this.tSend.TabIndex = 23;
            this.tSend.Text = "Enviar mensaje";
            this.tSend.UseVisualStyleBackColor = true;
            this.tSend.Click += new System.EventHandler(this.tSend_Click);
            // 
            // Notificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 527);
            this.Controls.Add(this.tSend);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.tSubject);
            this.Controls.Add(this.tMessage);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.lSubject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Notificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificacion";
            this.Resize += new System.EventHandler(this.Notificacion_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tMessage;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.Label lSubject;
        private System.Windows.Forms.TextBox tSubject;
        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.Button tSend;
    }
}