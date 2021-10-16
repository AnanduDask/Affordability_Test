using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Affordability_Test.Models.Interface
{

    /// <summary>
    /// Interface for RESTFul Web API
    /// </summary>
    public interface IJasonPlaceholderRestApi
    {
        Task<ActionResult<IEnumerable<IAlbum>>> Get();
        Task<ActionResult<IEnumerable<IAlbum>>> Get(int userId);
    }
}
