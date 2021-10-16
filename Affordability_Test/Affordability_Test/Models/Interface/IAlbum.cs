using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Affordability_Test.Models.Interface
{

    /// <summary>
    /// http://jsonplaceholder.typicode.com/albums
    /// Model Interface for jsonplaceholder albums api
    /// </summary>
    public interface IAlbum
    {
        int UserId { get; set; }
        int Id { get; set; }
        string Title { get; set; }
    }
}
