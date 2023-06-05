using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_module2
{
    internal class Greens : LeafyVegetables
    {
        public Greens(string neme)
            : base(neme)
        {
            Name = neme;
            Random rnd = new Random();
            Calories = rnd.Next(10, 40);
        }
    }
}
