using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    public class MyCollection<T> : IEnumerable<T>
    {
        Node<T> head = default(Node<T>);

        public void Add(T value)
        {
            Node<T> node = new Node<T>(value);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
