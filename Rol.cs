using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asuma
{
    public class Rol
    {
        private string rolName;
        private int admin;
        private List<Permission> permisos;

        public static List<Rol> ListaRoles()
        {
            List<Rol> lista = new List<Rol>();
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT R.ROLNAME FROM ROL R;");
            while (reader.Read())
            {
                foreach (object[] tupla in reader)
                {
                    string r = (string)tupla[0];
                    lista.Add(new Rol(r));
                }
            }
            
            return lista;
        }

        public Rol(string rolName)
        {
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT * FROM rol WHERE rolName = '" + rolName + "';");
            while (reader.Read())
            {
                this.rolName = (string)reader[0];
                this.admin = (int)reader[1];
            }
        }

        public Rol(string rolName, int admin)
        {
          //  BD bd = new BD();
           // MySqlDataReader reader = bd.Query("INSERT INTO ROL VALUES ('" + rolName + "', '" + (admin ? 1 : 0) + "');");
            //while (reader.Read())
            //{
              //  this.rolName = rolName;
                this.admin = admin;
                this.permisos = null;
           // }
        }

        public string RolName {
            get { return this.rolName; }
        }

        public int Admin
        {
            get { return this.admin; }
        }
    }
}
