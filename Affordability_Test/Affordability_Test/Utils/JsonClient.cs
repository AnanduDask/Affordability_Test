using Affordability_Test.Models.JSON;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Affordability_Test.Utils
{
    public class JsonClient : HttpClient, IJsonClient
    {
        public JsonClient()
        {
            this.BaseAddress = new Uri(Environment.GetEnvironmentVariable("JsonPlaceholderUrl"));
        }

        public async Task<IEnumerable<JsonAlbum>> GetAlbumsAsync()
        {
            var albumPath = Environment.GetEnvironmentVariable("AlbumPath");
            var response = await this.GetAsync(albumPath);

            return await response.Content.ReadAsAsync<IEnumerable<JsonAlbum>>();
        }

        public async Task<IEnumerable<JsonPhotos>> GetPhotosAsync()
        {
            var photoPath = Environment.GetEnvironmentVariable("PhotoPath");
            var response = await this.GetAsync(photoPath);

            return await response.Content.ReadAsAsync<IEnumerable<JsonPhotos>>();
        }

        Task<IEnumerable<JsonAlbum>> IJsonClient.GetAlbumsAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<JsonPhotos>> IJsonClient.GetPhotosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
