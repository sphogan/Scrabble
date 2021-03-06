﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ScrabbleWeb.Shared
{
    public class GameListDto
    {
        public string MyUserId { get; set; }
        public IEnumerable<GameDto> ActiveGames { get; set; }
        public IEnumerable<GameDto> RecentGames { get; set; }
    }
}
