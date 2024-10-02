using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class BetterLinkedList<T> : SimpleLinkedList<T>
    {
        public Node<T> Last;

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

        T GetFirst() // return first element of the list
        {
            return First.Value;
        }  
        
        T RemoveFirst() // return first element of list and remove it
        {
            T temp = First.Value;
            First = null;
            return temp;
        }

        void AddLast(T elem) // add new element at the end of list
        {
            // skapa ett nytt Node-objekt och lägg in värdet data
            Node<T> newNode = new Node<T>();
            newNode.Value = elem;

            // Om listan är tom
            if (First == null)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                // Om listan inte är tom, lägg till den nya noden i slutet
                Last.Next = newNode;
                Last = newNode; // Uppdatera Last till den nya noden
            }

            count++;
        } 

        T GetLast() // return last element of the list
        {
            return Last.Value;
        } 

        T RemoveLast() // return last element of list and remove it
        {
            T temp = Last.Value;
            Last = null;
            return temp;
        } 

        void AddAt(int index, T elem) // add new element at specified ind
        {
            Node<T> tempNod = First;
            int tempIndex = 0;

            while (tempNod != null)
            {
                if (tempIndex == index)
                {
                    tempNod.Value = elem;
                }

                //Console.WriteLine(minNod.Value);
                tempNod = tempNod.Next;
                tempIndex++;
            }
        }

        T ElementAt(int i) // return element at specified index
        {
            // skapa en variabel som börjar med första elementet
            Node<T> tempNod = First;
            int tempIndex = 0;

            // därefter loopar vi igenom alla elementen tills
            // dom tar slut (vi kommer till null)
            while (tempNod != null)
            {
                if (tempIndex == i)
                {
                    return tempNod.Value;
                }

                //Console.WriteLine(minNod.Value);
                tempNod = tempNod.Next;
                tempIndex++;
            }

            return tempNod.Value;
        } 

        T RemoveAt(int index) // return element at specified index and remove it
        {
            // skapa en variabel som börjar med första elementet
            Node<T> tempNod = First;
            int tempIndex = 0;

            // därefter loopar vi igenom alla elementen tills
            // dom tar slut (vi kommer till null)
            while (tempNod != null)
            {
                if (tempIndex == index)
                {
                    return tempNod.Value; 
                }

                //Console.WriteLine(minNod.Value);
                tempNod = tempNod.Next;
                tempIndex++;
            }

            return tempNod.Value;
        }

        int Count() // return the number of elements in the list
        {
            return count;
        }   
                
        void Clear() // remove all elements in the list
        {
            First = null;
        }   

        List<T> ToList() // transform into a List. order is maintained.
        {

        } 
    }
}
