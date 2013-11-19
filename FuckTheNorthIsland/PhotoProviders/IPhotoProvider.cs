using FuckTheNorthIsland.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckTheNorthIsland.PhotoProviders {
	public interface IPhotoProvider {
		IEnumerable<Photo> GetPhotos(string album);
	}
}
