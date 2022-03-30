using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Generics
{
    internal class Lemon
    {
        public string Vitamin;
        public Lemon(string vitamin)
        {
            Vitamin = vitamin;


        }
        public override string ToString()
        {
            return $"Vitamin:{Vitamin}";
        }
    }
}
