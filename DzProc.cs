using System;

namespace DzProc
{
    class Program
    {
        static void proc16()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(sign(a) + sign(b));
        }
        static int sign(int x)
        {
            if (x < 0)
                return -1;
            else if (x > 0)
                return 1;
            else return 0;
        }
        static void proc17()
        {
            Console.WriteLine(RootsCount(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine(RootsCount(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine(RootsCount(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }

        static int RootsCount(int a, int b, int c)
        {
            int d = b * b - 4 * a * c;

            if (d > 0)
                return 2;
            else if (d == 0)
                return 1;
            else return 0;
        }
        
        static double CircleS(int r)
        {
            double S = 3.14 * r * r;
            return S;
        }
        static double RingS(int r1, int r2)
        {
            double s = CircleS(r1) - CircleS(r2);
            return s;
        }
        static double TriangleP(int a, int h)
        {
            double P = a + Math.Sqrt(h * h + a * a / 4);
            return P;
        }
        static double SumRange(int a, int b)
        {
            double res = 0;
            if (a > b)
                return 0;
            else
            {
                for (int i = a; i <= b; i++)
                    res += i;
                return res;
            }
        }
        static double calc(int a, int b, int op)
        {
            int res;
            switch (op)
            {
                case 1:
                    res = a - b;
                    break;
                case 2:
                    res = a * b;
                    break;
                case 3:
                    res = a / b;
                    break;
                default:
                    res = a + b;
                    break;
            }
            return res;
        }
        static int Quarter(int x, int y)
        {
            if (x > 0 && y > 0)
                return 1;
            else if (x > 0 && y < 0)
                return 2;
            else if (x < 0 && y < 0)
                return 3;
            else return 4;
        }
        static bool Even(int k)
        {
            if (k % 2 == 0)
                return true;
            else return false;
        }
        static void proc24()
        {
            int res=0;
            for (int i = 0; i < 10; i++)
                if(Even(int.Parse(Console.ReadLine())))
                    res++;
            Console.WriteLine(res);
        }
        static bool IsSquare(int k)
        {            
            bool res=false;
            for (int i = 1; i < Math.Sqrt(k); i++) 
            {
                res = i * i == k;
            }
            return res;
        }
        static void proc25()
        {
            int res = 0;
            for (int i = 0; i < 10; i++)
                if (IsSquare(int.Parse(Console.ReadLine())))
                    res++;
            Console.WriteLine(res);
        }
        static void Main(string[] args)
        {
            /*proc16();
            proc17();
            Console.WriteLine(CircleS(int.Parse(Console.ReadLine())));
            Console.WriteLine(RingS(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine(TriangleP(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine(SumRange(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine(calc(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine(Quarter(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            proc24();*/
            proc25();
        }   
    }
}
