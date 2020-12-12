using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asuma
{
    public class Event
    {
        private int id;
        private string eventName;
        private string date;
        private string image;
        private string eventDescription;
        private string organizer;
        private string eventCreator;
        public Event(int id)
        {
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT * FROM event WHERE idEvent = " + id + ";");
            while (reader.Read())
            {
                this.eventName = (string)reader[0];
                this.date = (string)reader[1];
                this.image = (string)reader[2];
                this.eventDescription = (string)reader[3];
                this.organizer = (string)reader[4];
                this.id = (int)reader[5];
                this.eventCreator = (string)reader[6];
            }
            reader.Close();
        }

        public Event(string eventName, string date, string image, string eventDescription, string organizer, string eventCreator)
        {
            BD bd = new BD();
            MySqlDataReader writer = bd.Query("INSERT INTO event VALUES ('" + eventName + "', '" + date + "', '"
                + image + "', '" + eventDescription + "', '" + organizer + "', '" + eventCreator + "');");
            bd.closeBD();

            BD bdId = new BD();
            MySqlDataReader reader = bd.Query("SELECT MAX(idEvent) FROM event");
            reader.Read();
            this.id = (int)reader[0]+1;
            bdId.closeBD();
            this.eventDescription = eventDescription;
            this.eventName = eventName;
            this.date = date;
            this.image = image;
            this.eventDescription = eventDescription;
            this.organizer = organizer;
            this.eventCreator = eventCreator;
            
        }


        public static List<Event> listaEventos()
        {
            List<Event> lista = new List<Event>();
            BD bd= new BD();
            MySqlDataReader reader = bd.Query("SELECT idEvent FROM event ORDER BY date ASC");
            while (reader.Read())
            {
                int id = (int)reader[0];
                Event e = new Event(id);
                lista.Add(e);
            }
            bd.closeBD();
            return lista;
        }

        public static List<Event> listaEventosUsuario(User usuario)
        {
            List<Event> lista = new List<Event>();
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT idEvent FROM inscription WHERE userName = '" + usuario.Username + "'");
            while (reader.Read())
            {
                int id = (int)reader[0];
                Event e = new Event(id);
                lista.Add(e);
            }
            bd.closeBD();
            return lista;
        }

        public static List<int> listaEventosCreados(User usuario)
        {
            List<int> lista = new List<int>();
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT idEvent FROM event WHERE eventCreator = '" + usuario.Username + "'");
            while (reader.Read())
            {
                int id = (int)reader[0];
                //Event e = new Event(id);
                lista.Add(id);
            }
            bd.closeBD();
            return lista;
        }


        public int ID {
            get { return this.id; }
        }

        public string EventName
        {
            get { return this.eventName; }
        }

        public string Date
        {
            get { return this.date; }
        }

        public string Image
        {
            get { return this.image; }
        }

        public string EventDescription
        {
            get { return this.eventDescription; }
        }

        public string Organizer
        {
            get { return this.organizer; }
        }

        public string EventCreator
        {
            get { return this.eventCreator; }
        }
    }
}
