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
            if(n < 2)
            {
                return false;
            }
            else if (n == 2)
                return true;
            else if (n > 2)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                        return false;
                }
            }
            return true;
        }

        public static int Square(int n)
        { return n * n; }
                    
        public static int Cube(int n)
        { return n * n * n; }

        public static int Abs(int n)
        {
            return n;
        }

        public static int Ceil(double x)
        {
            if (x < 0)
            {
                return ((int)x / 1);
            }
            else
            {
                return (((int)x / 1) + 1);
            }
        }
        public static int Floor(double x)
        {
            if(x < 0)
                return (((int)x / 1) - 1);
            return (((int)x / 1));
        }

        public static int Pow(int x ,int y)
        {
            int p = 1;
                for(int i = 0 ; i < y ; i++)
                {
                    p *= x;
                }
            
            return p;
             
        }
        public static long Factorial(long n)
        {
            if (n == 1)
                return 1;
            return Factorial(n - 1) * n;
        }
        public static double Sin(int x)
        {
            double result = 0;
            for (int k = 0; k <= x ; k++)
            {
                result += (double)(Pow(-1, k)*Pow(x,2*k+1))/Factorial(2*k+1);
            }


            return result;
        }


    }
}
