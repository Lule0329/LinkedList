using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        public Node<T> Next;
        public T Value;

        public override string ToString()
        {
            if (Value != null)
            {
                return Value.ToString();
            }
            else
            {
                return "NULL";
            }
        }
    }
}
