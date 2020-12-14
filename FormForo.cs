using System;
using MySqlConnector;
using System.Windows.Forms;

namespace Asuma
{
    public partial class FormForo : Form
    {
        private Forum _foro;
        private User _usuario;
        public FormForo(Forum foro, User usuario)
        {
            _foro = foro;
            _usuario = usuario;
            InitializeComponent();
        }

        private void Foro_Load(object sender, EventArgs e)
        {
            lTitulo.Text = _foro.evento.EventName;
            if (!_usuario.Username.Equals(_foro.evento.EventCreator))
            {
                bEliminar.Enabled = false;
                bEliminar.Visible = false;
            }
            else
            {
                bEliminar.Enabled = true;
                bEliminar.Visible = true;
            }
        }

        private void bAñadirTema_Click(object sender, EventArgs e)
        {
            string cad = tituloTema.Text.Trim();
            if (cad != "")
            {
                string cmd = cad;
                listaTemas.Items.Add(cmd);
            }
            else
            {
                MessageBox.Show("Necesita añadir un titulo al tema");
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            object selec = listaTemas.SelectedItem;
            listaTemas.Items.Remove(selec);
        }
    }
}
