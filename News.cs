using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Asuma
{
    public class News
    {
        private int id;
        private string name;
        private string description;
        private string date;
        private string image;

        public News(int id)
        {
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT * FROM news WHERE id = " + id + ";");
            while (reader.Read())
            {
                this.id = (int)reader[0];
                this.name = (string)reader[1];
                this.description = (string)reader[2];
                this.date = (string)reader[3];
                this.image = (string)reader[4];
            }
            reader.Close();
            bd.closeBD();
        }

        public News(string name, string description, string image)
        {
            date = DateTime.Now.ToString();

            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT MAX(id) FROM news");
            reader.Read();
            this.id = (int)reader[0]+1;
            reader.Close();
            bd.closeBD();

            bd = new BD();
            MySqlDataReader writer = bd.Query("INSERT INTO news (`id`, `name`, `description`, `date`, `image`) VALUES ('" + id + "','" + name + "','" + description + "','" + date + "','" + image + "')");
            writer.Close();
            bd.closeBD();

        }

        public static List<News> listaNoticias()
        {
            List<News> lista = new List<News>();
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT id FROM news ORDER BY date ASC");
            while (reader.Read())
            {
                int id = (int)reader[0];
                News n = new News(id);
                lista.Add(n);
            }
            reader.Close();
            bd.closeBD();
            return lista;
        }

        public int ID
        {
            get { return this.id; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public string Description
        {
            get { return this.description; }
        }

        public string Date
        {
            get { return this.date; }
        }

        public string Image
        {
            get { return this.image; }
        }
    }
}
