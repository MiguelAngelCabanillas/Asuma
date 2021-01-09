﻿using MySqlConnector;
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
        private bool esCurso;
        private Forum _foro; 
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
                this.esCurso = (bool)reader[7];
            }
            reader.Close();
            bd.closeBD();
        }

        public Event(string eventName, string date, string image, string eventDescription, string organizer, string eventCreator, bool esCurso)
        {
            BD bd = new BD();
            //MySqlDataReader writer = bd.Query("INSERT INTO event VALUES ('" + eventName + "', '" + date + "', '"
            //  + image + "', '" + eventDescription + "', '" + organizer + "', '" + eventCreator + "');");
            MySqlDataReader writer = bd.Query("INSERT INTO event (`eventName`, `date`, `image`, `eventDescription`, `organizer`, `eventCreator`, `type`) VALUES ('" + eventName + "','" + date + "','" + image + "','" + eventDescription + "','" + organizer + "','" + eventCreator + "', " + (esCurso ? 1 : 0) + ");");
            writer.Close();
            bd.closeBD();

            bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT MAX(idEvent) FROM event");
            reader.Read();
            this.id = (int)reader[0];
            reader.Close();
            bd.closeBD();


            bd = new BD();
            MySqlDataReader writer2 = bd.Query("INSERT INTO inscription VALUES ('" + eventCreator + "', " + id + ")");
            this.eventName = eventName;
            this.date = date;
            this.image = image;
            this.eventDescription = eventDescription;
            this.organizer = organizer;
            this.eventCreator = eventCreator;
            this.esCurso = esCurso;

            writer2.Close();
            bd.closeBD();
        }

         public Event(int id, string eventName, string date, string image, string eventDescription, string organizer, string eventCreator, bool tipo)
        {
            this.id = id;
            this.eventName = eventName;
            this.date = date;
            this.image = image;
            this.eventDescription = eventDescription;
            this.organizer = organizer;
            this.eventCreator = eventCreator;
            this.esCurso = tipo;
        }


        public static List<Event> listaEventos()
        {
            List<Event> lista = new List<Event>();
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT idEvent, eventName, date, image, eventDescription, organizer, eventCreator, type  FROM event ORDER BY date ASC");
                while (reader.Read())
                {
                    Event e = new Event((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5], (string)reader[6], (bool)reader[7]);
                    //Event e = new Event((int)reader[0]);
                    lista.Add(e);
                }
            reader.Close();
            bd.closeBD();
            return lista;   
        }

        public static List<Event> listaActividades()
        {
            List<Event> lista = new List<Event>();
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT idEvent, eventName, date, image, eventDescription, organizer, eventCreator, type  FROM event WHERE type = 0 ORDER BY date ASC");
            while (reader.Read())
            {
                Event e = new Event((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5], (string)reader[6], (bool)reader[7]);
                lista.Add(e);
            }
            reader.Close();
            bd.closeBD();
            return lista;
        }

        public static List<Event> listaCursos()
        {
            List<Event> lista = new List<Event>();
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT idEvent, eventName, date, image, eventDescription, organizer, eventCreator, type  FROM event WHERE type = 1 ORDER BY date ASC");
            while (reader.Read())
            {
                Event e = new Event((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5], (string)reader[6], (bool)reader[7]);
                lista.Add(e);
            }
            reader.Close();
            bd.closeBD();
            return lista;
        }

        public static List<Event> listaEventosUsuario(User usuario)
        {
            List<Event> lista = new List<Event>();
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT e.idEvent, e.eventName, e.date, e.image, e.eventDescription, e.organizer, e.eventCreator, e.type FROM inscription i left join event e ON (i.idEvent = e.idEvent) WHERE i.userName = '" + usuario.Username + "'");
            while (reader.Read())
            {
                Event e = new Event((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5], (string)reader[6], (bool)reader[7]);
                lista.Add(e);
            }
            reader.Close();
            bd.closeBD();
            return lista;
        }

        public static List<Event> listaActividadesUsuario(User usuario)
        {
            List<Event> lista = new List<Event>();
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT e.idEvent, e.eventName, e.date, e.image, e.eventDescription, e.organizer, e.eventCreator, e.type FROM inscription i inner join event e ON (i.idEvent = e.idEvent) WHERE i.userName = '" + usuario.Username + "' AND e.type = 0;");
            while (reader.Read())
            {
                Event e = new Event((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5], (string)reader[6], (bool)reader[7]);
                lista.Add(e);
            }
            reader.Close();
            bd.closeBD();
            return lista;
        }

        public static List<Event> listaCursosUsuario(User usuario)
        {
            List<Event> lista = new List<Event>();
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT e.idEvent, e.eventName, e.date, e.image, e.eventDescription, e.organizer, e.eventCreator, e.type FROM inscription i inner join event e ON (i.idEvent = e.idEvent) WHERE i.userName = '" + usuario.Username + "' AND e.type = 1;");
            while (reader.Read())
            {
                Event e = new Event((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5], (string)reader[6], (bool)reader[7]);
                lista.Add(e);
            }
            reader.Close();
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
                lista.Add((int)reader[0]);
            }
            reader.Close();
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

        public bool EsCurso
        {
            get { return this.esCurso; }
        }
    }
}
