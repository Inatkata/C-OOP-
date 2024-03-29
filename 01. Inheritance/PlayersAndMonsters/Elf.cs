﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Elf : Hero
    {
        public Elf(string username, int level) : base(username, level)
        {
            Username = username;
            Level = level;
        }

        public string Username  { get; set; }
        public int Level { get; set; }
    }
}
