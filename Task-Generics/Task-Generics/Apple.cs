using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Generics
{
    internal class Apple
    {
        public string Vitamin;
        public Apple(string vitamin)
        {
            Vitamin = vitamin;


        }
        public override string ToString()
        {
            return $"Vitamin:{Vitamin}";
        }
    }
}
