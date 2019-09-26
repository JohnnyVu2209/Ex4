using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
        }

        public static bool IsOdd(int n)
        {
            if (n % 2 != 0)
                return true;
            else
                return false;
           
        }
        public static bool IsEven(int n)
        {
            if (n % 2 == 0) return true;
            else return false;
               

        }
        public static bool Prime(int n)
        {
            bool result = true;
            if (n < 2)
            {
                return false;
            }
            if (n < 0)
            {


                for (int i = 2; i <= n; i++)
                {
                    int flag = 1;
                    if (n % i == 0)
                    {
                        flag++;
                    }
                    if (flag == 2)
                    {
                        return result;
                    }
                }
               
            }
            return result;
        }
    }
}
