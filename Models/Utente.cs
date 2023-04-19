namespace BibliotecaMVC.Models
{
	public class Utente
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Cognome { get; set; }
		public string Password { get; set; }
		public bool Logged { get; set; }
		public List<Libro> LibriInPrestito { get; set; }

		//public Utente(int ID, string NOME, string COGNOME, string PASS)
		//{
		//	Id = ID;
		//	Nome = NOME;
		//	Cognome = COGNOME;
		//	Password = PASS;
		//	Logged = false;
		//}
	}

	

}
