using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asuma
{
    /*
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
            User s = new User("docente3", "d");
            User admin = new User("admin", "admin");
            User fran = new User("franB");
            //Application.Run(new Contacto(s));
            //Application.Run(new Cuestionario_Satisfaccion("1_3", 1, 2, 2, 1, 1, "Hola a todos"));
            //Application.Run(new MisEventos(new User("franB", "franB")));
            //Application.Run(new Surveys_Evento(new Event(62)));
            //Application.Run(new Test_Conocimiento_Edicion(new Event(115)));
            //Application.Run(new Contacto(null));
            //Application.Run(new PruebaWord());
            //Application.Run(new InfoEventoInscrito(new Event(62), s));
            //Application.Run(new Principal(null));
            //Application.Run(new CrearEvento(s));
            //Application.Run(new EditarEvento(new Event(62), s));
            //Application.Run(new CrearNoticia(s));
        }
    }
    */

    public class MyApplication : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        public MyApplication()
            : base(Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
        {
            this.IsSingleInstance = false;
            this.EnableVisualStyles = true;

            //Aqui esta el truco
            this.ShutdownStyle = Microsoft.VisualBasic.ApplicationServices.
                ShutdownMode.AfterAllFormsClose;
        }

        protected override void OnCreateMainForm()
        {
            this.MainForm = new Principal(null);
            //this.MainForm = new Contacto(null);
            //this.MainForm = new CrearNoticia(new User("franB"));
            //this.MainForm = new EditarEvento(new Event(62), new User("franB"));
            //this.MainForm = new EditarNoticia(new News(2), new User("franB"));
            //this.MainForm = new Eventos(s);
            //this.MainForm = new InfoEvento(e, s);
            //this.MainForm = new InfoEventoInscrito(e, s);
            //this.MainForm = new InfoNoticia(new News(2), s);
            //this.MainForm = new Informacion(s);
            //this.MainForm = new ListaParticipantes(s, e);
            //this.MainForm = new MisEventos(s);
            //this.MainForm = new PruebaWord();
        }

        [STAThread]
        internal static void Main(string[] Args)
        {
            string[] arg; arg = new string[0];
            new MyApplication().Run(arg);
        }

    }
}
