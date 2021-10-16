using Affordability_Test.Models.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Affordability_Test.Models.JSON
{
    /// <summary>
    /// http://jsonplaceholder.typicode.com/photos
    /// Json Model Class for jsonplaceholder photos Api
    /// </summary>
    public class JsonPhotos : IPhotos
    {
        [JsonProperty(PropertyName = "albumId")]
        public int AlbumId { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "url")]
        public Uri Url { get; set; }

        [JsonProperty(PropertyName = "thumbnailUrl")]
        public Uri ThumbnailUrl { get; set; }

    }
}
