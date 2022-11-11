using System;

namespace singly_linked_list
{
    //each mode consist of the information part and link to the next mode

    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }

    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        public void addNote()
        {
            int nim;
            string nm;
            Console.Write("\n Enter the roll number of student : ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the name of the student : ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = nim;
            newnode.name = nm;

            //if the node to be inserted is the first node
            if ((START == null) && (nim <= START.rollNumber))
            {
                if ((START == null) && (nim == START.rollNumber)) ;
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }

            Node previous, current;
            previous = START;
            current = START;
            while ((current != null) && (nim >= current.rollNumber))
            {
                if (nim == current.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }
                previous = current;
                current = current.next;
            }

            /*once the above for loop is executed, prev and current are positioned in such a
              way that the position for the new node */
            newnode = current;
            previous.next = newnode;
        }

    }
}