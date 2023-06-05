﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_module2
{
    internal class LeafyVegetables : Vegetables
    {
        public LeafyVegetables(string neme)
        {
            Name = neme;
            Random rnd = new Random();
            Calories = rnd.Next(10, 200);
        }

        public override string Name { get; set; }
        public override int Calories { get; protected set; }

        public override int CompareTo(Vegetables? other)
        {
            if (other == null)
            {
                return 1;
            }

            if (Calories < other.Calories)
            {
                return -1;
            }

            if (Calories > other.Calories)
            {
                return 1;
            }

            return 0;
        }
    }
}
