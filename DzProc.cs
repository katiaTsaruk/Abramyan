using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

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
            {
                if(Even(int.Parse(Console.ReadLine())))
                    res++;
            }
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
            {
                if (IsSquare(int.Parse(Console.ReadLine())))
                    res++;
            }
            Console.WriteLine(res);
        }
        static bool IsPower5(int k)
        {
            bool res = true;
            for (int i = 1; i <= Math.Log10(k) / Math.Log10(5); i++) 
            {
                if( k == Math.Pow(5, i))
                    res = true;
                else res = false;

            }
            return res;
        }
        static void proc26()
        {
            int res = 0;
            for (int i = 0; i < 10; i++)
            { 
                if (IsPower5(int.Parse(Console.ReadLine())))
                    res++;
            }
               
            Console.WriteLine(res);
        }
        static bool IsPowerN(int k, int n)
        {
            bool res = true;
            for (int i = 1; i <= Math.Log10(k) / Math.Log10(n); i++)
            {
                if (k == Math.Pow(n, i))
                    res = true;
                else res = false;

            }
            return res;
        }
        static bool IsPrime(int n)
        {
            bool res = false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n > 1 && n % i != 0)
                    res = true;
                else res = false;
            }
            return res;
        }
        static int DigitCount(int k)
        {
            int res = 0;
            while (k >= 1) 
            {
                k = k / 10;
                res++;
            }
            return res;
        }
        static int DigitN(int k, int n)
        {
            int res;
            if (DigitCount(k) >= n)
            {
                for (int i = 1; i < n; i++)
                {
                    k = k / 10;
                }
                res = k % 10;
            }
            else 
                res = -1;
            return res;
        }
        static bool IsPalindrom(int k)
        {
            bool res = true;
            int digitAmount = DigitCount(k);
            for (int i = 1; i <= DigitCount(k) / 2; i++) 
            {
                if (DigitN(k, i) != DigitN(k, digitAmount))
                {
                    res = false;
                    break;
                }
                digitAmount--;
            }
            return res;
        }
        static double DegToRad(double deg)
        {
            double rad = deg/ 180 * 3.14;
            return rad;
        }
        static double RadToDeg(double rad)
        {
            double deg = rad * 180 / 3.14;
            return deg;
        }
        static double Fact(int n)
        {
            double res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }
        static double Fact2(int n)
        {
            double res = 1;
            if (n % 2 == 0) 
            {
                for (int i = 2; i <= n; i+=2)
                {
                    res *= i;
                }            
            }
            else
            {
                for (int i = 1; i <= n; i += 2)
                {
                    res *= i;
                }
            }
            return res;
        }
        static int Fib(int n)
        {
            int prev = 1;
            int prevprev = 1;
            int res = 1;
            if (n > 2) 
            {
                for(int i=3;i<=n;i++)
                {
                    res = prev + prevprev;
                    prevprev = prev;
                    prev = res;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            proc16();
            proc17();
            Console.WriteLine(CircleS(int.Parse(Console.ReadLine())));
            Console.WriteLine(RingS(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine(TriangleP(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine(SumRange(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine(calc(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine(Quarter(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            proc24();
            proc25();
            proc26();
            Console.WriteLine(IsPower5(int.Parse(Console.ReadLine())));
            Console.WriteLine(IsPowerN(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine(IsPrime(int.Parse(Console.ReadLine())));
            Console.WriteLine(DigitCount(int.Parse(Console.ReadLine())));
            Console.WriteLine(DigitN(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine(IsPalindrom(int.Parse(Console.ReadLine())));
            Console.WriteLine(DegToRad(int.Parse(Console.ReadLine())));
            Console.WriteLine(RadToDeg(int.Parse(Console.ReadLine())));
            Console.WriteLine(Fact(int.Parse(Console.ReadLine())));
            Console.WriteLine(Fact2(int.Parse(Console.ReadLine())));
            Console.WriteLine(Fib(int.Parse(Console.ReadLine())));
        }   
    }
}
