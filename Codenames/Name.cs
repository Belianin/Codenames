using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codenames
{
    public class Name
    {
        public string Value { get; set; }
        public Trait[] Traits { get; set; }
    }

    public class Trait
    {
        public string Name { get; set; }
        public double Mark { get; set; }
    }
}
