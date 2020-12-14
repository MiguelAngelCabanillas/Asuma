using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySqlConnector;
using System.Threading.Tasks;

namespace Asuma
{
    public class Forum
    {
        private int _idForo; 
        private Event _evento;
        public Forum(int idForo)
        {
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT * FROM forum WHERE forumID = " + idForo + ";");
                reader.Read();
                _idForo = (int)reader[0];
                _evento = new Event((int)reader[1]);
                reader.Close();
                bd.closeBD();
            }
            catch (Exception e)
            {
                throw new Error(e.Message);
            }
        }
        public Forum(Event evento)
        {
            try
            {
                BD bd = new BD();
                MySqlDataReader writer = bd.Query("INSERT INTO forum (`eventID`) VALUES("+ evento.ID +")");
                writer.Read();
                _evento = evento;
                writer.Close();
                MySqlDataReader reader = bd.Query("SELECT MAX(eventID) FROM forum");
                reader.Read();
                _idForo = (int)reader[0];
                reader.Close();
                bd.closeBD();
            }
            catch (Exception e)
            {
                throw new Error(e.Message);
            }
        }
        public int ID
        {
            get { return this._idForo; }
        }

        public Event evento
        {
            get { return this._evento; }
        }
    }
}
