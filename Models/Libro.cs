namespace BibliotecaMVC.Models
{
	public class Libro
	{
		public int Id { get; set; }
		public string Titolo { get; set; }
		public string Autore { get; set; }
		public bool Disponibilità { get; set; }

		//public Libro(int ID, string TITOLO, string AUTORE)
		//{
		//	Id = ID;
		//	Titolo = TITOLO;
		//	Autore = AUTORE;
		//	Disponibilità = true;
		//}
	}
}
