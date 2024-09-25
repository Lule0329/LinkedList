using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class SimpleLinkedList<T>
    {
        public Node<T> First;
        public int count = 0;

        public void AddFirst(T data)
        {
            // skapa ett nytt Node-objekt och lägg in värdet data
            Node<T> newNode = new Node<T>();
            newNode.Value = data;

            // om det redan finns ett element (nod) inlagd, så
            // länka den nya noden till den gamla noden
            if (First != null)
            {
                newNode.Next = First;
            }

            // sätt listans första nod till att vara den nya noden
            First = newNode;

            count++;
        }

        public int Count()
        {
            return count;
        }

        public void Clear()
        {
            count = 0;
            First = null;
        }

        public T ElementAt(int index)
        {
            // skapa en variabel som börjar med första elementet
            Node<T> tempNod = First;
            int tempIndex = 0;

            // därefter loopar vi igenom alla elementen tills
            // dom tar slut (vi kommer till null)
            while (tempNod != null)
            {
                if(tempIndex == index)
                {
                    return tempNod.Value;
                }

                //Console.WriteLine(minNod.Value);
                tempNod = tempNod.Next;
                tempIndex++;
            }

            return tempNod.Value;
        }

        public void RemoveFirst()
        {
            
        }
    }
}
