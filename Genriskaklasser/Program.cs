using System.Security.AccessControl;
using System;
using System.Collections.Generic;


namespace Genriskaklasser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creature<string> c = new Creature<string>();
            // Creature<int> c2 = new Creature<int>();
            // //instans<Typen av T> c3 = new Creature<Typen av T>();

            // c.category = "6";
            // c2.category = 6;
            
            Queue<String> orders = new Queue<string>();

            orders.Enqueue("walk");
            orders.Enqueue("stand");
            orders.Enqueue("patrol");

            string order = orders.Dequeue();
            
            Console.WriteLine(orders);
            
            Console.ReadLine();

        }
    }
}
