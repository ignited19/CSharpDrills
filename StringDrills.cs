using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Drills
{
    class StringDrills
    {
        
        
        /*================================================
         * Function: To check if a string contains all
         * unique characters
         * ===============================================*/
        public static void AllUniqueCharacters()
        {
            /*Checks to see if user would like to continue testing strings*/
            int ContinueTesting = 1;
            /*Character Tracker will determine if string a contains unique characters*/
            bool[] CharacterTracker = new bool[126];

            /*This while loop allow's the user to continue testing strings until they are done*/
            while (ContinueTesting == 1)
            {

                /*Acquire string from user. Save a raw version */
                Console.WriteLine("This module tests if a string contains all unqiue characters: Please enter a string you would like to check");
                string RawUserInput = Console.ReadLine();
                string TestString = RawUserInput.ToLower();
                bool StringContainsAllUniqueChar = true;

                /*Place holder variables for function*/
                bool CurrentValue;
                int CurrentValueArrPosition;

                /*Iterate through string a and check/populate CharacterTracker*/
                foreach (char Element in TestString)
                {
                    CurrentValueArrPosition = (int)Element;
                    CurrentValue = (bool)CharacterTracker.GetValue(CurrentValueArrPosition);


                    if (CurrentValue == true)
                    {
                        Console.WriteLine("I am so sorry, but the string \"" + RawUserInput + "\" " + "contains duplicate " + Element + "\'s");
                        StringContainsAllUniqueChar = false;
                    }



                    CharacterTracker.SetValue(true, CurrentValueArrPosition);

                }

                if (StringContainsAllUniqueChar == true)
                    Console.WriteLine("Congrats!!!! \"" + RawUserInput + "\", contains all unqiue characters");

                Console.WriteLine("Continue testing strings? 1 = yes, 0 = no");

                



                //ViewContentsOfAnArray(CharacterTracker);

            }
        }

        /*================================================
         * Function: To check if a two strings are a 
         * permutation of each other
         * ===============================================*/
        public static void PermutationCheck()
        {

            int ContinueTesting = 1;


            /* Incorperate a while loop so user can continue testing until they are done*/
            while (ContinueTesting == 1)
            {

                /*acquire the two strings that are going to be checked from the user*/
                bool IsPermutation = true;

                Console.WriteLine("Alright, lets do this! Please enter in the first string to check");
                string a = Console.ReadLine();
                Console.WriteLine("Great! Now please enter in the second string to check");
                string b = Console.ReadLine();


                /*Check to see if both string a and b have the same length, if not they cannot be permutations*/
                if (a.Length != b.Length)
                {
                    Console.WriteLine("I am so sorry! String a has a length of: " + a.Length + " and string b has a length" +
                        "of " + b.Length + ". They cannot be permutations");
                    return;
                }


                /*Create character arrays for both string a & b so we can use orderby to sort them*/
                char[] CharArr_StrA = a.ToLower().ToCharArray();
                char[] CharArr_StrB = b.ToLower().ToCharArray();

                /*sort both CharArr so we can easily spot the differences */
                Array.Sort(CharArr_StrA);
                Array.Sort(CharArr_StrB);

                /*Check for differences between the two character arrays*/
                for (int i = 0; i < CharArr_StrA.Length; i++)
                {
                    if (CharArr_StrA[i] != CharArr_StrB[i])
                    {
                        IsPermutation = false;
                    }
                }

                /*Display the the test scenario clearly to user and results. Also helps with debugging*/
                Console.WriteLine("Is \"" + a + "\" a permuation of \"" + b + "\": "+ IsPermutation.ToString()+ "\n\r");
                
                
                Console.WriteLine("Continue testing strings? 1 = yes, 0 = no");
                ContinueTesting = Convert.ToInt32(Console.ReadLine());
            }
        }

        /*================================================
         * Function: To check if a two strings are a 
         * permutation of each other
         * ===============================================*/
        public static void PalindromePermutationCheck()
        {
            /*==================================================
             * We first need to capture the length of the string. 
             * The length will determine how many odd character 
             * counts will be allowed for the string to be 
             * considered a permutation 
            =====================================================*/
            Console.WriteLine("Hey!! Give me a string to check to see if it can be a palindrome");
            string UserInput_A = Console.ReadLine();
            char [] CharArray_A = UserInput_A.ToLower().ToCharArray();
            int OddCount = 0;

            /*Store the individual character count in the a Char Array*/
            int[] CharacterCount_A = new int[126];

            foreach(char Element in CharArray_A)
            {
                CharacterCount_A[Element]++;
            }

            /*======================================================
             * If the intial string length is even, then each 
             * character within the string should have an equal
             * representation count. If the string's length is odd, 
             * then there should only be one character that has a 
             * representation count of 1
             ======================================================*/
            foreach (int Element in CharacterCount_A)
            {
                if (Element % 2 != 0)
                    OddCount = OddCount+1;
            }

            if (UserInput_A.Length % 2 == 0 && OddCount == 0 ||
                UserInput_A.Length % 2 != 0 && OddCount == 1
                )
            {
                Console.WriteLine(UserInput_A + " can be a palindrome");
            }else
            {
                Console.WriteLine(UserInput_A + " cannot be a palindrome");
            }
        }
        /*===========================================================
         * This function is used to tell if the differences between
         * these two strings are equal or less than one. So
         * the 3 fundamental modifications you can make to a string
         * is replacing characters, removing characters and adding 
         * characters. So lets start!
         * ========================================================*/
        public static void CheckStringDiff (string a, string b)
        {
            bool Result;
            if(a.Length == b.Length)
            {
                Result = ReplacementCheck(a, b);
            } 
            /* If a.length-1 is equal to b.length, then we know that A contains more chars*/
            else if(a.Length - 1 ! == b.Length)
            {
                Result = InsertCheck(a, b);
            }
            /* If a.length-1 is equal to b.length, then we know that A contains less chars*/
            else if (a.Length + 1  == b.Length)
            {
                Result = InsertCheck(a, b);
            }
            else
            {
                Result = false;
            }

            Console.WriteLine("Magic computer, tell us if these two strings contain no more than one difference: " + Result);







            /* Embedded method to check and see if a replacement is
             * nesscary to make the strings identical*/
            static bool ReplacementCheck(string a, string b)
            {
                int NumberOfDifferences = 0;
                char[] StringArr_A = a.ToCharArray();
                char[] StringArr_B = b.ToCharArray();

                /*Iterate through the char arrays to pinpoint differnces*/
                for (int i = 0; i < a.Length; i++)
                {
                   if(StringArr_A[i] != StringArr_B[i])
                    {
                        NumberOfDifferences += 1;
                    }

                    
                        
                }

                return (NumberOfDifferences <= 1);
            }

            static bool InsertCheck(string a, string b)
            {
                int Index_A = 0;
                int Index_B = 0;
                int NumberOfDifferences = 0;
                int UpperLimit_A = a.Length;
                int UpperLimit_B = b.Length;

                while(Index_A < a.Length && Index_B < b.Length)
                {
                   if(a[Index_A] != b[Index_B])
                    {
                        NumberOfDifferences += 1;
                        Index_A += 1;
                    }
                    else
                    {
                        Index_A += 1;
                        Index_B += 1;
                    }

                    

                    return (NumberOfDifferences <= 1);
                }
                return true;
            }
        }
            


        public static void ViewContentsOfAnArray(bool[] Arr)
        {
            foreach (bool Element in Arr)
            {
                Console.WriteLine(Element);
            }

        }

        public static void ViewContentsOfAnArray(char[] Arr)
        {
            foreach (char Element in Arr)
            {
                Console.WriteLine(Element);
            }

        }

        public static void ViewContentsOfAnArray(int[] Arr)
        {
            foreach (int Element in Arr)
            {
                Console.WriteLine(Element);
            }

        }
    }
}
