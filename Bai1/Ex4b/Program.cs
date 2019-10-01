using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numebers you want to input?");
            int n = Int32.Parse(Console.ReadLine());
            int[] SeriesNum =  new int[n];
            Console.WriteLine("Now input Series Numbers you want");
            InputNum(SeriesNum);
            Problem1b(SeriesNum);
            Problem1c(SeriesNum);
            Problem1d(SeriesNum);
            Problem1e(SeriesNum);
            Problem1f(SeriesNum);
            Problem1g(SeriesNum);
        }
        static void InputNum(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                //arr[i] = Int32.Parse(Console.ReadLine());
                arr[i] = rand.Next() % 100 - rand.Next() % 100;
            }
        }
        static void Problem1b(int[] arr)
        {
            if(Contain5(arr) == true)
                Console.WriteLine("Your Series Numbers have contains 5");
            else
                Console.WriteLine("Your Series Numbers have NOT contains 5");
        }
         static void Problem1c(int[] arr)
        {
            if (Contain5Or6(arr) == true)
                Console.WriteLine("Your Series Numbers have contains 5 or 6");
            else
                Console.WriteLine("Your Series Numbers have NOT contains 5 or 6");
        }
        static void Problem1d(int[] arr)
        {
            if (Contain5And6(arr) == true)
                Console.WriteLine("Your Series Numbers have contains both 5 and 6");
            else
                Console.WriteLine("Your Series Numbers have NOT contains both 5 and 6");
        }
        static void Problem1e(int[] arr)
        {
            Console.WriteLine("Your Series Number have {0} number 5",Count5(arr));
        }
        static void Problem1f(int[] arr)
        {
            Console.WriteLine("Your Series Number have {0} number 5 and {1} number 6",Count5(arr),Count6(arr));
        }
        static void Problem1g(int[] arr)
        {
            Console.WriteLine("the sum of all numbers is {0}",SumArr(arr));
        }
        static bool Contain5(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 5)
                {
                    return true;
                }
            }
            return false;
        }
        static bool Contain5And6(int[] arr)
        {
           int check1 = 0,check2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                    check1++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 6)
                    check2++;
            }
            if (check1 > 0 && check2 > 0)
                return true;
            return false;
        }
        static bool Contain5Or6(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5 || arr[i] == 6)
                    return true;
            }
            return false;
        }
        static int Count5(int[]arr)
        {
            int count =0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                    count++;
            }
            return count;
        }
        static int Count6(int[]arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 6)
                    count++;
            }
            return count;
        }
        static int SumArr(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
