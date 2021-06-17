using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spotify_Together.Models;

namespace Spotify_Together.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotifyController : ControllerBase
    {
        [HttpGet("Spotify/Authorization/{code}")]
        public async Task<SpotifyToken> GetToken(string code)
        {
            var token = new SpotifyToken();

            HttpClient client = new HttpClient();

            try
            {
                var url = "https://accounts.spotify.com/api/token?grant_type=authorization_code&code=" + code + "&redirect_uri=https%3A%2F%2Flocalhost:5001%2FHome%2FSuccess";
                HttpResponseMessage responseMessage = await client.GetAsync(url);
                responseMessage.EnsureSuccessStatusCode();
                return responseMessage.Content.;
            }
        }
    }
}