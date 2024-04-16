using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using SpotifyAPIIntegrationApplication.Models;
using SpotifyAPIIntegrationApplication.Services;
using SpotifyAPIIntegrationApplication.Utils;

namespace SpotifyAPIIntegrationApplication.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class SpotifyController : ControllerBase
    {
        private IAlbumService _albumService;

        public SpotifyController(IAlbumService service)
        {
            _albumService = service;
        }
        [HttpGet]
        public async Task<ActionResult<Albums>> GetAlbums() 
        {
           var response = await _albumService.GetAlbums();

            return Ok(response);
        }
    }
}
