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



            // [34,21,34,98, 98] => [34,98]
            List<int> testList = new List<int> { 34, 21, 34, 98, 98 };
            List<int> dupList = Duplicates(testList);
            Console.WriteLine("Input List: " + String.Join(",", testList));
            Console.WriteLine("Output List: " + String.Join(",", dupList));

            // [apa,bpa,cpa,bpa] => [bpa]
            List<string> testList2 = new List<string> { "apa", "bpa", "cpa", "bpa" };
            List<string> dupList2 = Duplicates(testList2);
            Console.WriteLine("Input List 2: " + String.Join(",", testList2));
            Console.WriteLine("Output List 2: " + String.Join(",", dupList2));
        }

        public static List<T> Duplicates<T>(List<T> minLista)
        {
            List<T> result = new List<T>();

            // ett dictionary som håller koll på hur många ggr som någonting har hittats i 'minlista'
            Dictionary<T, int> occurrences = new Dictionary<T, int>();

            // kollar om grejen finns en gång
            foreach (T t in minLista)
            {
                if (occurrences.ContainsKey(t))
                {
                    occurrences[t]++;
                }
                else
                {
                    occurrences[t] = 1;
                }
            }

            // kollar om grejen finns mer än en gång
            foreach (var entry in occurrences)
            {
                if (entry.Value > 1 && !result.Contains(entry.Key))
                {
                    result.Add(entry.Key);
                }
            }

            return result;
        }
    }
}
