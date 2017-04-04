using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Node<T>
    {
        T value;
        Node<T> next;

        public Node(T value)
        {
            this.value = value;
        }
        
        public T Value { get => value; set => this.value = value; }
        public Node<T> Next { get => next; set => next = value; }
    }
}
