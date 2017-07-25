﻿using OGL.Common;
using System;
using System.Collections.Generic;

namespace OGL.Features
{
    public class ItemChoiceConditionFeature : Feature
    {
        public int Amount { get; set; }
        public String UniqueID { get; set; }
        public String Condition { get; set; }
        public ItemChoiceConditionFeature()
            : base()
        {
            Amount = 1;
            Condition = "";
        }
        public ItemChoiceConditionFeature(string name, string text, string uniqueID, String condition, int amount = 1, int level = 1, bool hidden = false)
            : base(name, text, level, hidden)
        {
            Amount = amount;
            UniqueID = uniqueID;
            Condition = condition;
        }
        
        public List<Item> getItems(IChoiceProvider provider, OGLContext context)
        {
            List<Item> res = new List<Item>();
            int offset = provider.GetChoiceOffset(this, UniqueID, Amount);
            for (int c = 0; c < Amount; c++)
            {
                String counter = "";
                if (c + offset> 0) counter = "_" + (c + offset).ToString();
                Choice cho = provider.GetChoice(UniqueID + counter);
                if (cho != null && cho.Value != "") res.Add(context.GetItem(cho.Value, Source));
            }
            return res;
        }
        public override string Displayname()
        {
            return "Item Choice by Expression Feature";
        }
    }
}
