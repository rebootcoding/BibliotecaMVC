namespace BibliotecaMVC.Models
{
	public static class Manager
	{
		private static List<Utente> Utenti = new List<Utente>();
		private static List<Libro> Libri = new List<Libro>();
		private static List<Staff> Dipendenti = new List<Staff>();


		public static void AddUser()
		{
			//solo staff può aggiungere Utente - controllo
		}

		public static List<Libro> GetBooks()
		{
			return Libri;
		}

		public static void AddBook(Libro l)
		{
			Libri.Add(l);
		}

		public static void AddUser(Utente u)
		{
			Utenti.Add(u);
		}

		public static void Login(string Nome, string Cognome, string Password)
		{
			var utente = Manager.Utenti.Single(u => u.Nome == Nome && u.Cognome == Cognome && u.Password == Password);
			if (utente != null)
			{
				utente.Logged = true;
			}
			else
			{
				//messaggio "Non sei un utente registrato"
			}
		}

		
	}
}
