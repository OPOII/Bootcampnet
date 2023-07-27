using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discoteque.Business.IServices;
using Discoteque.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Discoteque.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistService _artistService;

        public ArtistsController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var artist = await _artistService.GetArtistsAsync();
            return Ok(artist);
        }

        [HttpPost]
        public async Task<IActionResult> CreateArtist(Artist artist)
        {
            var created= await _artistService.CreateArtist(artist);
            return Ok(created);
        }
    }
}
