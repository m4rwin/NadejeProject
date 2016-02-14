using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadeje.Entities
{
	public class FirstAid
	{
		public int ID { get; set; }
		public DateTime From { get; set; }
		public DateTime To { get; set; }
		public DateTime Created { get; set; }
		public string WhoCreated { get; set; }
	}
}
