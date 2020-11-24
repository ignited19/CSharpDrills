using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Drills
{
    public class LinkedListDrills
    {


        static LinkedList<string> LL = new LinkedList<string>();

        /*========================================================
         * Function: Finds duplicates nodes
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
         * Function: Populates the linkedlist of testing
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
        /*=================================================
        * Function: Returns kth to last node in a LL
        * SAP : 1st to last node P; 2nd to last is A, etc
        * ===============================================*/
        public static void KthToLastNode()
        {
            PopulateLinkedList();
            Console.WriteLine("Okay, which Kth to last node would you like me to acquire?");
            int UserKthInput = int.Parse(Console.ReadLine());
            int LengthOfLL = LL.Count;
            int Count = 0;


            if (UserKthInput > LengthOfLL)
            {
                Console.WriteLine("The kth input provided seems to be outside the scope of the LL length");
                return;
            }

            int KthNode = LengthOfLL - UserKthInput;

            Console.WriteLine("Alright, so you want node in index: " + KthNode);

            foreach(string Element in LL) { 
                if(Count == KthNode)
                {
                Console.WriteLine("Wait a sec... I think I found it: " + Element +"!");
                }

                Count++;

            }

            
            
        }

        /*========================================================
         * Function: View the LL
         * ======================================================*/
        public static void ViewLinkedList()
        {
            foreach (string Element in LL)
            {
                Console.WriteLine(Element);
            }
        }
    }
}
