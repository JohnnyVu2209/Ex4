using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4b2
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 4;
            char c = 'W';
            //U(h, c);
            //V(h, c);
            //triangle(h, c);
            W(h, c);
        }
        static void I(int h, char c)
        {
            for (int i = 0; i < h; i++)
            {
                Console.Write("\n{0}", c);

            }



        }
        static void DrawHorizontal(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}", c);

            }


        }
        static void O1(int h, char c)
        {
            for (int i = 0; i < h; i++)
            {
                DrawHorizontal(h, c);
                Console.WriteLine();
            }
        }
        static void O2(int h, char c)
        {
            DrawHorizontal(h, c);
            Console.WriteLine();
            for (int i = 0; i < h - 2; i++)
            {
                DrawHorizontal(1, c); DrawHorizontal(h - 2, ' '); DrawHorizontal(1, c);
                Console.WriteLine();
            }
            DrawHorizontal(h, c);
        }
        static void U(int h, char c)
        {
            for (int i = 0; i < h - 1; i++)
            {
                DrawHorizontal(1, c); DrawHorizontal(h - 1, ' '); DrawHorizontal(1, c);
                Console.WriteLine();
            }
            DrawHorizontal(h, c);

        }
        static void V(int h, char c)
        {
            //first line
            DrawHorizontal(1, c); DrawHorizontal(h + 1, ' '); DrawHorizontal(1, c);
            Console.WriteLine();
            int a = 1, b = 1;
            for (int i = 0; i < h - 2; i++)
            {
                DrawHorizontal(b, ' '); DrawHorizontal(1, c);
                DrawHorizontal(h - a, ' '); DrawHorizontal(1, c);
                Console.WriteLine();
                a = a + 2;
                b = b + 1;
            }
            //last line
            DrawHorizontal(h - 1, ' ');
            DrawHorizontal(1, c);
        }
        static void triangle(int h, char c)
        {
            //first line
            DrawHorizontal(2 * h - 1, c);
            Console.WriteLine();
            int a = 1, b = 1;
            for (int i = 0; i < h - 2; i++)
            {
                DrawHorizontal(b, ' '); DrawHorizontal(1, c);
                DrawHorizontal(h - a, ' '); DrawHorizontal(1, c);
                Console.WriteLine();
                a = a + 2;
                b = b + 1;
            }
            //last line
            DrawHorizontal(h - 1, ' ');
            DrawHorizontal(1, c);

        }
        static void W(int h ,char c)
        {
            //first line
            DrawHorizontal(1, c); DrawHorizontal(h + 1, ' '); DrawHorizontal(1, c);
            DrawHorizontal(h + 1, ' '); DrawHorizontal(1, c);
            Console.WriteLine();
            int a = 1, b = 1,d = 3;
            for (int i = 0; i < h - 2; i++)
            {
                DrawHorizontal(b, ' '); DrawHorizontal(1, c);DrawHorizontal(h - a, ' '); DrawHorizontal(1, c);
                DrawHorizontal(h-d, ' '); DrawHorizontal(1, c); DrawHorizontal(h - a, ' '); DrawHorizontal(1, c);
                Console.WriteLine();
                a = a + 2;
                b = b + 1;
                d = d - 2;
            }
            //last line
            DrawHorizontal(h - 1, ' ');DrawHorizontal(1, c);
            DrawHorizontal(h + 1, ' '); DrawHorizontal(1, c);
        }
    }
}
