using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            // skapa en ny länkad lista som innehåller string
            SimpleLinkedList<string> minLista = new SimpleLinkedList<string>();

            // lägg in värden i listan, lägg in "sista först"
            minLista.AddFirst("Carl");
            minLista.AddFirst("Bertil");
            minLista.AddFirst("Anna");

            // skapa en variabel som börjar med första elementet
            Node<string> minNod = minLista.First;

            // därefter loopar vi igenom alla elementen tills
            // dom tar slut (vi kommer till null)
            while (minNod != null)
            {
                Console.WriteLine(minNod.Value);
                minNod = minNod.Next;
            }

            Console.WriteLine("Count: " + minLista.Count());
            
            //minLista.Clear();
            //Console.WriteLine("Count: " + minLista.Count());

            Console.WriteLine(minLista.ElementAt(2));

            minLista.RemoveFirst(); 
            Console.WriteLine(minLista.First.Value);
        }
    }
}
