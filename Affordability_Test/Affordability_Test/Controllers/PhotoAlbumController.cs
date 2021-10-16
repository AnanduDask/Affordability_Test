using Affordability_Test.Models.Interface;
using Affordability_Test.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Affordability_Test.Controllers
{

    /// <summary>
    /// RESTApi to GET 
    /// * Calls, combines and returns the results of:
    /// http://jsonplaceholder.typicode.com/photos
    /// http://jsonplaceholder.typicode.com/albums
    /// </summary>
    
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoAlbumController : ControllerBase, IJasonPlaceholderRestApi
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IAlbum>>> Get()
        {
            try
            {
                JsonClient client = new JsonClient();
                BusinessLogic logic = new BusinessLogic(client);

                IEnumerable<IAlbum> response = await logic.GetAllAsync();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);   
            }
        }

        /// <summary>
        /// RESTApi to GET 
        /// * Calls, combines and returns the results of:
        /// http://jsonplaceholder.typicode.com/photos
        /// http://jsonplaceholder.typicode.com/albums
        /// It allows an integrator to filter on the user id, so just returns the albums and photos relevant
        /// to a single user.
        /// </summary>
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<IAlbum>>> Get(int userId)
        {
            try
            {
                JsonClient client = new JsonClient();
                BusinessLogic logic = new BusinessLogic(client);

                IEnumerable<IAlbum> response = await logic.GetFilteredAsync(userId);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); //+ " " + ex.StackTrace    
            }
        }
    }
}
