using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_module2
{
    public abstract class Vegetables
    {
        public abstract string Name { get; set; }
        public abstract int Calories { get; protected set; }
    }
}
