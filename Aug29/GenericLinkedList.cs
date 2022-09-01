using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug29
{
    class GenericsLinkedList<T>
    {
        class LinkedlistNode
        {
            private LinkedlistNode next; //pointer/reference
            private T item;

            public LinkedlistNode(T t)
            {
                next = null;
                item = t;
            }
            public LinkedlistNode Next
            {
                get  {  return next;  }
                set  {  next = value; }
            }
            public T Item
            {
                get  {  return item;  }
                set  {  item = value; }
            }
        }
        private LinkedlistNode head;
        public GenericsLinkedList()
        {
            head = null;
        }
        public void AddHead(T t)
        {
            LinkedlistNode node = new LinkedlistNode(t);
            node.Next = head;
            head = node;
        }
        public IEnumerator<T> GetEnumerator()
        {
            LinkedlistNode current = head;
            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }

        }

    }
}
