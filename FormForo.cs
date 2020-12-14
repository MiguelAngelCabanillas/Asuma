using System;
using MySqlConnector;
using System.Windows.Forms;

namespace Asuma
{
    public partial class FormForo : Form
    {
        private Forum _foro;
        public FormForo(Forum foro)
        {
            _foro = foro;
            InitializeComponent();
        }

        private void Foro_Load(object sender, EventArgs e)
        {
            lTitulo.Text = _foro.evento.EventName;
        }

        private void bAñadirTema_Click(object sender, EventArgs e)
        {
            string cmd = "OJUUUUUUUUUUUUU";
            listaTemas.Items.Add(cmd);
        }
    }
}
