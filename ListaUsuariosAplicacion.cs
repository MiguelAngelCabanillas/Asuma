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
    public partial class ListaUsuariosAplicacion : Form
    {
        public ListaUsuariosAplicacion()
        {
            InitializeComponent();
            crearDataGridView();
            dataGridUsers.Font = new Font("Verdana", 10);
        }

        private void crearDataGridView()
        {
            dataGridUsers.MultiSelect = false;
            dataGridUsers.DefaultCellStyle.Font = new Font("Verdana", 9);
            List<User> listaUsuarios = User.listaUsuariosAplicacion();
            foreach(User aux in listaUsuarios)
            {
                dataGridUsers.Rows.Add(aux.Username, aux.Email, aux.Rol.RolName, "Eliminar");
                
            }
        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridUsers.Columns["Column4"].Index && e.RowIndex >= 0)
            {
                int n = e.RowIndex;

                User s = new User((string)dataGridUsers.Rows[n].Cells[0].Value);
                s.borrarUsuario(s);
                MessageBox.Show("Usuario eliminado con éxito");
                dataGridUsers.Rows.RemoveAt(n);
            }
        }
    }


   
}
