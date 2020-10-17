using System;

namespace dz3
{
    class Program
    {        
        static void series1(double[] arr)
        {
            double a = 0;
            for (int i = 0; i < arr.Length; i++)
                a += arr[i];
            Console.WriteLine(a);
        }
        static void series2(double[] arr)
        {
            double a = 1;
            foreach (double i in arr)
                a *= i;
            Console.WriteLine(a);
        }
        static void series3(double[] arr)
        {
            double a = 0;
            foreach (double i in arr)
                a += i;
            Console.WriteLine(a / arr.Length);
        }
        static void series4(double[] arr)
        {
            double a = 0;
            double b = 1;
            foreach (double i in arr)
            {
                a += i;
                b *= i;
            }
            Console.WriteLine($"{a} {b}");
        }
        static void series5(double[] arr)
        {
            double a = 0;
            foreach (double i in arr)
            {
                a += Math.Truncate(i);
                Console.Write($" {Math.Truncate(i)} ");
            }
            Console.WriteLine($"{a} ");
        }
        static void series6(double[] arr)
        {
            double a = 1;
            foreach (double i in arr)
            {
                a *= i - Math.Truncate(i);
                Console.Write($" {i - Math.Truncate(i)} ");
            }
            Console.WriteLine($"{a} ");
        }
        static void series7(double[] arr)
        {
            double a = 0;
            foreach (double i in arr)
            {
                a += Math.Round(i);
                Console.Write($" {Math.Round(i)} ");
            }
            Console.WriteLine($"{a} ");
        }
        static void series8(double[] arr)
        {
            double a = 0;
            foreach (double i in arr)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                    a++;
                }
            }
            Console.WriteLine($"{a} ");
        }
        static void series9(double[] arr)
        {
            double a = 0;
            double k = 0;
            foreach (double i in arr)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{k} ");
                    a++;
                }
                k++;
            }
            Console.WriteLine($"{a} ");
        }
        static bool series10(double[] arr)
        {
            double a = 0;
            foreach (double i in arr)
            {
                if (i % 2 == 0)
                {                    
                    a++;
                }
            }
            bool b = a != 0;
            return b;
        }
        static bool series11(double[] arr)
        {
            double a = 0;
            double k = 2.4;
            foreach (double i in arr)
            {
                if (i < k) 
                {
                    a++;
                }
            }
            bool b = a != 0;
            return b;
        }
        static void series12(double[] ar)
        {            
            int k = 0;
            while (ar[k] != 0)
                k++;
            Console.WriteLine(k+1);            
        }
        static void series13(double[] ar)
        {
            int k = 0;
            double a = 0;
            while (ar[k] != 0)
            {
                if (ar[k] > 0 && ar[k] % 2 == 0)
                    a += ar[k];
                k++;
            }
            Console.WriteLine(a);
        }
        static void series14(double[] ar)
        {
            int k = 0;
            double a = 0;
            double n = 2.7;
            while (ar[k] != 0)
            {
                if (ar[k] < n)
                    a++;
                k++;
            }
            Console.WriteLine(a);
        }
        static void series15(double[] ar)
        {
            int k = 0;            
            double n = 2.7;
            while (ar[k] != 0)
            {
                if (ar[k] > n)
                {
                    Console.WriteLine(k);
                    break;
                }                    
                k++;
            }
            if (ar[k] ==0)
            {
                Console.WriteLine(0);                
            }
        }
        static void series16(double[] ar)
        {
            int k = 0;
            double n = 2.7;
            double a = 0;
            while (ar[k] != 0)
            {
                if (ar[k] > n)
                {
                    a = k;
                }
                k++;
            }
            Console.WriteLine(a);            
        }
        static void series17()
        {
            double[] arr = { 1, 2, 3, 4, 5, 7, 9, 13 };
            double a = 0.5;
            double b = 8;
            foreach (double i in arr)
            {
                if (b<i && a!=b)
                {
                    a = b;
                    Console.Write($"{a} ");                    
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine($" ");
        }
        static void series18()
        {
            double[] arr = { 1, 2, 2, 3, 4, 5, 5, 5, 7, 9, 13, 13 };
            double a = 0.5;            
            foreach (double i in arr)
            {
                if (a!=i)
                {
                    Console.Write($"{i} ");
                    a = i;                    
                }                
            }
            Console.WriteLine($" ");
        }
        static void series19()
        {
            double[] arr = { 1, 6, 3, 8, 5, 9, 3, 8, 65, 4 };
            int k = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i]<arr[i-1])
                {
                    k++;
                    Console.Write($"{arr[i]} ");
                }
            }
            Console.WriteLine($"{k} ");
        }
        static void series20()
        {
            double[] arr = { 1, 6, 3, 8, 5, 9, 3, 8, 65, 4 };
            int k = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    k++;
                    Console.Write($"{arr[i]} ");
                }
            }
            Console.WriteLine($"{k} ");
        }
        static void series21()
        {
            double[] arr = { 1.5, 6, 3, -8.79, 5, 9, 3, 8, 65, 4 };
            int k = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    k++;                   
                }
            }
            bool b = k == arr.Length;
            Console.WriteLine($"{b} ");
        }
        static void series22()
        {
            double[] arr = { 8.5, 6, 3, -8.79, 5, 9, 3, 8, 65, 4 };
            double k=1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] <= arr[i + 1])
                {
                    k = arr[i];
                    break;
                }
                else
                    k = 0;
            }           
            Console.WriteLine($"{k} ");
        }
        static void series23()
        {
            double[] arr = { 8.5, 9, 3, -8.79, 5, 9, 3, 8, 65, 4 };
            double k = 1;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if ((arr[i] > arr[i + 1] && arr[i] > arr[i - 1]) ||(arr[i] < arr[i + 1] && arr[i] < arr[i - 1]))
                {
                    k = 0;                  
                }
                else
                {
                    k = arr[i];
                    break;
                }                    
            }
            Console.WriteLine($"{k} ");
        }
        static void series24()
        {
            double[] arr = { 1, 2, 3, 5, 0, 7, 0, 7, 8, 0, 8, 6, 0, 7, 0, 5 };
            double k = 0;
            for (int i = arr.Length - 1; i >=0;  i--)
            {
                if (arr[i]==0)
                {
                    i--;
                    while (arr[i] != 0)
                    {
                        k += arr[i];
                        i--;
                    }
                    break;
                }                
            }
            Console.WriteLine($"{k} ");
        }
        static void series26(double[] arr)
        {            
            double k = 3;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{Math.Pow(arr[i], k)} ");
            }
            Console.WriteLine($" ");
        }
        static void series28(double[] arr)
        {
            double k = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{Math.Pow(arr[i], k)} ");
                k--;
            }
            Console.WriteLine($" ");
        }
        static void series30()
        {
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            int k = int.Parse(Console.ReadLine());
            double res = 0;

            for (int j = 0; j < k; j++)
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++) 
                {
                    arr[i] = r.Next(-100, 100);
                    res+= arr[i];
                }
                Console.WriteLine(res);
            }
        }
        static void series32()
        {
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            int k = int.Parse(Console.ReadLine());
            int res = 0;

            for (int j = 0; j < k; j++)
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = r.Next(-100, 100);
                    if (arr[i] == 2)
                        res = i;                   
                }
                Console.WriteLine(res);
            }
        }
        static void series34()
        {
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            int k = int.Parse(Console.ReadLine());
            int res = 0;
            int check = 0;

            for (int j = 0; j < k; j++)
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = r.Next(-100, 100);
                    res += arr[i];
                    if (arr[i] == 2)
                    {
                        check =2;
                    }                      
                }
                if (check == 2)
                    Console.WriteLine(res);
                else
                    Console.WriteLine(0);
            }
        }
        static void series36()
        {
            int k = int.Parse(Console.ReadLine());
            int counter = k;
            for (int i = 0; i < k; i++)
            {
                int prev = int.Parse(Console.ReadLine());
                int val = int.Parse(Console.ReadLine());
                bool flag = true;
                do
                {
                    if (prev >= val)
                    {
                        if (flag) counter--;
                        flag = false;
                    }
                    prev = val;
                    val = int.Parse(Console.ReadLine());
                }
                while (val != 0);
            }
            Console.WriteLine(counter);
        }
        static void series38()
        {
            int k = int.Parse(Console.ReadLine());            
            for (int i = 0; i < k; i++)
            {
                int prev = int.Parse(Console.ReadLine());
                int val = int.Parse(Console.ReadLine());                
                int check = 2;
                do
                {
                    if (prev > val && check!=0)
                    {
                        if (check != 1)
                            check = -1;
                        else
                            check=0;
                    }
                    else if (prev < val && check!=0)
                        if (check != -1)
                            check = 1;
                        else
                            check = 0;
                    prev = val;
                    val = int.Parse(Console.ReadLine());
                }
                while (val != 0);
                Console.WriteLine(check);
            }
        }
        static void series40()
        {
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                int prev2 = int.Parse(Console.ReadLine());
                int prev1 = int.Parse(Console.ReadLine());
                int val = int.Parse(Console.ReadLine());
                int res = 2;
                do
                {
                    if ((prev1 > prev2 && prev1 > val && res!=0) || (prev1 < prev2 && prev1 < val && res != 0))
                    {
                        res++;
                    }
                    else
                        res = 0;
                    prev2 = prev1;
                    prev1 = val;
                    val = int.Parse(Console.ReadLine());
                }
                while (val != 0);
                Console.WriteLine(res);
            }
        }
        static void Main(string[] args)
        {
            double[] arr =  { 1.4, -4, 5.7, 6, 5, -7.6, 8, 4, 2.3, 5 };
            double[] ar = { 1, -4, 5, 6, 5, -7, 8, 4, 2, 5, 0 };
            series1(arr);
            series2(arr);
            series3(arr);
            series4(arr);
            series5(arr);
            series6(arr);
            series7(arr);
            series8(arr);
            series9(arr);
            Console.WriteLine(series10(arr));
            Console.WriteLine(series11(arr)); 
            series12(ar);
            series13(ar);
            series14(ar);
            series15(ar);
            series16(ar);
            series17();
            series18();
            series19();
            series20();
            series21();
            series22();
            series23();
            series24();
            series26(arr);
            series28(arr);            
            series30();            
            series32();            
            series34();            
            series36();            
            series38();            
            series40();
            
        }        
    }
}
