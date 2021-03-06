﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Asuma
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void lUsername_Click(object sender, EventArgs e)
        {

        }

        private void cUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cUserType.Text.Equals("Usuario"))
            {
                lCode.Visible = true;
                tCode.Visible = true;
            }
            else
            {
                lCode.Visible = false;
                tCode.Visible = false;
            }
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            try
            {
                
                string username = tUsername.Text;
                string email = tEmail.Text;
                string password = tPassword.Text;
                string repeatedPassword = tRepeatPassword.Text;
                string userType = cUserType.Text;
                string code = tCode.Text;
                bool terms = cTerms.Checked;
                if (!terms)
                {
                    MessageBox.Show("Debe aceptar los términos y condiciones para continuar");
                }else if (username.Equals(""))
                {
                    MessageBox.Show("Debe introducir un nombre de usuario");
                }
                else if (email.Equals(""))
                {
                    MessageBox.Show("Debe introducir un email");
                } 
                else if (password.Equals(""))
                {
                    MessageBox.Show("Debe introducir una contraseña");
                } 
                else if (repeatedPassword.Equals(""))
                {
                    MessageBox.Show("Debe introducir de nuevo su contraseña");
                } 
                else if (userType.Equals(""))
                {
                    MessageBox.Show("Debe introducir un tipo de usuario");
                } 
                else if (!userType.Equals("Usuario") && code.Equals(""))
                {
                    MessageBox.Show("Debe introducir su código");
                } 
                else if (!password.Equals(repeatedPassword))
                {
                    MessageBox.Show("Las contraseñas introducidas no coinciden");
                }
                else if(userType.Equals("Docente") || userType.Equals("ONG"))
                {
                    BD bd = new BD();
                    MySqlDataReader reader = bd.Query("SELECT * FROM codes WHERE code = '" + code + "'");
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string roleName = (string)reader[1];
                        reader.Close();
                        bd.closeBD();
                        if (userType.Equals(roleName))
                        {
                            User user = new User(username, password, email, userType);
                            MessageBox.Show("Registro realizado con exito");
                            this.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Codigo introducido incorrecto");
                    }
                }
                else
                {
                    User user = new User(username, password, email, userType);
                    MessageBox.Show("Registro realizado con exito");
                    this.Visible = false;
                }                
            }
            catch(Exception ex)
            {
                throw new Error(ex.Message);
            }
        }
    }
}
