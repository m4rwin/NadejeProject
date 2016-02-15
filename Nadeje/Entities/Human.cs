using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadeje.Entities
{
	public class Human
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool Genre { get; set; }
		public int BirthYear { get; set; }
		public bool ServicesForForeigners { get; set; } = false;
		public List<FirstAid> FirstAidList { get; set; }
		public List<ServiceInterruption> InteruptionList { get; set; }
	}
}
