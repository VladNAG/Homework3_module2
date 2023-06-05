using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_module2
{
    public abstract class Vegetables : IComparable<Vegetables>
    {
        public abstract string Name { get; set; }
        public abstract int Calories { get; protected set; }

        public abstract int CompareTo(Vegetables? other);
    }
}
