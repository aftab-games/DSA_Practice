using System;
using System.ComponentModel;

namespace DsaPractice
{
    internal class LinkedList
    {
        private class Node
        {
            internal int value;
            internal Node next;
        }

        Node first;
        Node last;

        //Print method linked list all items
        
        public void AddLast(int item)
        {
            var node = new Node();
            node.value = item;
            if(IsEmpty()) first = last = node;
            else
            {
                last.next = node;
                last = node;
            }
        }

        public void AddFirst(int item)
        {
            var node = new Node();
            node.value = item;
            if(IsEmpty()) first = last = node;
            else
            {
                node.next = first;
                first = node;
            }
        }

        public int IndexOf(int item)
        {
            int index = 0;
            var current = first;
            while( current != null )
            {
                if (current.value == item) return index;
                current = current.next;
                index++;
            }
            return -1;
        }

        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }

        public void RemoveFirst()
        {
            if (IsEmpty()) throw new Exception("The list is empty!");
            if(first == last)
            {
                first = last = null;
                return;
            }
            first = first.next; //Need to test this
        }
        
        public void RemoveLast()
        {
            if (IsEmpty()) throw new Exception("The list is empty!");
            if (first == last)
            {
                first = last = null;
                return;
            }
            var previous = GetPrevious(last);
            last = previous;
            last.next = null;
        }

        Node GetPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == node) return current;
                current = current.next;
            }
            return null;
        }

        bool IsEmpty()
        {
            return first == null;
        }
    }
}
