using System;

namespace Task_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lemon lemon = new Lemon("Vitamin-C");
            Pineapple lemonApple = new Pineapple("Vitamin-B");
            Apple apple = new Apple("Vitamin-A");

            Console.WriteLine("LemonList:");
            BasketList<Lemon> basketList = new BasketList<Lemon>();
            basketList.AddItem(lemon);
            foreach (var item in basketList.GetArray())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("PineappleList:");
                
            BasketList<Pineapple> basketList2 = new BasketList<Pineapple>();
            basketList2.AddItem(lemonApple);
            foreach (var item in basketList2.GetArray())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("AppleList:");
            BasketList<Apple> basketList3 = new BasketList<Apple>();
            basketList3.AddItem(apple);
            foreach(var item in basketList3.GetArray())
            {
                Console.WriteLine(item);
            }



        }
    }
}
