using System;

namespace Dictionary
{
    public class Node<T>
    {
        public int key;
        public T data;
        public int index;
        public Node<T> next;

        public Node(int key, T data, int index, Node<T> next)
        {
            this.key = key;
            this.data = data;
            this.index = index;
            this.next = next;
        }
    }
}
