﻿using OGL.Base;
using OGL.Keywords;
using System;

namespace OGL.Items
{
    public class Armor: Tool
    {
        public int BaseAC { get; set; }
        public bool StealthDisadvantage { get; set; }
        public int StrengthRequired { get; set; }
        public Armor()
            : base()
        {
        }
        public Armor(Tool t): base (t)
        {
            BaseAC=10;
            StrengthRequired = 0;
            StealthDisadvantage = false;
        }
        public Armor(OGLContext context, String name, String description, Price price, int baseAC, double weight, int strengthrequired = 0, bool stealthdisadvantage=false, Keyword kw1 = null, Keyword kw2 = null, Keyword kw3 = null, Keyword kw4 = null, Keyword kw5 = null, Keyword kw6 = null, Keyword kw7 = null)
            : base(context, name, description, price, weight, kw1, kw2, kw3, kw4, kw5, kw6, kw7)
        {
            BaseAC = baseAC;
            StrengthRequired = strengthrequired;
            StealthDisadvantage = stealthdisadvantage;
        }
    }
}
