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
            int h = 15;
            
            I(h, 'i');
            Console.WriteLine();
            O1(h, 'O');
            Console.WriteLine();
            O2(h, 'O');
            Console.WriteLine();
            U(h, 'U');
            Console.WriteLine();
            V(h, 'V');
            Console.WriteLine();
            triangle(h, 'V');
            Console.WriteLine();
            W(h, 'W');
            Console.WriteLine();
            A1(h, 'A');
            Console.WriteLine();
            A2(5, 'A');
            X(12, 'X');
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
                DrawHorizontal(1, c); DrawHorizontal(h - 2, ' '); DrawHorizontal(1, c);
                Console.WriteLine();
            }
            DrawHorizontal(h, c);

        }
        static void V(int h, char c)
        {
            //first line
            DrawHorizontal(1, c); DrawHorizontal(2*h-3, ' '); DrawHorizontal(1, c);
            Console.WriteLine();
            int a = 1, b = 5;
            for (int i = 0; i < h - 2; i++)
            {
                DrawHorizontal(a, ' '); DrawHorizontal(1, c);
                DrawHorizontal(2*h - b, ' '); DrawHorizontal(1, c);
                Console.WriteLine();
                a = a + 1;
                b = b + 2;
            }
            //last line
            DrawHorizontal(h - 1, ' ');
            DrawHorizontal(1, c);
        }
        static void triangle(int h, char c)
        {
            //first line
            //h = 4, c = *;
            DrawHorizontal(2 * h - 1, c);
            Console.WriteLine();
            int a = 1, b = 1;
            for (int i = 0; i < h - 2; i++)
            {
                DrawHorizontal(b, ' '); DrawHorizontal(1, c);
                DrawHorizontal(h - a, ' '); DrawHorizontal(1, c);
                Console.WriteLine();
                b = b + 1;
                a = a + 2;
               
            }
            //last line
            DrawHorizontal(h - 1, ' ');
            DrawHorizontal(1, c);

        }
        static void W(int h, char c)
        {
            //first line
            DrawHorizontal(1, c); DrawHorizontal(2*h - 3, ' '); DrawHorizontal(1, c);
            DrawHorizontal(2*h - 3, ' '); DrawHorizontal(1, c);
            Console.WriteLine();
            int a = 5, b = 1, d = 1;
            for (int i = 0; i < h - 2; i++)
            {
                DrawHorizontal(b, ' '); DrawHorizontal(1, c); DrawHorizontal(2*h - a, ' '); DrawHorizontal(1, c);
                DrawHorizontal(d, ' '); DrawHorizontal(1, c); DrawHorizontal(2*h - a, ' '); DrawHorizontal(1, c);
                Console.WriteLine();
                a = a + 2;
                b = b + 1;
                d = d + 2;
            }
            //last line
            DrawHorizontal(h - 1, ' '); DrawHorizontal(1, c);
            DrawHorizontal(2*h - 3 , ' '); DrawHorizontal(1, c);
        }
        static void A1(int h , char c)
        {
            DrawHorizontal(h - 1, ' ');
            DrawHorizontal(1, c);
            Console.WriteLine();
            int a = 2, b = 1; 
            for (int i = 0; i < h - 2; i++)
            {
                DrawHorizontal(h - a, ' '); DrawHorizontal(1, c);
                DrawHorizontal(b, ' '); DrawHorizontal(1, c);
                Console.WriteLine();
                a = a + 1;
                b = b + 2;
            }

            DrawHorizontal(2 * h - 1, c);
        }
        static void A2(int h , char c)
        {
            DrawHorizontal(h, ' ');
            DrawHorizontal(1, c);
            Console.WriteLine();
            int a = 1, b = 1;
            for (int i = 0; i < h-1; i++)
            {
                if (i == 1)
                {
                    DrawHorizontal(h - a, ' '); DrawHorizontal(1, c);
                    DrawHorizontal(b, c); DrawHorizontal(1, c);
                    Console.WriteLine();
                }
                else
                {
                    DrawHorizontal(h - a, ' '); DrawHorizontal(1, c);
                    DrawHorizontal(b, ' '); DrawHorizontal(1, c);
                    Console.WriteLine();
                }
                a = a + 1;
                b = b + 2;
            }
        }
        static void X(int h , char c)
        {
            int a = 7 , d = 0;
            for (int i = 0; i < h-3; i++)
            {
                DrawHorizontal(d,' '); DrawHorizontal(1, c); 
                DrawHorizontal(2*h - a, ' '); DrawHorizontal(1, c);
                Console.WriteLine();

                a = a + 2;
                d = d + 1;
                
            }
            int b = 1 , e = 3;
            DrawHorizontal(h - e, ' '); DrawHorizontal(1, c);
            Console.WriteLine();
            for (int i = 0; i < h - 3; i++)
            {
                e = e + 1;
                DrawHorizontal(h - e, ' '); DrawHorizontal(1, c);
                DrawHorizontal(b, ' '); DrawHorizontal(1, c);
                Console.WriteLine();
                b = b + 2;
            }
        }
    }
}
