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
            
        }
        static void InputNum(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
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
            if (Contain5And6(arr) == true)
                Console.WriteLine("Your Series Numbers have contains both 5 and 6");
            else
                Console.WriteLine("Your Series Numbers have NOT contains both 5 and 6");
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
    }
}
