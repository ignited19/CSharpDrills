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
            /*Set up LL for testing*/
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
        /*=================================================
        * Function: Delete the middle node
        * ===============================================*/
        public static void DeleteMiddleNode()
        {
            /*Set up LL for testing*/
            PopulateLinkedList();

            LinkedListNode<string> Node_Current = LL.First;
            LinkedListNode<string> Node_Runner = LL.First;



            while(Node_Current != null)
            {
                if(Node_Current.Next != null)
                    Node_Current = Node_Current.Next;
                
                if(Node_Current.Next.Next != null)
                    Node_Runner = Node_Current.Next.Next;

                //Console.WriteLine($"The values of the current node and runner: {Node_Current}, {Node_Runner}");
            }

        
        }

        /*=====================================================
        * Function: Divide a LL in the middle returning the start
        * of the later half of the LL.
        * ===================================================*/
        public static LinkedListNode<string> DivideLL()
        {

            /*Set up LL for testing*/
            PopulateLinkedList();

            LinkedListNode<string> Node_Slow = LL.First;
            LinkedListNode<string> Node_Runner = LL.First;
            

            while (Node_Runner.Next != null)
            {
                
                Node_Runner = Node_Runner.Next.Next;
                Node_Slow = Node_Slow.Next;

                if (Node_Runner == null)
                    break;
            }

            Console.WriteLine($"Slow: {Node_Slow.Value}");
            
            Console.ReadKey();
            return Node_Slow;

          

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
