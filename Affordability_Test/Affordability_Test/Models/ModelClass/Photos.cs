using Affordability_Test.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Affordability_Test.Models.ModelClass
{
    /// <summary>
    /// http://jsonplaceholder.typicode.com/photos
    /// Model Class for Jsonplaceholder photos Api
    /// </summary>
    public class Photos : IPhotos
    {
        public int AlbumId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public Uri Url { get; set; }
        public Uri ThumbnailUrl { get; set; }
    }
}
