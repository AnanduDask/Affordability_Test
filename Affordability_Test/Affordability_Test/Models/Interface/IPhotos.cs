using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Affordability_Test.Models.Interface
{

    /// <summary>
    /// http://jsonplaceholder.typicode.com/photos
    /// Model Interface for jsonplaceholder photos api
    /// </summary>
    public interface IPhotos
    {
        int AlbumId { get; set; }
        int Id { get; set; }
        string Title { get; set; }
        Uri Url { get; set; }
        Uri ThumbnailUrl { get; set; }
    }
}
