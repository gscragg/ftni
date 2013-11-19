using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuckTheNorthIsland.Models {
	public class Album {
		public string Name { get; set; }
		public string Description { get; set; }

		public List<Photo> Photos { get; set; }
	}
}