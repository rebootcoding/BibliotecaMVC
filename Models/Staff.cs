namespace BibliotecaMVC.Models
{
	public class Staff
	{
		public string Nome { get; set; }
		public string Cognome { get; set; }
		private string Password { get; set; }

		public Staff(string NOME, string COGNOME, string PASSWORD)
		{
			Nome = NOME;
			Cognome = COGNOME;
			Password = PASSWORD;
		}

	}
}
