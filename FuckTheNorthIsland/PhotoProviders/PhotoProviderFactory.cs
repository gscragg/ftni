using FuckTheNorthIsland.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FuckTheNorthIsland.PhotoProviders {
	public class PhotoProviderFactory {
		public IEnumerable<Photo> GetAllPhotos() {
			var list = new ConcurrentBag<Photo>();

			var sources = new Func<IEnumerable<Photo>>[]{
				() => new LocalFolderPhotoProvider().GetPhotos("samples")
			};

			Parallel.ForEach(sources, todo => {
				var photos = todo();
				foreach (var p in photos) {
					list.Add(p);
				}
			});

			return list.ToList();
		}
	}
}