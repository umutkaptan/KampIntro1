using System;
using System.Collections.Generic;
using System.Text;

namespace Denemeasf
{
    class Champion
    {
        public Champion(string f,int e,int a)
        {
            Name = f;
            Health = e;
            Mana = a;
        }
        public Champion(string f, int e)
        {
            Name = f;
            Health = e;          
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
    }
}
