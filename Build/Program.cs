using System;
using System.Collections.Generic;

namespace FibNumbers
{
    class Program
    {
        static int FibSum(ref List<int> MyFib)
        {
            int sumFib;
            sumFib = 0;
            foreach (int fib in MyFib)
            {
                if(fib % 2 == 0)
                {
                    sumFib += fib;
                }
            }
            return sumFib;
        }
        static void FibCreator(ref List<int> MyFib)
        {
            MyFib.Add(1);
            MyFib.Add(2);

            int NewFibNumber;

            bool maxNumberFib = false;
            do
            {
                MyFib.Sort();
                NewFibNumber = 0;
                NewFibNumber = ((MyFib[MyFib.Count-1])+ MyFib[MyFib.Count - 2]);
                if (NewFibNumber < 4000000)
                {
                    if (!MyFib.Contains(NewFibNumber))
                    {
                        MyFib.Add(NewFibNumber);
                    }
                }
                else
                {
                    maxNumberFib = true;
                }
            } while (maxNumberFib == false);
        }
        static void Main(string[] args)
        {
            List<int> FibNumbers = new List<int>();
            
            FibCreator(ref FibNumbers);

            Console.WriteLine(FibSum(ref FibNumbers));
        }
    }
}
