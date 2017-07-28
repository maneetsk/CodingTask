using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coding_Task.Helpers
{
    public class NumberFunctions
    {
        public static void generateAllNumbersInLoop(int num, ref List<int> allnumbers, ref List<int> allevennumbers, ref List<int> alloddnumbers, ref List<string> allconditionalnumbers)
        {
            for (int i = 0; i <= num; i++)
            {
                allnumbers.Add(i); // Get all numbers

                if (i % 2 == 0)
                    allevennumbers.Add(i); // Get all even numbers
                else
                    alloddnumbers.Add(i); // Get all odd numbers

                if (i % 15 == 0)
                    allconditionalnumbers.Add("Z"); // Number is divisible by 3 and 5
                else if (i % 5 == 0)
                    allconditionalnumbers.Add("E"); // Number is divisible by 5
                else if (i % 3 == 0)
                    allconditionalnumbers.Add("C"); // Number is divisible by 3 
                else
                    allconditionalnumbers.Add(i.ToString()); // Number is not divisible by 3 or 5
            }
        }

        public static void generateFibonacci(int num, ref List<int> allfibonaccinumbers)
        {
            if (num == 0)
                allfibonaccinumbers.Add(0);
            else if (num == 1)
            {
                allfibonaccinumbers.Add(0);
                allfibonaccinumbers.Add(1);
            }
            else
            {
                allfibonaccinumbers.Add(0);
                allfibonaccinumbers.Add(1);
                while (allfibonaccinumbers[allfibonaccinumbers.Count - 1] + allfibonaccinumbers[allfibonaccinumbers.Count - 2] <= num)
                {
                    allfibonaccinumbers.Add(allfibonaccinumbers[allfibonaccinumbers.Count - 1] + allfibonaccinumbers[allfibonaccinumbers.Count - 2]);
                }
            }
        }
    }
}