using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Asuma
{
    public class User
    {
        private string username;
        private string password;
        private string email;
        private Rol rol;
        public User(string username, string password)
        {
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT * FROM user WHERE username = '" + username + "'");
                if (!reader.HasRows)
                {
                    //bd.closeBD();
                    throw new Error("Usuario o contraseña incorrecta");
                }
                reader.Read();
                this.username = (string)reader[0];
                this.password = (string)reader[1];
                this.email = (string)reader[2];
                string rolName = (string)reader[3];
                this.rol = new Rol(rolName);
                reader.Close();
                bd.closeBD();
                
                if (!this.password.Equals(password))
                {
                    //bd.closeBD();
                    username = password = email = null;
                    rol = null;
                    throw new Error("Usuario o contraseña incorrecta");
                }
                //bd.closeBD();
            }
            catch (Exception ex)
            {
                throw new Error(ex.Message);
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
                readerUsername.Close();

                MySqlDataReader readerEmail = bd.Query("SELECT username FROM user where email = '" + email + "'");
                if (readerEmail.HasRows)
                {
                    throw new Error("El email ya existe");
                }
                readerEmail.Close();
                this.username = username;
                this.password = password;
                this.email = email;
                this.rol = new Rol(rolName);

                MySqlDataReader writer = bd.Query("INSERT INTO user VALUES ('" + username + "','" + password + "','" + email + "','" + rolName + "')");
                writer.Close();
                bd.closeBD();

            }catch(Exception ex)
            {
                throw new Error(ex.Message);
            }

        }

        public string Username
        {
            get
            { return username; }
        }

        public string Email
        {
            get { return email; }
        }
        public string Password
        {
            get { return password; }
        }

        public Rol Rol
        {
            get { return rol; }
        }

        public static implicit operator string(User v)
        {
            throw new NotImplementedException();
        }
    }
}
