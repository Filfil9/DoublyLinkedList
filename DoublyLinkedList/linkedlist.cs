using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    internal class linkedlist<T>
    {
        private Node<T> Head = null;
        private Node<T> Tail = null;
        //insert a node at the beginning of a Doubly Linked List.
        public void AddFirst(Node<T> newnode)
        {
            if (Head == null)
            {
                Head = newnode;
                Tail = newnode;
            }
            else
            {
                newnode.Next = Head;
                Head = newnode;
            }
        }
        //insert a node at the end of a Doubly Linked List
        public void AddEnd(Node<T> newnode)
        {
            if (Tail == null)
            {
                Tail = newnode;
            }
            else
            {
                Tail.Next = newnode;
                Tail = newnode;
            }
        }
        //insert a node at any position in a Doubly Linked List.
        public void AddAfter(Node<T> newnode, Node<T> position)
        {
            Node<T> current = Head;
            while (current != position)
            {
                current.Previos = current;
                current = current.Next;
            }
            newnode.Next = current.Next;
            current.Next = newnode;
        }
        //display a Doubly Linked List.
        public void Display()
        {
            Node<T> current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current.Previos = current;
                current = current.Next;
            }
            Console.WriteLine();
        }
        //display it in reverse order
        public void Revers()
        {
            Node<T> current = Head;
            Node<T> Temp = null;
            while (current != null)
            {
                Temp = current.Previos; 
                current.Previos = current.Next; 
                current.Next = Temp;
                current = current.Previos;
            }
            Head = Temp.Previos;
        }
        //to get a node in an existing Doubly linked list.
        public void GetNode(T item)
        {
            Node<T> current = Head;
            while (current != null && !current.Data.Equals(item))
            {
                current = current.Next;
            }
            Console.WriteLine(current.Data);
        }
        //removes the first element from a Doubly Linkedlist.
        public void RemoveFirst()
        {
            if (Head == Tail)
            {
                Console.WriteLine("the linked list is empty");
            }
            else
            {
                Head = Head.Next;
            }
        }
        //removes the node from the Doubly linked list at the specified index.
        public void RemovePosition(Node<T> RemovePosition)
        {
            if (Head == RemovePosition)
            {
                Head = Head.Next;
            }
            else
            {
                Node<T> current = Head;
                Node<T> previous = null;
                while (current != null && current != RemovePosition)
                {
                    previous = current;
                    current = current.Next;
                }
                previous.Next = current.Next;
                current = previous.Next;
            }
        }
        //removes the tail element from a Doubly Linked list.
        public void RemoveTail()
        {
            Node<T> current = Head;
            Node<T> previous = null;
            while (current != Tail)
            {
                previous = current;
                current = current.Next;
            }
            current = previous;
            Tail = current;
            current.Next = null;
        }
        //count the number of nodes or calculates the size of a Singly Linked list.
        public void CountsElement()
        {
            int count = 0;
            Node<T> currentNode = Head;
            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.Next;
            }
            Console.WriteLine(count);
        }
        //find the first index that matches a given element.Return -1 for no matching.
        public void machesFirst(Node<int> element)
        {
            if (Head.Data.Equals(element.Data))
            {
                Console.WriteLine(element.Data);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
        //check whether a Doubly linked list is empty or not. Return true otherwise false.
        public bool CheckEmpty()
        {
         if (Head == null)
           { 
            return true; 
           }
         return false;
        }
        //empty a singly linked list by pointing the head towards null.
        public void EmptyLinkedlist()
        {
            while (Head != null)
            {
                Head = Head.Next;
            }
            Tail=Head;
        }
        //check if an element is present in the Doubly Linked list.
        public bool Present(Node<T> data)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Data.Equals(data.Data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        //get the index of an element in a Doubly Linked list
        public void GetIndex(T element)
        {
            int index = 0;
            Node<T> currentNode = Head;
            while (!currentNode.Data.Equals(element))
            {
                index++;
                currentNode = currentNode.Next;
            }
            Console.WriteLine($"the index of {element} is {index}");
        }
        //convert a Doubly Linked list into an array.
        public T[] ConvertToArray()
        {
            int count = 0;
            Node<T> currentNode = Head;
            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.Next;
            }
            // Create an array of the appropriate size.
            T[] Array = new T[count];
            int index = 0;
            // Copy data from each node to the array
            while (currentNode != null)
            {
                currentNode.Data = Array[index];
                currentNode = currentNode.Next;
                index++;
            }
            return Array;
        }
        //convert a Doubly Linked list into a string.
        public void ConvertToStr()
        {
            Node<T> currentNode = Head;
            while (currentNode != null)
            {
                Console.Write(currentNode.Data.ToString() + " ");
                currentNode = currentNode.Next;
            }
        }

    }
}

