
namespace Asuma
{
	partial class MyEvents
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
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.asumaLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.menuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bNews = new System.Windows.Forms.Button();
            this.bEvents = new System.Windows.Forms.Button();
            this.bInfo = new System.Windows.Forms.Button();
            this.bContact = new System.Windows.Forms.Button();
            this.bMyEvents = new System.Windows.Forms.Button();
            this.bCreateEvent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asumaLogoPictureBox)).BeginInit();
            this.menuFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userPictureBox
            // 
            this.userPictureBox.Location = new System.Drawing.Point(30, 12);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(54, 50);
            this.userPictureBox.TabIndex = 0;
            this.userPictureBox.TabStop = false;
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(110, 23);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(153, 22);
            this.tUsername.TabIndex = 1;
            this.tUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // asumaLogoPictureBox
            // 
            this.asumaLogoPictureBox.Location = new System.Drawing.Point(486, 12);
            this.asumaLogoPictureBox.Name = "asumaLogoPictureBox";
            this.asumaLogoPictureBox.Size = new System.Drawing.Size(423, 50);
            this.asumaLogoPictureBox.TabIndex = 2;
            this.asumaLogoPictureBox.TabStop = false;
            // 
            // 
            // menuFlowLayoutPanel
            // 
            this.menuFlowLayoutPanel.Controls.Add(this.bNews);
            this.menuFlowLayoutPanel.Controls.Add(this.bEvents);
            this.menuFlowLayoutPanel.Controls.Add(this.bInfo);
            this.menuFlowLayoutPanel.Controls.Add(this.bContact);
            this.menuFlowLayoutPanel.Location = new System.Drawing.Point(46, 77);
            this.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel";
            this.menuFlowLayoutPanel.Size = new System.Drawing.Size(1307, 50);
            this.menuFlowLayoutPanel.TabIndex = 3;
            // 
            // bNews
            // 
            this.bNews.AutoSize = true;
            this.bNews.Location = new System.Drawing.Point(3, 3);
            this.bNews.Name = "bNews";
            this.bNews.Size = new System.Drawing.Size(320, 50);
            this.bNews.TabIndex = 0;
            this.bNews.Text = "Noticias";
            this.bNews.UseVisualStyleBackColor = true;
            // 
            // bEvents
            // 
            this.bEvents.AutoSize = true;
            this.bEvents.Location = new System.Drawing.Point(329, 3);
            this.bEvents.Name = "bEvents";
            this.bEvents.Size = new System.Drawing.Size(320, 50);
            this.bEvents.TabIndex = 1;
            this.bEvents.Text = "Eventos";
            this.bEvents.UseVisualStyleBackColor = true;
            // 
            // bInfo
            // 
            this.bInfo.Location = new System.Drawing.Point(655, 3);
            this.bInfo.Name = "bInfo";
            this.bInfo.Size = new System.Drawing.Size(320, 50);
            this.bInfo.TabIndex = 2;
            this.bInfo.Text = "Información";
            this.bInfo.UseVisualStyleBackColor = true;
            // 
            // bContact
            // 
            this.bContact.Location = new System.Drawing.Point(981, 3);
            this.bContact.Name = "bContact";
            this.bContact.Size = new System.Drawing.Size(320, 50);
            this.bContact.TabIndex = 3;
            this.bContact.Text = "Contacto";
            this.bContact.UseVisualStyleBackColor = true;
            // 
            // bMyEvents
            // 
            this.bMyEvents.Location = new System.Drawing.Point(30, 731);
            this.bMyEvents.Name = "bMyEvents";
            this.bMyEvents.Size = new System.Drawing.Size(194, 46);
            this.bMyEvents.TabIndex = 4;
            this.bMyEvents.Text = "Mis Eventos";
            this.bMyEvents.UseVisualStyleBackColor = true;
            // 
            // bCreateEvent
            // 
            this.bCreateEvent.Location = new System.Drawing.Point(1158, 731);
            this.bCreateEvent.Name = "bCreateEvent";
            this.bCreateEvent.Size = new System.Drawing.Size(210, 46);
            this.bCreateEvent.TabIndex = 5;
            this.bCreateEvent.Text = "Crear Evento";
            this.bCreateEvent.UseVisualStyleBackColor = true;
            // 
            // MyEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 789);
            this.Controls.Add(this.bCreateEvent);
            this.Controls.Add(this.bMyEvents);
            this.Controls.Add(this.menuFlowLayoutPanel);
            this.Controls.Add(this.asumaLogoPictureBox);
            this.Controls.Add(this.tUsername);
            this.Controls.Add(this.userPictureBox);
            this.Name = "MyEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MisEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asumaLogoPictureBox)).EndInit();
            this.menuFlowLayoutPanel.ResumeLayout(false);
            this.menuFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox userPictureBox;
		private System.Windows.Forms.TextBox tUsername;
		private System.Windows.Forms.PictureBox asumaLogoPictureBox;
		private System.Windows.Forms.FlowLayoutPanel menuFlowLayoutPanel;
		private System.Windows.Forms.Button bNews;
		private System.Windows.Forms.Button bEvents;
		private System.Windows.Forms.Button bInfo;
		private System.Windows.Forms.Button bContact;
		private System.Windows.Forms.Button bMyEvents;
		private System.Windows.Forms.Button bCreateEvent;
	}
}