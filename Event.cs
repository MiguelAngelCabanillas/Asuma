using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asuma
{
    class Event
    {
        private int id;
        private string eventName;
        private MySqlDateTime date;
        private string image;
        private string eventDescription;
        private string organizer;

        public Event(int id)
        {
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT * FROM event WHERE idEvent = " + id + ";");
            while (reader.Read())
            {
                this.eventName = (string)reader[0];
                this.date = (MySqlDateTime)reader[1];
                this.image = (string)reader[2];
                this.eventDescription = (string)reader[3];
                this.organizer = (string)reader[4];
                this.id = (int)reader[5];
            }
            reader.Close();
        }

        public Event(int id, string eventName, MySqlDateTime date, string image, string eventDescription, string organizer)
        {
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("INSERT INTO event VALUES ('" + eventName + "', " + date + ", '"
                + image + "', '" + eventDescription + "', + '" + organizer + "', " + id + ");");
            while (reader.Read())
            {
                this.id = id;
                this.eventDescription = eventDescription;
                this.eventName = eventName;
                this.date = date;
                this.image = image;
                this.eventDescription = eventDescription;
                this.organizer = organizer;
            }
        }

        public int ID {
            get { return this.id; }
        }

        public string EventName
        {
            get { return this.eventName; }
        }

        public MySqlDateTime Date
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
    }
}
