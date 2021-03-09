using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Drills
{
    public class Scenarios
    {
        /*============================================================
         * Given an INT, rotate the bits
         * 8 in binary = 0000100
         * 8 << 2 = 00100000
         * 
         * 32-1
         * ==========================================================*/
        public static void RotateBits()
        {
            int userInputInt;
            int positionsToRotate = 8;
            string userInputBit;
            
            
            Console.WriteLine("Hello, lets get started. Please provide me with an INT you would like to be shifted");
            userInputInt = int.Parse(Console.ReadLine());

            userInputBit = Convert.ToString(userInputInt, 2);

            Console.WriteLine(8 >> 1 | 8<<1);



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
