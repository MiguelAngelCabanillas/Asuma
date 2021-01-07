﻿using System;
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
    public partial class Notificacion : Form
    {
        public Notificacion()
        {
            InitializeComponent();
        }

        private void Notificacion_Resize(object sender, EventArgs e)
        {
            int tamaño = this.Width;
            this.lInfo.Location = new Point((tamaño * 4) / 10, lInfo.Location.Y);
        }

        private void tSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (tSubject.Text.Trim(' ').Equals("") || tMessage.Text.Trim(' ').Equals(""))
                {
                    MessageBox.Show("Debe rellenar todos los campos");
                }
                else
                {
                    List<string> listaEmails = User.listaEmailsUsuariosEnEvento(new Event(61));
                    Email email = new Email();
                    string asunto = tSubject.Text;
                    string cuerpo = tMessage.Text;
                    email.sendEmailToVarious(listaEmails, asunto, cuerpo, new Event(61).EventName);
                    MessageBox.Show("Notificación enviada con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
