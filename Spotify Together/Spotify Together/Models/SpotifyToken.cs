﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Spotify_Together.Models
{
    public class SpotifyToken
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string scope { get; set; }
        public int expires_in { get; set; }
        public string refresh_token { get; set; }

    }
}
