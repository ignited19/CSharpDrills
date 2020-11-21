using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Drills
{
    public class LinkedListDrills
    {


        static LinkedList<string> LL = new LinkedList<string>();

        /*========================================================
         * Finds duplicates nodes
         *=======================================================*/
        public static void FindDuplicateNodes()
        {
            PopulateLinkedList();

            Console.WriteLine("Alright, searching for duplicates now");
            HashSet<string> StringHistory = new HashSet<string>();
            string ListOfRemovedItems = "";

            foreach(string Element in LL)
            {
                if (StringHistory.Contains(Element))
                {
                    ListOfRemovedItems += Element + ";";

                }
                else
                {
                    StringHistory.Add(Element);
                }
            }

            if (ListOfRemovedItems != "")
                Console.WriteLine(ListOfRemovedItems);

        }

        /*=================================================
         * Populates the linkedlist of testing
         * ===============================================*/
        public static void PopulateLinkedList()
        {
            Console.WriteLine("Please enter a string to place into a new node inside this Linked List \n");
            string CurrentChar = Console.ReadLine();
           
            while (CurrentChar != "")
            {

                LL.AddLast(CurrentChar);

                CurrentChar = Console.ReadLine();

            }

        }
        /*========================================================
         * View the LL
         * ======================================================*/
        private static void ViewLinkedList()
        {
            Console.WriteLine(LL.Count);
            foreach (string Element in LL)
            {
                Console.WriteLine(Element);
            }
        }
    }
}
