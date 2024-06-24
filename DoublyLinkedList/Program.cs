using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create and display a Doubly Linked List.
            linkedlist <int> list = new linkedlist <int> ();
            Node<int> one = new Node<int>(1);
            //insert a node at the beginning of a Doubly Linked List.
            list.AddFirst(one);

            //insert a node at the end of a Doubly Linked List
            Node<int> tow = new Node<int>(2);
            list.AddEnd(tow);
            Node<int> three= new Node<int>(3);
            list.AddEnd(three);

            //insert a node at any position in a Doubly Linked List.
            Node<int> ten = new Node<int>(10);
            list.AddAfter(ten,one);

            //display a Doubly Linked List.
            list.Display();

            //display it in reverse order
            //list.Revers();

            //to get a node in an existing Doubly linked list.
            //list.GetNode(4);

            //removes the first element from a Doubly Linkedlist.
            //list.RemoveFirst();

            //removes the node from the Doubly linked list at the specified index.
            //list.RemovePosition(tow);

            //removes the tail element from a Doubly Linked list.
            //list.RemoveTail();

            //count the number of nodes or calculates the size of a Singly Linked list.
            //list.CountsElement();

            //find the first index that matches a given element.Return -1 for no matching.
            //list.machesFirst(ten);

            //check whether a Doubly linked list is empty or not. Return true otherwise false.
            //Console.WriteLine(list.CheckEmpty());

            //empty a singly linked list by pointing the head towards null.
            //list.EmptyLinkedlist();

            //check if an element is present in the Doubly Linked list.
            //list.Present(tow);

            //get the index of an element in a Doubly Linked list
            //list.GetIndex(3);

            //convert a Doubly Linked list into an array.
            //list.ConvertToArray();

            //convert a Doubly Linked list into a string.
            //list.ConvertToStr();
            list.Revers();
            list.Display();
            Console.ReadLine();
            
        }
    }
}
