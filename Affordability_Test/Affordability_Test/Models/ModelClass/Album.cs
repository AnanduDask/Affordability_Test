using Affordability_Test.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Affordability_Test.Models.ModelClass
{
    /// <summary>
    /// http://jsonplaceholder.typicode.com/albums
    /// Model Class for jsonplaceholder albums Api
    /// </summary>
    public class Album : IAlbum
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<Photos> Photos { get; set; }
    }
}
