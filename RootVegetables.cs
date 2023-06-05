using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_module2
{
    internal class RootVegetables : Vegetables
    {
        public RootVegetables(string neme)
        {
            Name = neme;
            Random rnd = new Random();
            Calories = rnd.Next(100, 400);
        }

        public override string Name { get; set; }
        public override int Calories { get; protected set; }
    }
}
