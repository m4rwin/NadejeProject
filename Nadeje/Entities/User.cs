namespace Nadeje.Entities
{
	public enum UserType
	{
		SP, // Socialni Pracovnik
		PSS, // Pracovnik v Socialnich Sluzbach
		ADMIN
	}

	public class User
	{
		public int Id { get; set; }
		public string Nick { get; set; }
		public string Psw { get; set; }
		public UserType Type { get; set; }

		internal bool IsUser()
		{
			if (this.Nick.Equals("eva") && this.Psw.Equals("eva"))
			{
				this.Type = UserType.SP;
				return true;
			}
			else if (this.Nick.Equals("martin") && this.Psw.Equals("martin"))
			{
				this.Type = UserType.PSS;
				return true;
			}
			else if(this.Nick.Equals("marwin") && this.Psw.Equals("marwin"))
			{
				this.Type = UserType.ADMIN;
				return true;
			}
			return false;
		}
	}
}
