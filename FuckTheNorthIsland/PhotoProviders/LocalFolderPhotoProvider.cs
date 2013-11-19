using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using FuckTheNorthIsland.Models;

namespace FuckTheNorthIsland.PhotoProviders {
	public class LocalFolderPhotoProvider : IPhotoProvider{

		private string _rootPath;

		public LocalFolderPhotoProvider() {
			
			_rootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images");
		}

		public IEnumerable<Models.Photo> GetPhotos(string album) {
			var folder = Path.Combine(_rootPath, album);
			if (!Directory.Exists(folder))
				return new List<Photo>();

			var photos = Directory.EnumerateFiles(folder)
				.Select(f => new Photo() {
					Title = Path.GetFileNameWithoutExtension(f),
					Url = string.Concat("/images/", album, "/", Path.GetFileName(f))
				});

			return photos;
		}
	}
}