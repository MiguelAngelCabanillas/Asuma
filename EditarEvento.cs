﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Asuma
{
    public partial class EditarEvento : Form
    {
        public Event evento;
        public User usuario;
        private Forum foro;
        private string imagen = "";
        public EditarEvento(Event e, User usuario)
        {
            this.evento = e;
            this.usuario = usuario;
            InitializeComponent();
            tDescription.AutoSize = false;
            tDescription.Height = 80;
            lUsername.Text = "Bienvenido " + usuario.Username;
            tTitle.Text = evento.EventName;
            tDescription.Text = evento.EventDescription;
            tOrganizer.Text = evento.Organizer;
            DateTime date = DateTime.Parse(evento.Date);
            tDatePicker.Value = date;

            //Image image = Image.FromFile(imagePath);
            tImage.Text = evento.Image;
            string path = Path.GetDirectoryName(Application.StartupPath);
            string pathBueno = path.Substring(0, path.Length - 3);
            string imagePath = pathBueno + "images\\" + evento.Image;
            Image image;
            if (FTPClient.ftpOn)
            {
                try
                {
                    FTPClient ftpClient = new FTPClient("ftp://25.35.182.85:12975/eventos/" + evento.ID + "/", "Prueba", "");
                    byte[] byteArrayIn = ftpClient.DownloadFileBytesInArray("image.png");
                    using (var ms = new MemoryStream(byteArrayIn))
                    {
                        image = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    image = null;
                }


            }
            else { image = Image.FromFile(imagePath); }

            pImage.Image = image;
            pImage.SizeMode = PictureBoxSizeMode.StretchImage;

            actualizarElementos();
        }

        private void pASUMA_Paint(object sender, PaintEventArgs e)
        {
            //this.pASUMA.Location = new Point((this.Width * 4) / 10, pASUMA.Location.Y);
            this.pASUMA.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pASM_Paint(object sender, PaintEventArgs e)
        {
            //this.pASM.Location = new Point((this.Width * 7) / 10, pASM.Location.Y);
            this.pASM.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pUser_Paint(object sender, PaintEventArgs e)
        {
            this.pUser.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void menuFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            this.menuFlowLayoutPanel.Location = new Point(15, menuFlowLayoutPanel.Location.Y);
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bInicio.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
        }

        private void actualizarElementos()
        {
            /*tTitle.Text = evento.EventName;
            tDescription.Text = evento.EventDescription;
            tImage.Text = evento.Image;
            string path = Path.GetDirectoryName(Application.StartupPath);
            string pathBueno = path.Substring(0, path.Length - 3);
            string imagePath = pathBueno + "images\\" + evento.Image;
            Image image = Image.FromFile(imagePath);
            pImage.Image = image;
            tOrganizer.Text = evento.Organizer;
            DateTime date = DateTime.Parse(evento.Date);
            tDatePicker.Value = date;*/
            this.pUser.Location = new Point(72, 16);
            lSignOut.Location = new Point(lUsername.Location.X, lUsername.Location.Y + 40);
            this.lUsername.Location = new Point(pUser.Location.X + 120, pUser.Location.Y + 40);
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bInicio.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;

            this.pASUMA.Location = new Point((this.Width * 4) / 10, pASUMA.Location.Y);
            this.pASM.Location = new Point((this.Width * 7) / 10, pASM.Location.Y);

            this.panel1.Location = new Point(this.bInicio.Location.X + 100, this.menuFlowLayoutPanel.Location.Y + 80);
            this.panel1.Size = new Size(this.menuFlowLayoutPanel.Width, this.Height - this.menuFlowLayoutPanel.Location.Y - 30);

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            
            Cursor.Current = Cursors.WaitCursor;
            /*
            InfoEventoInscrito ei = new InfoEventoInscrito(evento, usuario);
            ei.Show();
            this.Close();
            */
            this.Close();
        }

        private void bConfirmEvent_Click(object sender, EventArgs e)
        {
            try
            {
                string title = tTitle.Text;
                string description = tDescription.Text;
                string image = tImage.Text;
                string organizer = tOrganizer.Text;
                string date = tDatePicker.Value.ToString();
                BD bd = new BD();
                MySqlDataReader writer = bd.Query("UPDATE event SET eventName = '" + title + "', date = '" + date + "', image = '" + image + "', eventDescription = '" + description + "', organizer = '" + organizer + "' WHERE idEvent = " + evento.ID);
                MessageBox.Show("Se ha editado el evento correctamente");
                writer.Close();
                bd.closeBD();
                this.Owner.Close();
                this.Close();

                if (FTPClient.ftpOn)
                {
                    FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/", "Prueba", "");
                    try
                    {
                        ftp.MakeFtpDirectory("eventos/" + evento.ID);
                    }
                    catch (Exception ex) { }
                    ftp.UploadFile(imagen, "/eventos/" + evento.ID + "/image.png");
                }

            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void bDeleteEvent_Click(object sender, EventArgs e)
        {
            try
            {
                BD bd = new BD();
                MySqlDataReader writer = bd.Query("DELETE FROM event WHERE idEvent = " + evento.ID);
                writer.Close();
                bd.closeBD();
                FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/", "Prueba", "");
                ftp.DeleteFTPDirectory("eventos/" + evento.ID + "/");
                MessageBox.Show("Evento eliminado con éxito");
                this.Owner.Close();
                this.Close();

            }catch(Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Principal p = new Principal(usuario);
            p.Show();
            this.Owner.Owner.Close();
            this.Close();

        }

        private void bEventos_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Eventos ev = new Eventos(usuario);
            ev.Show();
            this.Owner.Owner.Close();
            this.Close();
        }

        private void EditarEvento_Resize(object sender, EventArgs e)
        {
            actualizarElementos();
        }

        private void linkForum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormForo formularioForo = new FormForo(foro, usuario);
            formularioForo.ShowDialog();
        }

        private void EditarEvento_Load(object sender, EventArgs e)
        {
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT forumID FROM forum WHERE eventID = " + evento.ID + ";");
                reader.Read();
                foro = new Forum((int)reader[0]);
                reader.Close();
                bd.closeBD();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

        private void bEscogerImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            char[] separadores = { '\\' };
            switch (openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length - 1].Split('.')[openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length - 1].Split('.').Length - 1])
            {
                case "png":
                case "PNG":
                case "jpg":
                case "JPG":
                case "jpeg":
                case "JPEG":
                    //ftp.UploadFile(openFileDialog1.FileName, "eventos/" + tTitle.Text + "/image.png"); //+ 

                    // Get file extension
                    //openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length - 1].Split('.')[openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length - 1].Split('.').Length-1]);
                    pImage.Image = (Image)(new Bitmap(Image.FromFile(openFileDialog1.FileName), pImage.Size));
                    imagen = openFileDialog1.FileName;


                    //MessageBox.Show("Se ha subido correctamente el archivo " + openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length - 1]);
                    break;
                default:
                    MessageBox.Show("Formatos compatibles: .png, .PNG, .jpg, .JPG, .jpeg, .JPEG");
                    break;
            }
        }

        private void linkVideochat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Directorios pftp = new Directorios(evento);
            pftp.ShowDialog();
        }
    }
}
