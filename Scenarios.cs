﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Drills
{
    public class Scenarios
    {
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