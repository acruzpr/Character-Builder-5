﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Builder_5
{
    [Flags]
    public enum AbilityScoreModifikation {
        AddScore=0,
        Set=1,
        Maximum=2,
        Bonus=4
    }
    public class AbilityScoreFeature: Feature
    {
        public AbilityScoreFeature()
            : base("Ability Score Increase","",1,true)
        {
            Strength = 0;
            Constitution = 0;
            Dexterity = 0;
            Intelligence = 0;
            Wisdom = 0;
            Charisma = 0;
            Modifier = AbilityScoreModifikation.AddScore;
        }
        public AbilityScoreFeature(string name, string text, int str, int con, int dex, int intel, int wis, int cha, AbilityScoreModifikation mod = AbilityScoreModifikation.AddScore, int level = 1, bool hidden = false)
            : base(name, text, level, hidden)
        {
            Strength = str;
            Constitution = con;
            Dexterity = dex;
            Intelligence = intel;
            Wisdom = wis;
            Charisma = cha;
            Modifier = mod;
        }
        public AbilityScoreModifikation Modifier;
        public int Strength { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public override string Displayname()
        {
            return "Ability Score Feature";
        }
    }
}
