using System;
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
	public partial class MyEvents : Form
	{
		//private User u;
		public MyEvents(/*User u*/)
		{
			/*List<Event> eventos = Event.EventList(u);
			this.u = u;
			foreach e in eventos{
				EventInfo ei = new EventInfo(e);
				//EnventInfo va a crear la imagen(botón) y la descripcion de cada evento
			}*/
			InitializeComponent();
		}

		private void MisEventos_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

        /*private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MyEvents
            // 
            this.ClientSize = new System.Drawing.Size(1135, 477);
            this.Name = "MyEvents";
            this.ResumeLayout(false);

        }*/

    }
}
