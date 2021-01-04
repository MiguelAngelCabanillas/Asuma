﻿using System;
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
        private int id;
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
                this.id = (int)reader[4];
                this.rol = new Rol(rolName);
                reader.Close();
                bd.closeBD();
                
                if (!this.password.Equals(password))
                {
                    //bd.closeBD();
                    username = password = email = null;
                    rol = null;
                    id = -1;
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

                MySqlDataReader readerId = bd.Query("SELECT max(id) FROM user");
                readerId.Read();
                this.id = (int)readerId[0] + 1;
                readerId.Close();

                this.username = username;
                this.password = password;
                this.email = email;
                this.rol = new Rol(rolName);

                MySqlDataReader writer = bd.Query("INSERT INTO user (username, password, email, rolName, id) VALUES ('" + username + "','" + password + "','" + email + "','" + rolName + "', " + id + ")");
                writer.Close();
                bd.closeBD();

                FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/usuarios/", "Prueba", "");
                ftp.MakeFtpDirectory("" + id);

            }catch(Exception ex)
            {
                throw new Error(ex.Message);
            }

        }

        public static List<User> listaUsuariosAplicacion()
        {
            List<User> listaUsuarios = new List<User>();
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT username FROM user ");
            while (reader.Read())
            {
                User aux = new User((string)reader[0]);
                listaUsuarios.Add(aux);
            }
            reader.Close();
            bd.closeBD();

            return listaUsuarios;
        }


        public static List<string> listaEmailsUsuariosEnEvento(Event e)
        {
            List<string> listaEmails = new List<string>();
            string aux;
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT email FROM user WHERE username IN (SELECT userName FROM inscription WHERE idEvent = " + e.ID + ")");
            while (reader.Read())
            {
                aux = (string)reader[0];
                listaEmails.Add(aux);
            }
            reader.Close();
            bd.closeBD();

            return listaEmails;
        }

        public static bool buscarUsuarioRecuperacion(string nombreUsuario, string email)
        {
            bool existe = false;
            try
            {
                
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT id FROM user WHERE username = '" + nombreUsuario + "' AND email = '" + email + "'");
                if (reader.HasRows)
                {
                    existe = true;
                }
                reader.Close();
                bd.closeBD();
                
            } catch(Exception ex){

            }
            return existe;
        }

        public User(string username)
        {
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT * FROM user WHERE username = '" + username + "'");
                if (!reader.HasRows)
                {
                    throw new Error("Usuario incorrecto");
                }
                reader.Read();
                this.username = (string)reader[0];
                this.password = (string)reader[1];
                this.email = (string)reader[2];
                string rolName = (string)reader[3];
                this.id = (int)reader[4];
                this.rol = new Rol(rolName);
                reader.Close();
                bd.closeBD();
            }
            catch (Exception ex)
            {
                throw new Error(ex.Message);
            }
        }

        public string Username
        {
            get { return username; }
            set {
                BD bd = new BD();
                MySqlDataReader writer = bd.Query("UPDATE user SET username = '" + value + "' WHERE id = " + id + ";");
                writer.Close();
                bd.closeBD();
                this.username = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                BD bd = new BD();
                MySqlDataReader writer = bd.Query("UPDATE user SET email = '" + value + "' WHERE id = " + id + ";");
                writer.Close();
                bd.closeBD();
                this.email = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                BD bd = new BD();
                MySqlDataReader writer = bd.Query("UPDATE user SET password = '" + value + "' WHERE id = " + id + ";");
                writer.Close();
                bd.closeBD();
                this.password = value;
            }
        }

        public Rol Rol
        {
            get { return rol; }
        }

        public int Id
        {
            get { return id; }
        }

        public void borrarUsuario(User usuario)
        {
            if(usuario.Rol.Admin == 1 || usuario.id == this.id)
            {
                BD bd = new BD();
                MySqlDataReader writer = bd.Query("DELETE FROM user WHERE id = " + this.id + ";");
                writer.Close();
                bd.closeBD();
            }
        }

        public static void insertarToken(string username, string email, string token)
        {
            try
            {
                BD bd = new BD();
                MySqlDataReader writer = bd.Query("UPDATE user SET recoveryToken = '" + token + "' WHERE username = '" + username + "' AND email = '" + email + "';");
                writer.Close();
                bd.closeBD();
            }
            catch (Exception)
            {

            }
         
        }
 

        public static implicit operator string(User v)
        {
            throw new NotImplementedException();
        }
    }
}
