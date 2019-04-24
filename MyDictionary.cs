using System;
using System.Collections.Generic;

namespace Dictionary
{
    public class MyDictionary<T>
    {
        T data;
        int maxSize;
        private Node<T>[] vals;

        public MyDictionary(){
            maxSize = 5;
            vals = new Node<T>[maxSize];
        }

        public void set (int key, T value){
            int i = hash(key);
            Node<T> newNode;

            if (vals[i] != null) {
                Console.WriteLine("\nCollision Occured!!!");
                // check if node exists
                Node<T> firstNode = vals[i];
                Node<T> n = firstNode;
                while (n.next != null)
                {
                    // replace if same id is set.
                    if (n.key.Equals(key) && n.key.GetHashCode().Equals(key.GetHashCode()))
                    {
                        n.data = value;
                        Details d = (Details)(object)value;
                        Console.WriteLine("\nStudent Id already available, is replaced with new data");
                        Console.WriteLine("\nName: {0}, Student Id: {1}, GPA: {2}, Major: {3}, Email: {4}",
                                        d.name, d.id, d.gpa, d.major, d.major, d.email);
                        Console.WriteLine("\nCollision Resolved!!!");
                        return;
                    }
                    n = n.next;
                }
                // add new node.
                Node<T> existingNode = firstNode;
                newNode = new Node<T>(key, value, i, existingNode);
                vals[i] = newNode;
                Details nNode = (Details)(object)newNode.data;
                Console.WriteLine("\nName: {0}, Student Id: {1}, GPA: {2}, Major: {3}, Email: {4}",
                                nNode.name, nNode.id, nNode.gpa, nNode.major, nNode.major, nNode.email);
                Console.WriteLine("\nCollision Resolved!!!");
            }
            // no collision
            else {
                Console.WriteLine("\nNo Collision!!!");
                newNode = new Node<T>(key, value, i, default(Node<T>));
                vals[i] = newNode;
                Details nNode = (Details)(object)newNode.data;
                Console.WriteLine("\nName: {0}, Student Id: {1}, GPA: {2}, Major: {3}, Email: {4}",
                                nNode.name, nNode.id, nNode.gpa, nNode.major, nNode.major, nNode.email);
                Console.WriteLine("\nData added!!!");
            }
            
        }

        private int hash(int key)
        {
            int hash = key.GetHashCode();
            return Math.Abs(hash % maxSize);
        }

        public T get(int key){
            int i = hash(key);
            // collision occured
            if (vals[i] != null){
                Node<T> firstNode = vals[i];
                Node<T> n = firstNode;
                while (n.next != null) {
                    if (n.key.Equals(key) && n.key.GetHashCode().Equals(key.GetHashCode())){
                        Details nNode = (Details)(object)n.data;
                        Console.WriteLine("\nName: {0}, Student Id: {1}, GPA: {2}, Major: {3}, Email: {4}",
                                nNode.name, nNode.id, nNode.gpa, nNode.major, nNode.major, nNode.email);
                        return n.data;
                    }
                    n = n.next;
                }
                Console.WriteLine("\nData not available!!!");
                return default(T);
            }
            // no collision
            else {
                Console.WriteLine("\nData not available!!!");
                return default(T);
            }
        }

    }
}
