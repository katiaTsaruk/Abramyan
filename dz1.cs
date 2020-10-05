using System;

namespace dz1
{
    class Program
    {
        static void int3()
        {
            int n = 5000;
            int a = n / 1024;
            Console.WriteLine(a);
        }
        static void int6()
        {
            int n = 54;
            int a = n / 10;
            int b = n % 10;
            Console.WriteLine($"{a} {b}");
        }
        static void int9()
        {
            int n = 534;
            int a = n / 100;            
            Console.WriteLine($"{a}");
        }
        static void int12()
        {
            int n = 378;
            int a = n / 100;
            int k = n / 10;
            int b = k % 10;
            int c = n % 10;
            Console.WriteLine($"{c}{b}{a}");
        }
        static void int15()
        {
            int n = 378;
            int a = n / 100;
            int k = n / 10;
            int b = k % 10;
            int c = n % 10;
            Console.WriteLine($"{b}{a}{c}");
        }
        static void int18()
        {
            int n = 23378;
            int a = n / 1000;
            int b = a % 10;
            Console.WriteLine($"{b}");
        }
        static void int21()
        {
            int n = 378;
            int c = n % 60;
            Console.WriteLine($"{c}");
        }
        static void int24()
        {
            int n = 125;
            int c = n % 7;
            Console.WriteLine($"{c}");
        }
        static void int27()
        {
            int n = 2;
            int c = (n +4)% 7+1;
            Console.WriteLine($"{c}");
        }
        static void int30()
        {
            int n = 2456;
            int c = (n -1) % 100;
            Console.WriteLine($"{c}");
        }


        static bool bool3()
        {
            int n = 44;
            int a = n % 2;
            bool b=a==0;
            return b;
        }
        static bool bool6()
        {
            int a = 12;
            int b = 45;
            int c = 13;
            bool n = a < b && b < c;
            return n;
        }
        static bool bool9()
        {
            int a = 12;
            int b = 31;
            bool n = a % 2 == 1 || b % 2 == 1;
            return n;
        }
        static bool bool12()
        {
            double a = 12;
            double b = 31;
            double c = -16;
            bool n = a > 0 && b > 0 && c > 0;
            return n;
        }
        static bool bool15()
        {
            double a = 12;
            double b = 31;
            double c = -16;
            bool n = (a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0);
            return n;
        }
        static bool bool18()
        {
            double a = 12;
            double b = 31;
            double c = -16;
            bool n = a==b || b==c || c==a;
            return n;
        }
        static bool bool21()
        {
            int n = 378;
            int a = n / 100;
            int k = n / 10;
            int b = k % 10;
            int c = n % 10;
            bool f = a < b && b < c;
            return f;
        }
        static bool bool24()
        {
            double a = 3;
            double b = -20;
            double c = -23;
            double d = b * b - 4 * a * c;
            bool n = d >= 0;
            return n;
        }
        static bool bool27()
        {
            int x = 378;
            int y = 23;
            bool f = y<0;
            return f;
        }
        static bool bool30()
        {
            double a = 12;
            double b = 31;
            double c = 16;
            bool n = a == b && b == c ;
            return n;
        }
        static bool bool33()
        {
            double a = 12;
            double b = 31;
            double c = 16;
            bool n = a + c > b && b + a > c && b + c > a;
            return n;
        }
        static bool bool36()
        {
            double x1 = 5;
            double y1 = 3;
            double x2 = 1;
            double y2 = 4;
            bool n = x1 == x2 || y1 == y2;
            return n;
        }
        static bool bool39()
        {
            double x1 = 5;
            double y1 = 3;
            double x2 = 1;
            double y2 = 4;
            bool n = x1 == x2 || y1 == y2 || Math.Abs(x1-x2)== Math.Abs(y1 - y2);
            return n;
        }


        static void if3()
        {
            double a =0;
            if (a > 0)
            {
                a = a + 1;
            }
            else if (a < 0)
            {
                a = a - 2;
            }
            else
                a = 10;
            Console.WriteLine(a);
        }
        static void if6()
        {
            double a = 0;
            double b = 4;
            if (a > b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);            
        }
        static void if9()
        {
            double a = 0;
            double b = 4;
            double n;
            if (a > b)
            {
                n = a;
                a = b;
                b = n;

            }            
        Console.WriteLine($"{a}, {b}");            
        }
        static void if12()
        {
            double a = 0;
            double b = 4;
            double c = -12;
            if (a > b && b>c)
            Console.WriteLine(c);
            else if(a < b && b < c)
                Console.WriteLine(c);
            else
                Console.WriteLine(b);
        }
        static void if15()
        {
            double a = 0;
            double b = 4;
            double c = -12;
            if (a > b && b > c)
                Console.WriteLine(a+b);
            else if (a < b && b < c)
                Console.WriteLine(b+c);
            else
                Console.WriteLine(a+c);
        }
        static void if18()
        {
            int[] array = { 12, 4, 4 };
            if (array[0]== array[1])
                Console.WriteLine(3);
            else if (array[0] == array[2])
                Console.WriteLine(2);
            else
                Console.WriteLine(1);
        }
        static void if21()
        {
            double x = 5;
            double y = -37;
            if (x==y && x==0)
                Console.WriteLine(0);
            else if (x==0)
                Console.WriteLine(2);
            else if(y==0)
                Console.WriteLine(1);
            else
                Console.WriteLine(3);
        }
        static void if24()
        {
            double x = 5;            
            if (x>0)
                Console.WriteLine(2*Math.Sin(x));            
            else
                Console.WriteLine(6-x);
        }
        static void if27()
        {
            double x = 5;
            if (x < 0)
                Console.WriteLine(0);
            else if (Math.Truncate(x)% 2 == 0) 
                Console.WriteLine(1);
            else 
                Console.WriteLine(-1);
        }
        static void if30()
        {
            int x = 45;            
            if (x % 2 != 0)
                Console.Write($"Нечетное"); 
            else 
                Console.Write($"Четное"); 
            if (x / 10 == 0)
                Console.Write($" однозначное");
            else if (x / 10 != 0 && x / 100 == 0)
                Console.Write($" двузначное");
            else
                Console.Write($" трехзначное");
            Console.Write($" число");
        }

        static void Main(string[] args)
        {
            int3();
            int6();
            int9();
            int12();
            int15();
            int18();
            int21();
            int24();
            int27();
            int30();
            Console.WriteLine(bool3());
            Console.WriteLine(bool6());
            Console.WriteLine(bool9());
            Console.WriteLine(bool12());
            Console.WriteLine(bool15());
            Console.WriteLine(bool18());
            Console.WriteLine(bool21());
            Console.WriteLine(bool24());
            Console.WriteLine(bool27());
            Console.WriteLine(bool30());
            Console.WriteLine(bool33());
            Console.WriteLine(bool36());
            Console.WriteLine(bool39());
            if3();
            if6();
            if9();
            if12();
            if15();
            if18();
            if21();
            if24();
            if27();
            if30();
        }
    }
}
