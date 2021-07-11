using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Animal
    {
        public bool Teeth { get; set; }
        public bool Eyes { get; set; }
        public bool Ears { get; set; }
        public bool Parents { get; set; }
    }

    class Birds : Animal
    {
        public bool Wings { get; set; }
        public bool beak { get; set; }
        public bool layEggs { get; set; }
        public bool hasFeather { get; set; }
    }

    class Reptiles : Animal
    {
        public bool hasScales { get; set; }
        public bool isColdBlooded { get; set; }
        public bool hasVertebrates { get; set; }
        public bool haveAtLeastOneLung { get; set; }
    }
}
