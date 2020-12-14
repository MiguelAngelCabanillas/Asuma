using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asuma
{
    public class Permission
    {
        private Rol rol;
        private string pantalla;

        public static List<Permission> ListaPermisosRol(Rol rol)
        {
            List<Permission> list = new List<Permission>();
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT P.SCREEN FROM PERMISSION P WHERE P.ROLNAME = '" + rol.RolName + "';");
            while (reader.Read())
            {
                foreach (object[] o in reader)
                {
                    string pantalla = (string) o[0];
                    list.Add(new Permission(rol, pantalla));
                }
            }
            return list;
        }

        public Permission(Rol r, string pantalla)
        {
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT * FROM PERMISSION P WHERE P.ROLNAME = '" + r + "' AND P.SCREEN = '" + pantalla + "';");
            while (reader.Read())
            {
                this.rol = new Rol((string)reader[0]);
                this.pantalla = (string)reader[1];
            }
        }

        public Rol Rol
        {
            get {return this.rol;}
        }

        public string Pantalla
        {
            get {return this.pantalla;}
        }
    }
}
