using System;

namespace Linkied_List
{
    class Program
    {
        //Class for a single Node
        public class Node
        {
            public Node _next;
            public int _data;

            public Node()
            {
                _next = null;
                _data = 0;
            }
        }

        //Class for a Linked List of Nodes
        public class LinkedList
        {
            private Node _head;   //Pointer to first element

            public LinkedList()
            {
                _head = null;
            }

            //Print all the items of the Linked List
            public void printAllNodes()
            {
                Node current = _head;   //Get Pointer
                while (current != null)   //Are we at the end?
                {
                    Console.WriteLine(current._data);   //No, so print it
                    current = current._next;            //Get the next element
                }
            }

            //Add an item to the beginning of the list
            public void AddFirst(int item)
            {
                Node toAdd = new Node();   //Create the memory for the element

                toAdd._data = item;       //Fill in its data
                toAdd._next = _head;      //Point to the next element
                                          //(formerly the first element)
                _head = toAdd;            //head now points to the new element
            }

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Add First:");
            LinkedList myList1 = new LinkedList();  //Creates the head to the list;

            for (int i = 1; i <= 5; i++)
            {
                myList1.AddFirst(i);    //Add a member to list
            }
            myList1.printAllNodes();

            //Remove comments to test your AddLast() method
            //            LinkedList myList2 = new LinkedList();  //Creates the head to the 2nd list
            //            for (int i = 1; i <= 5; i++)
            //            {
            //                myList2.AddLast(i);    //Add a member to list
            //            }
            //            myList2.printAllNodes();

            //Remove comments to test your deleteNode() method
            //            for (int i = 1; i <= 10; i++)
            //            {
            //                myList3.AddLast(i);
            //            }
            //            myList3.printAllNodes();
            //            while (true)
            //            {
            //                Console.Write("Data to delete (0 to exit): ");
            //                temp = int.Parse(Console.ReadLine());
            //                if (temp == 0) break;
            //                myList3.deleteNode(temp);
            //                myList3.printAllNodes();
            //            }


            Console.WriteLine("Hit any key to exit");
            Console.ReadKey();

        }
    }
}
