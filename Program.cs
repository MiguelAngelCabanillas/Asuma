﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asuma
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            User s = new User("docente1", "d");
            //Application.Run(new Contacto(s));
            Application.Run(new Principal(null));
            //Application.Run(new MisEventos(new User("franB", "franB")));

        }
    }
}
