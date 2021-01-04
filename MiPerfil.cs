using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asuma
{
    public partial class MiPerfil : Form
    {
        User usuario;
        public MiPerfil(User usuario)
        {
            InitializeComponent();
            this.Text = "Perfil de " + usuario.Username;
            this.usuario = usuario;
            try
            {
                FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/usuarios/" + usuario.Id + "/", "Prueba", "");
                pUsuario.Image = ftp.DownloadPngAsImage("image.png", pUsuario.Size);
            }
            catch (Exception ex)
            {
                pUsuario.Image = null;
            }
            tUsername.Text = usuario.Username;
            tEmail.Text = usuario.Email;
        }

        private void bNombre_Click(object sender, EventArgs e)
        {
            if (tUsername.Text != usuario.Username)
            {
                usuario.Username = tUsername.Text;
                this.Text = "Perfil de " + usuario.Username;
                MessageBox.Show("Nombre cambiado correctamente");
            }
        }

        private void bBorrarCuenta_Click(object sender, EventArgs e)
        {
            usuario.borrarUsuario(usuario);
            try
            {
                FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/usuarios/", "Prueba", "");
                ftp.DeleteFTPDirectory("" + usuario.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: MiPerfil.cs bBorrarCuenta_Click");
            }
            MessageBox.Show("Cuenta eliminada con exito");
            
            Inicio.usuario = null;
            this.Close();
        }

        private void bImagen_Click(object sender, EventArgs e)
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
                    pUsuario.Image = (Image)(new Bitmap(Image.FromFile(openFileDialog1.FileName), pUsuario.Size));
                    FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/usuarios/" + usuario.Id + "/", "Prueba", "");
                    ftp.UploadFile(openFileDialog1.FileName, "image.png");


                    //MessageBox.Show("Se ha subido correctamente el archivo " + openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length - 1]);
                    break;
                default:
                    MessageBox.Show("Formatos compatibles: .png, .PNG, .jpg, .JPG, .jpeg, .JPEG");
                    break;
            }
        }

        private void bMail_Click(object sender, EventArgs e)
        {
            if (tEmail.Text != usuario.Email)
            {
                usuario.Email = tEmail.Text;
                MessageBox.Show("Correo cambiado correctamente");
            }
        }
    }
}
