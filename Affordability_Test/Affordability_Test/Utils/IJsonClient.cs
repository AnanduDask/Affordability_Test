using Affordability_Test.Models.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Affordability_Test.Utils
{
    public interface IJsonClient
    {
        Task<IEnumerable<JsonAlbum>> GetAlbumsAsync();
        Task<IEnumerable<JsonPhotos>> GetPhotosAsync();
    }
}
