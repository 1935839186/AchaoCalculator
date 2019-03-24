using System;namespace ConsoleApp1{    class Program    {
        // public int n;
        static void Main(string[] args)        {            int Shu()//产生1~100的随机数
            {                Random A = new Random();                int x = A.Next(1, 100);                return x;            }            char Fuhao()            {                char M = '0';                Random B = new Random();                int b = B.Next(1, 10);                if (b % 4 == 0)                    M = '+';                if (b % 4 == 1)                    M = '-';                if (b % 4 == 2)                    M = '/';                if (b % 4 == 3)                    M = '*';                return M;            }            int n = int.Parse(Console.ReadLine());            int i = 0;            for (i = 0; i < n; i++)            {                int a, b, c;                a = Shu();                b = Shu();                c = Shu();                char m = Fuhao();                char Q = Fuhao();                if (a % b == 0 && b % c == 0)                {                    Console.Write(a);                    Console.Write(m);                    Console.Write(b);                    Console.Write(Q);                    Console.Write(c);                    Console.WriteLine("=  ");                }                else                {                    n = n + 1;                    continue;                }





            }        }    }}
