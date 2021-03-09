using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Drills
{
    public class Scenarios
    {
        /*===========================================================
         * Question: Swap the values of two variables without using
         * a temp variables
         * =========================================================*/
        public static void SwapValues(int a, int b)
        {
            string bitRep_a = Convert.ToString(a, 2);
            string bitRep_b = Convert.ToString(b, 2);

            Console.WriteLine($"Inital value (in bits) for {a} =  {bitRep_a} and {b} = {bitRep_b}");
            /*============================================================
             * The logic behind this. Let a = 2, and b = 4
             * a = 2 ^ 4 -> a = 6
             * b = 6 ^ 4 -> b = 2 (the value of a initially)
             * a = 6 ^ 4 -> a = 4 (the value of b initially)
             * =========================================================*/
            a = a ^ b;
            Console.WriteLine($"Current value for a = {Convert.ToString(a,2)}");
            b = a ^ b;
            Console.WriteLine($"Current value for b = {Convert.ToString(b, 2)} ");
            a = a ^ b;

            Console.WriteLine($"Swapped value for a = {a} and b = {b} ");

        }

        /*============================================================
         * Question: Given an INT, rotate the bits
         * ==========================================================*/
        public static void RotateBits()
        {
            int userInputInt;
            int positionsToRotate = 8;
            string userInputBit;
            
            
            Console.WriteLine("Hello, lets get started. Please provide me with an INT you would like to be shifted");
            userInputInt = int.Parse(Console.ReadLine());

            userInputBit = Convert.ToString(userInputInt, 2);

            Console.WriteLine(positionsToRotate >> 1 | positionsToRotate << 1);

        }

        /*============================================================
         * Question: Given an INT, return how many ones are in the
         * binary representation on that value
         * ==========================================================*/
        public static void IntToBinary()
        {
            Console.WriteLine("Lets Rock! Please enter in a INT");
            int UserInput = int.Parse(Console.ReadLine());
            string UserInput_Binary = Convert.ToString(UserInput, 2);
            int UserInput_Binar_Length = UserInput_Binary.Length;
            
            
            int NumberOfOnes = 0;

            for(int i = 0; i < UserInput_Binary.Length; i++)
            {
                if (UserInput_Binary[i] == '1')
                    NumberOfOnes++;
                Console.Write($"{UserInput_Binary[i]}");
            }

            Console.WriteLine($"\nNumber of ones in {UserInput} binary: {NumberOfOnes}");

            
        }

        /*============================================================
         * Question: Given input X, repesent the value using the least 
         * amount of coins.
         * NOTE: Using American coin system
         * ==========================================================*/
        public static void CoinCounter()
        {
            Console.WriteLine("Hello! Please enter an int value");
            int RawInput = int.Parse(Console.ReadLine());
            List<int> CoinDetails = new List<int>();
            int CurrentValue = RawInput;


            while(CurrentValue != 0)
            {
                if(CurrentValue>= 25)
                {
                    CurrentValue -= 25;
                    CoinDetails.Add(25);
             
                }

               else if(CurrentValue >= 10)
                {
                    CurrentValue -= 10;
                    CoinDetails.Add(10);

                }

                else if (CurrentValue >= 5)
                {
                    CurrentValue -= 5;
                    CoinDetails.Add(5);

                }

                else if (CurrentValue >= 1)
                {
                    CurrentValue -= 1;
                    CoinDetails.Add(1);

                }

            }
            Console.WriteLine("Alright! Let's see...carry the two, multiple by PI ....Okay, got it!! \n\nHere is the combination that uses the least amount of coins:");
            foreach(int Element in CoinDetails)
            {
                Console.WriteLine(Element);
            }

            Console.WriteLine($"The total amount of coins required: {CoinDetails.Count}");

          
        }
    }
}
