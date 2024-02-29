using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Zoo
{
    public class Animal
    {
        public    Animal(string name)
        {
            this.Name = name;
        }

        public virtual string Name { get; set; }
    }
}
