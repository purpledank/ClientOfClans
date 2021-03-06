﻿using System.Collections.Generic;

namespace ClientOfClans.Objects.Clans
{
    public class ClansSearchResult
    {
        public IReadOnlyCollection<ClanData> Clans { get; internal set; }
        public string Before { get; internal set; }
        public string After { get; internal set; }
    }
}
