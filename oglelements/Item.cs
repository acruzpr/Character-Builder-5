﻿using NCalc;
using OGL.Base;
using OGL.Common;
using OGL.Items;
using OGL.Keywords;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OGL
{
    [XmlInclude(typeof(Tool)),
    XmlInclude(typeof(Weapon)),
    XmlInclude(typeof(Armor)),
    XmlInclude(typeof(Shield)),
    XmlInclude(typeof(Pack)),
    XmlInclude(typeof(Scroll))]
    public class Item : IComparable<Item>, IXML, IOGLElement<Item>, IOGLElement
    {
        [XmlArrayItem(Type = typeof(Keyword)),
        XmlArrayItem(Type = typeof(Versatile)),
        XmlArrayItem(Type = typeof(Range))]
        public List<Keyword> Keywords = new List<Keyword>();
        [XmlIgnore]
        public string filename;
        [XmlIgnore]
        public static XmlSerializer Serializer = new XmlSerializer(typeof(Item));
        [XmlIgnore]
        public bool autogenerated;
        public int StackSize { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Price Price { get; set; }
        public String Source { get; set; }
        public double Weight { get; set; }
        public string Unit { get; set; }
        public string SingleUnit { get; set; }
        [XmlIgnore]
        public Category Category { get; set; }
        [XmlIgnore]
        public Dictionary<string, bool> Matches;
        [XmlIgnore]
        public bool ShowSource { get; set; } = false;

        public byte[] ImageData { get; set; }
        public void Register(OGLContext context, String file)
        {
            filename = file;
            foreach (Keyword kw in Keywords) kw.check();
            string full = Name + " " + ConfigManager.SourceSeperator + " " + Source;
            if (context.Items.ContainsKey(full)) throw new Exception("Duplicate Item: " + full);
            context.Items.Add(full, this);
            if (context.ItemsSimple.ContainsKey(Name))
            {
                context.ItemsSimple[Name].ShowSource = true;
                ShowSource = true;
            }
            else context.ItemsSimple.Add(Name, this);
        }
        public Item()
        {
            Price = new Price();
            Weight = 0;
            autogenerated = false;
            StackSize = 1;
        }
        public Item(Category cat, String name)
        {
            Name = name;
            Description = "Missing Entry";
            Price = new Price();
            Weight = 0;
            autogenerated = true;
            StackSize = 1;
            Category = cat;
            Source = "Autogenerated Entry";
            ShowSource = true;
        }
        public Item(OGLContext context, String name, String description, Price price, double weight, int stacksize = 1, Keyword kw1 = null, Keyword kw2 = null, Keyword kw3 = null, Keyword kw4 = null, Keyword kw5 = null, Keyword kw6 = null, Keyword kw7 = null)
        {
            Name = name;
            Description = description;
            Price = price;
            Weight = weight;
            autogenerated = false;
            StackSize = stacksize;
            Category = Category.Make(context);
            Source = context.Config.DefaultSource;
            Keywords = new List<Keyword>() { kw1, kw2, kw3, kw4, kw5, kw6, kw7 };
            Keywords.RemoveAll(kw => kw == null);
            Register(context, null);
        }
        public Tool AsTool()
        {
            if (this is Tool)
            {
                return (Tool)this;
            }
            else
            {
                if (autogenerated)
                {
                    return new Tool(this);
                }
                else
                {
                    throw new Exception("Tried to use " + Name + " as a tool when it is not a tool");
                }
            }
        }
        public bool Test(OGLContext context)
        {
            if (Name != null && Name.ToLowerInvariant().Contains(context.Search)) return true;
            if (Description != null && Description.ToLowerInvariant().Contains(context.Search)) return true;
            if (Keywords != null && Keywords.Exists(k => k.Name == context.Search)) return true;
            return false;
        }
        public String ToXML()
        {
            using (StringWriter mem = new StringWriter())
            {
                Serializer.Serialize(mem, this);
                return mem.ToString();
            }
        }

        public MemoryStream ToXMLStream()
        {
            MemoryStream mem = new MemoryStream();
            Serializer.Serialize(mem, this);
            return mem;
        }
        public override string ToString()
        {
            string n;
            if (StackSize == 1 && SingleUnit != null) n = Name + " (" + SingleUnit + ")";
            else if (Unit == null) n = Name;
            else n = Name + " (" + StackSize + (Unit == null ? "" : " " + Unit) + ")";
            if (ShowSource || ConfigManager.AlwaysShowSource) return n + " " + ConfigManager.SourceSeperator + " " + Source;
            return n;
        }
        public int CompareTo(Item other)
        {
            return Name.CompareTo(other.Name);
        }
        
        public Item Clone()
        {
            using (MemoryStream mem = new MemoryStream())
            {
                Serializer.Serialize(mem, this);
                mem.Seek(0, SeekOrigin.Begin);
                Item r = (Item)Serializer.Deserialize(mem);
                r.filename = filename;
                r.Category = Category;
                r.Name = Name;
                return r;
            }
        }
    }
}
