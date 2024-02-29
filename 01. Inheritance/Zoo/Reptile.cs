using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Zoo
{
    public class Reptile : Animal

    {
        public Reptile(string name) : base(name)
        {
            Name = name;
        }

        public override string Name { get; set; }
    }
}
