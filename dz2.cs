using System;

namespace dz2
{
    class dz2
    {
        static void case1()
        {
            int n = 5;
            switch (n)
            {
                case 1:
                    Console.WriteLine($"Monday");
                    break;
                case 2:
                    Console.WriteLine($"Tuesday");
                    break;
                case 3:
                    Console.WriteLine($"Wednesday");
                    break;
                case 4:
                    Console.WriteLine($"Thursday");
                    break;
                case 5:
                    Console.WriteLine($"Friday");
                    break;
                case 6:
                    Console.WriteLine($"Saturday");
                    break;
                case 7:
                    Console.WriteLine($"Sunday");
                    break;
            }
        }
        static void case18()
            {
                int n = 231;
                int a = n / 100;
                int c = n % 10;
                int b = (n % 100) / 10;
                string s;
                switch (a)
                {
                    case 1:
                        Console.Write($"Сто ");
                        break;
                    case 2:
                        Console.Write($"Двести ");
                        break;
                    case 3:
                        Console.Write($"Триста ");
                        break;
                    case 4:
                        Console.Write($"Четыриста ");
                        break;
                    case 5:
                        Console.Write($"Пятсот ");
                        break;
                    case 6:
                        Console.Write($"Шестсот ");
                        break;
                    case 7:
                        Console.Write($"Семсот ");
                        break;
                    case 8:
                        Console.Write($"Восемсот ");
                        break;
                    case 9:
                        Console.Write($"Деветсот ");
                        break;
                }
            switch (b)
            {
                case 1:
                    switch (c)
                    {
                        case 1:
                            Console.Write($"одинадцать");
                            break;
                        case 2:
                            Console.Write($"двенадцать");
                            break;
                        case 3:
                            Console.Write($"тринадцать");
                            break;
                        case 4:
                            Console.Write($"четырнадцать");
                            break;
                        case 5:
                            Console.Write($"пятнадцать");
                            break;
                        case 6:
                            Console.Write($"шестнадцать");
                            break;
                        case 7:
                            Console.Write($"семьнадцать");
                            break;
                        case 8:
                            Console.Write($"восемнадцать");
                            break;
                        case 9:
                            Console.Write($"девятнадцать");
                            break;
                    }
                    break;
                case 2:
                    Console.Write($"двадцать ");
                    break;
                case 3:
                    Console.Write($"тридцать ");
                    break;
                case 4:
                    Console.Write($"сорок ");
                    break;
                case 5:
                    Console.Write($"пятьдесят ");
                    break;
                case 6:
                    Console.Write($"шестьдеся ");
                    break;
                case 7:
                    Console.Write($"семьдесят ");
                    break;
                case 8:
                    Console.Write($"восемьдесят ");
                    break;
                case 9:
                    Console.Write($"девяносто ");
                    break;
            }

            if (b != 1)
            {
                switch (c)
                {
                    case 1:
                        s = "один";
                        Console.WriteLine(s);
                        break;
                    case 2:
                        s = "два";
                        Console.WriteLine(s);
                        break;
                    case 3:
                        s = "три";
                        Console.WriteLine(s);
                        break;
                    case 4:
                        s = "четыре";
                        Console.WriteLine(s);
                        break;
                    case 5:
                        s = "пять";
                        Console.WriteLine(s);
                        break;
                    case 6:
                        s = "шесть";
                        Console.WriteLine(s);
                        break;
                    case 7:
                        s = "семь";
                        Console.WriteLine(s);
                        break;
                    case 8:
                        s = "восемь";
                        Console.WriteLine(s);
                        break;
                    case 9:
                        s = "девять";
                        Console.WriteLine(s);
                        break;
                }                
            }   
                        
        }
        static void case20()
        {
            int m = 8;
            int d = 5;
            switch (m)
            {
                case 1:
                    if (d>=20)
                    Console.WriteLine($"Водолей");
                    else
                        Console.WriteLine($"Козерог");
                    break;
                case 2:
                    if (d >= 19)
                        Console.WriteLine($"Рыба");
                    else
                        Console.WriteLine($"Водолей");
                    break;                    
                case 3:
                    if (d >= 21)
                        Console.WriteLine($"Овен");
                    else
                        Console.WriteLine($"Рыба");
                    break;
                case 4:
                    if (d >= 20)
                        Console.WriteLine($"Телец");
                    else
                        Console.WriteLine($"Овен");
                    break;
                case 5:
                    if (d >= 21)
                        Console.WriteLine($"Близнецы");
                    else
                        Console.WriteLine($"Телец");
                    break;
                case 6:
                    if (d >= 22)
                        Console.WriteLine($"Рак");
                    else
                        Console.WriteLine($"Близнецы");
                    break;
                case 7:
                    if (d >= 23)
                        Console.WriteLine($"Лев");
                    else
                        Console.WriteLine($"Рак");
                    break;
                case 8:
                    if (d >= 23)
                        Console.WriteLine($"Дева");
                    else
                        Console.WriteLine($"Лев");
                    break;
                case 9:
                    if (d >= 23)
                        Console.WriteLine($"Весы");
                    else
                        Console.WriteLine($"Дева");
                    break;
                case 10:
                    if (d >= 23)
                        Console.WriteLine($"Скорпион");
                    else
                        Console.WriteLine($"Весы");
                    break;
                case 11:
                    if (d >= 23)
                        Console.WriteLine($"Стрелец");
                    else
                        Console.WriteLine($"Скорпион");
                    break;
                case 12:
                    if (d >= 22)
                        Console.WriteLine($"Козерог");
                    else
                        Console.WriteLine($"Стрелец");
                    break;
            }
        }
        static void for1()
        {
            int n = 4;
            int k = 5;
            for (int i=1; i <= n; i++)
                Console.WriteLine(k);
        }
        static void for4()
        {
            int n = 4;            
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(n*i);
        }
        static void for7()
        {
            int a = 4;
            int b = 6;
            int k = 0;
            for (int i = a; i <= b; i++)
                k+= i;
                Console.WriteLine(k);
        }
        static void for10()
        {
            double n = 3;            
            double k = 0;
            for (double i = 1; i <= n; i++)
                k =k+ 1/i;
            Console.WriteLine(k);
        }
        static void for13()
        {
            double n = 4;
            double k = 0;
            for (int i = 1; i <= n ; i +=2)
                k = k + 1 + i / Math.Pow(10, Math.Abs(i).ToString().Length);
            for (int i = 2; i <= n; i +=2)
                k = k - 1 - i / Math.Pow(10, Math.Abs(i).ToString().Length);
            Console.WriteLine(k);
        }
        static void for16()
        {
            double n = 3;
            double a = 2;
            for (double i = 1; i <= n; i++)
                Console.WriteLine(Math.Pow(a, i));
        }
        static void for19()
        {
            double n = 3;
            double a = 1;
            for (double i = 1; i <= n; i++)
                a *= i;
                Console.WriteLine(a);
        }
        static void for22()
        {
            double n = 2;
            double x = 2;
            double a = 1;
            double k = 1;
            for (double i = 1; i <= n; i++)
            {
                k *= i;
                a = a + Math.Pow(x, i) * k;
            }                
            Console.WriteLine(a);
        }
        static void for25()
        {
            double n = 5;
            double x = 0.2;
            double a = 0;            
            for (double i = 1; i <= n; i+=2)
            {
                a = a + Math.Pow(-1, i - 1) * Math.Pow(x, i) / i;
            }
            for (double i = 2; i <= n; i += 2)
            {
                a = a - Math.Pow(-1, i - 1) * Math.Pow(x, i) / i;
            }
            Console.WriteLine(a);
        }
        static void for28()
        {
            double n = 5;
            double x = 0.2;
            double a = 1;
            double k = 1;
            double b = 1;
            for (double i = 1; i <= n; i++)
            {
                k = k * (2 * i - 1);
                b = b * 2 * i;
                a = a + Math.Pow(x, i) * k * Math.Pow(-1, i - 1) / b;
            }
            Console.WriteLine(a);
        }
        static void for31()
        {
            double n = 2;            
            double a = 2;
            Console.WriteLine(a);
            for (double i = 2; i <= n; i++)
            {
                a = 2 + 1/a;
                Console.WriteLine(a);                
            }
           
        }
        static void for34()
        {
            double n = 4;
            double a = 1;
            double b = 2;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (double i = 3; i <= n; i++)
            {
                if (i % 2 != 0)
                { 
                    a = (a + 2 * b) / 3;
                    Console.WriteLine(a);
                }                   
                else
                { 
                    b = (b + 2 * a) / 3;
                    Console.WriteLine(b);
                }                   
            }
        }
        static void for37()
        {
            double n = 3;
            double a = 0;
            for (double i = 1; i <= n; i++)
                a = a + Math.Pow(i, i);
            Console.WriteLine(a);
        }
        static void for40()
        {
            int a = 4;
            int b = 6;
            int k = a-1;
            for (int i = 1; i <= b - a + 1; i++)
            {
                k++;
                for (int s = 1; s <= i; s++) 
                    Console.WriteLine(k);
            }
        }
        static void while1()
        {
            int a = 23;
            int b = 4;
            while (a - b > 0) 
            {
                a = a - b;
            }
            Console.WriteLine(a);
        }
        static void while4()
        {
            int a = 27;
            int b = 1;
            while (b < a) 
            {
                b *= 3;
            }
            bool n = a == b;
            Console.WriteLine(n);
        }
        static void while7()
        {
            int n = 27;
            int k = 0;
            while (k*k < n)
            {
                k++;
            }            
            Console.WriteLine(k);
        }
        static void while10()
        {
            int n = 26;
            int k = 0;
            while (Math.Pow(3,k) < n)
            {
                k++;
            }
            Console.WriteLine(k-1);
        }
        static void while13()
        {
            double a = 1.4;
            int k = 0;
            double s = 0;
            while (s<a)
            {               
                k++;
                s = s + 1 / k;                
            }
            Console.WriteLine($"{s} {k}");
        }
        static void while16()
        {
            int k = 1;
            int p = 30;
            int s = 10;
            while (s < 200)
            {
                k++;
                s = s + s*p/100;
            }
            Console.WriteLine($"{s} {k}");
        }
        static void while19()
        {
            int n = 14563;
            int k = Math.Abs(n).ToString().Length;            
            int a = 0;
            while (k>0)
            {
                a = a * 10 + (n % 10);
                k--;             
                n = n  / 10;
            }
            Console.WriteLine($" {a}");
        }
        static void while22()
        {
            int n = 2017;
            int d = 2;
            while (n % d != 0 ) 
            {
                d++;
            }
            bool a = d == n;
            Console.WriteLine($" {a}");
        }
        static void while25()
        {
            int n = 33;
            int a = 1;
            int b = 1;
            int d = 2;
            while (a < n && b < n) 
            {
                d++;
                if (d % 2 != 0)
                    a = a + b;
                else
                    b = a + b;
            }        
            if(a>b)
                Console.WriteLine($" {a}");
            else
                Console.WriteLine($" {b}");
        }
        static void while28()
        {
            double e = 0.1;
            double a = 2;
            int k = 2;
            while (Math.Abs(a - 2 - 1 / a) > e) 
            {
                k++;
                a = 2 + 1 / a;
            }
            
            Console.WriteLine($" {a} {k} {2+1/a}");
        }
        static void Main(string[] args)
        {
            case1();
            case18();
            case20();
            for1();
            for4();
            for7();
            for10();
            for13();
            for16();
            for19();
            for22();
            for25();
            for28();
            for31();
            for34();
            for37();
            for40();
            while1();
            while4();
            while7();
            while10();
            //while13();
            while16();
            while19();
            while22();
            while25();
            while28();
        }
    }
}
