using System;
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
        public EditarEvento(Event e, User usuario)
        {
            this.evento = e;
            this.usuario = usuario;
            InitializeComponent();
            actualizar();
            tDescription.AutoSize = false;
            tDescription.Height = 80;
            tDescription.MaxLength = 300;
        }
        private void bExit_Click(object sender, EventArgs e)
        {
   
            Cursor.Current = Cursors.WaitCursor;
            InfoEventoInscrito ei = new InfoEventoInscrito(evento, usuario);
            ei.Show();
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
                InfoEventoInscrito ei = new InfoEventoInscrito(evento, usuario);
                ei.Show();
                this.Close();
               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void actualizar()
        {
            tTitle.Text = evento.EventName;
            tDescription.Text = evento.EventDescription;
            tImage.Text = evento.Image;
            string path = Path.GetDirectoryName(Application.StartupPath);
            string pathBueno = path.Substring(0, path.Length - 3);
            string imagePath = pathBueno + "images\\" + evento.Image;
            Image image = Image.FromFile(imagePath);
            pImage.Image = image;
            tOrganizer.Text = evento.Organizer;
            DateTime date = DateTime.Parse(evento.Date);
            tDatePicker.Value = date;



        }

        private void bDeleteEvent_Click(object sender, EventArgs e)
        {
            try
            {
                BD bd = new BD();
                MySqlDataReader writer = bd.Query("DELETE FROM event WHERE idEvent = " + evento.ID);
                MessageBox.Show("Evento eliminado con éxito");
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Principal p = new Principal(usuario);
            p.Show();
            this.Close();

        }

        private void bEventos_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Eventos ev = new Eventos(usuario);
            ev.Show();
            this.Close();
        }

        private void bForo_Click(object sender, EventArgs e)
        {
            FormForo formularioForo = new FormForo(foro);
        }

        private void EditarEvento_Load(object sender, EventArgs e)
        {
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT forumID FROM forum WHERE eventID = " + evento.ID + ";");
            reader.Read();
            foro = new Forum((int)reader[0]);
            reader.Close();
            bd.closeBD();
        }
    }
}
