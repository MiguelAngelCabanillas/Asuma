using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Asuma
{
    class User
    {
        private string username;
        private string password;
        private string email;
        private string rolName;


        public User(string username, string password)
        {
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT * FROM user WHERE username = '" + username + "'");
                while (reader.Read())
                {
                    this.username = (string)reader[0];
                    this.password = (string)reader[1];
                    this.email = (string)reader[2];
                    this.rolName = (string)reader[3];
                }
                if(!this.password.Equals(password)){
                    username = password = email = rolName = null;
                    throw new Error("Usuario o contraseña incorrecta");
                }

            }
            catch
            {
                throw new Error("Usuario o contraseña incorrecta");
            }
        }

        public User(string username, string password, string email, string rolName)
        {
            try
            {
                BD bd = new BD();
                MySqlDataReader readerUsername = bd.Query("SELECT username FROM user where username = '" + username + "'");
                if (readerUsername.HasRows)
                {
                    throw new Error("El nombre de usuario ya existe");
                }
                MySqlDataReader readerEmail = bd.Query("SELECT username FROM user where email = '" + email + "'");
                if (readerEmail.HasRows)
                {
                    throw new Error("El email ya existe");
                }


                this.username = username;
                this.password = password;
                this.email = email;
                this.rolName = rolName;
                

            }catch
            {
                throw new Error("Error al insertar los datos");
            }

        }
    }
}
