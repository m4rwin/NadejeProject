using System;
using System.Collections.Generic;
using System.Linq;

namespace Nadeje.Entities
{
	public class Human
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool Genre { get; set; } = true;
		public string GenrePicture { get; set; } = "pack://application:,,,/Nadeje;component/Pictures/man.png";
		public int BirthYear { get; set; }
		public bool ServicesForForeigners { get; set; } = false;
		public List<FirstAid> FirstAidList { get; set; }
		public List<ServiceInterruption> InteruptionList { get; set; }

		private static int LastId = 3;
		public static List<Human> arr = new List<Human>()
	{
		new Human() { ID = 1, FirstName = "Martin", LastName = "Hromek", BirthYear = 1986, Genre = true, GenrePicture = "pack://application:,,,/Nadeje;component/Pictures/man.png", ServicesForForeigners = true,
		FirstAidList = new List<FirstAid>() { new FirstAid() { ID = 00001, From = new DateTime(2016, 2, 15, 16, 0, 0), To = new DateTime(2016, 2, 18, 15, 0, 0), Created = new DateTime(2016,2,14,22,0,2), WhoCreated = "Eva Březovská" },
		new FirstAid() { ID = 2, From = new DateTime(2016, 3, 5, 12, 0, 0), To = new DateTime(2016, 3, 10, 11, 0, 0), Created = new DateTime(2016,3,3,8,0,2), WhoCreated = "Eva Březovská" }},
		InteruptionList = new List<ServiceInterruption>() { new ServiceInterruption() { ID = 1, From = new DateTime(2016, 2,14,16,00,10), To = new DateTime(2016,3,10,11,0,20), Created = DateTime.Now, WhoCreated = "Eva Březovská", Reason = "Opilost", Note = "Choval se nezdvořile k sociálním pracovníkům" } } },
		new Human() { ID = 2, FirstName = "Johnny", LastName = "Rambo", BirthYear = 1952, Genre = true, GenrePicture = "pack://application:,,,/Nadeje;component/Pictures/man.png", ServicesForForeigners = false },
		new Human() { ID = 3, FirstName = "Eva", LastName = "Březovská", BirthYear = 1989, Genre = false, GenrePicture = "pack://application:,,,/Nadeje;component/Pictures/woman.png", ServicesForForeigners = false }
	};

		public bool Add()
		{
			if(this.ID == 0)
			{
				this.ID = ++LastId;
				arr.Add(this);
			}
			else
			{
				var v = arr.Where(item => item.ID == this.ID).Select( ii => ii);
				arr.Add(v as Human);
			}
			return true;
		}
	}
}
