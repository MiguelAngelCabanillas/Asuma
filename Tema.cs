using System;
using System.Windows.Forms;
using MySqlConnector;



namespace Asuma
{
	public class Tema
	{
		private int id;
		private Forum foro;
		private string titulo;
		private string creador;

		public Tema(int id)
		{
			try
			{
				BD bd = new BD();
				MySqlDataReader reader = bd.Query("SELECT * FROM topic WHERE forumID = " + id + ";");
				reader.Read();
				this.id = (int)reader[0];
				this.foro = new Forum((int)reader[1]);
				this.titulo = (string)reader[2];
				this.creador = (string)reader[3];
				reader.Close();
				bd.closeBD();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public Tema(Forum foro, string titulo, string creador)
		{
			try
			{
				BD bd = new BD();
				MySqlDataReader reader = bd.Query("INSERT INTO topic (`forumID`, `title`, `creator`) VALUES (" + foro.ID + ",'" + titulo + "','" + creador + "')");
				reader.Read();
				this.foro = foro;
				this.titulo = titulo;
				this.creador = creador;
				reader.Close();
				bd.closeBD();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public int ID
		{
			get { return this.id; }
		}

		public Forum Foro
		{
			get { return this.foro; }
		}

		public string Titulo
		{
			get { return this.titulo; }
		}

		public string Creador
		{
			get { return this.creador; }
		}

	}
}