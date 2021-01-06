using System;
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
            User s = new User("docente2", "d");
            User admin = new User("admin", "admin");
            User fran = new User("franB");
            //Application.Run(new Contacto(s));
            //Application.Run(new Cuestionario_Satisfaccion("1_3", 1, 2, 2, 1, 1, "Hola a todos"));
            //Application.Run(new MisEventos(new User("franB", "franB")));
            //Application.Run(new Surveys_Evento(new Event(62)));
            //Application.Run(new Test_Conocimiento_Edicion(new Event(115)));
            //Application.Run(new Contacto(null));
            //Application.Run(new Principal(admin));
            //Application.Run(new PruebaWord());
            Application.Run(new InfoEventoInscrito(new Event(62), s));
            //Application.Run(new Principal(new User("franB")));
        }
    }
}
