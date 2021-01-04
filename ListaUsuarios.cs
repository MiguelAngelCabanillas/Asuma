using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Asuma
{
    public partial class ListaUsuarios : Form
    {
        User usuario;
        string seleccionado = "";

        public ListaUsuarios(User usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            mostrarParticipantes();
        }

        public void mostrarParticipantes()
        {

            panelParticipantes.Controls.Clear();
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT username, id  FROM `user`  WHERE id != " + usuario.Id + " AND id NOT IN ((SELECT user1 FROM conversation WHERE user2 = " + usuario.Id + ") UNION (SELECT user2 FROM conversation WHERE user1 = " + usuario.Id + "));");
            int separacionV = 5, separacionH = 10;// this.Width - (panelParticipantes.Width);
            int i = 0;
            while (reader.Read())
            {
                string name = (string)reader[0];
                int id = (int)reader[1];
                //string imagen = listaParticipantes.ElementAt(i).;
                //string imagen = "";


                Panel panel = new Panel();
                panel.Name = "pUsuario" + id;
                panel.Size = new Size(200, 250);
                panel.Location = new Point(separacionH, separacionV);

                

                //------------------

                Label lUsuario = new Label();
                lUsuario.Text = name;
                lUsuario.Size = new Size(120, 30);
                lUsuario.AutoSize = true;
                lUsuario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lUsuario.Location = new Point(panel.Width / 2 - lUsuario.Text.Length * 5, 130);
                lUsuario.Visible = true;

                //------------------


                PictureBox pImagen = new PictureBox();
                pImagen.BackColor = SystemColors.ActiveCaption;
                pImagen.Location = new Point(panel.Width / 2 - pImagen.Width / 2, 10);
                pImagen.Name = "pImagen";

                Image image;
                if (FTPClient.ftpOn)
                {
                    try
                    {
                        FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/usuarios/" + id + "/", "Prueba", "");
                        pImagen.Image = ftp.DownloadPngAsImage("image.png", pImagen.Size);
                    }
                    catch (Exception)
                    {
                        //FTPClient.ftpOn = false;
                        pImagen.Image = null;
                    }
                }
                else
                {
                    pImagen.Image = null;
                }
                pImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pImagen.Size = new Size(100, 100);
                pImagen.TabIndex = 0;
                pImagen.TabStop = false;
                pImagen.Visible = true;
                pImagen.BorderStyle = BorderStyle.FixedSingle;


                //------------------------------------------

                
                Button lButton = new Button();
                lButton.Name = name;
                lButton.Text = "Seleccionar";
                lButton.Size = new Size(120, 30);
                lButton.AutoSize = true;
                lButton.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lButton.Location = new Point(panel.Width / 2 - lButton.Text.Length * 5, 200);
                lButton.Click +=lButton_Click;
                lButton.Visible = true;


                //------------------

                panel.Visible = true;
                panel.BorderStyle = BorderStyle.FixedSingle;


                panel.Controls.Add(lUsuario);
                panel.Controls.Add(pImagen);
                panel.Controls.Add(lButton);

                panelParticipantes.Controls.Add(panel);
                separacionH += panel.Width; //+ 50;
                if (i != 0 && (i + 1) % 4 == 0)
                {
                    separacionH = 10;//this.Width - (panelParticipantes.Width);
                    separacionV += /*360;*/panel.Height + 2;
                }
                i++;
            }
            panelParticipantes.BorderStyle = BorderStyle.FixedSingle;
            reader.Close();
            bd.closeBD();
       }

        private void lButton_Click(object sender, EventArgs e)
        {
            seleccionado = ((Button)sender).Name;
            int id = 0;
            int idUser = Commons.GetUserIdByName(seleccionado);
            BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT MAX(id) FROM conversation");
                if (!reader.HasRows) 
                {
                
                }
                else
                {
                    reader.Read();
                    id = ((int)reader[0]) + 1;
                    reader.Close();
                    MySqlDataReader writer = bd.Query("INSERT INTO conversation VALUES (" + id + ", " + usuario.Id + ", " + idUser + ");");
                    writer.Close();
                    bd.closeBD();
                    Conversaciones conv = new Conversaciones(seleccionado, usuario);
                    this.Visible = false;
                    conv.Owner = this;
                    conv.ShowDialog();
                    this.Close();
                }            
        }
    }
}
