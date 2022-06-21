﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    internal class Player
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; } = "Trial";
        public string Description { get; set; } = "n/a";

        public Player(string name, string @class)
        {
            Name = name;
            Class = @class;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Player {Name}: {Class}");
            sb.AppendLine($"Rank: {Rank}");
            sb.Append($"Description: {Description}");
            return sb.ToString();
        }
    }
}
