using System;

namespace prime
{
    class Program
    {
        static bool prime(int a) //функция, которая определяет простоту числа
        {
            if (a == 1) return false;//число 1 не простое
            for (int i = 2; i <= Math.Sqrt(a); ++i)
            {
                if (a % i == 0) return false;//если число делится без остатка на определенное число в промежутке от 2 до корня нашего числа, мы можем утверждать что оно составное
            }
            return true;//иначе оно простое
        }
        public static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; ++i)
            {
                if (prime(int.Parse(args[i]))) Console.WriteLine(args[i]);//проверяем, является ли число простым и при верности данного утверждения выводим наше число
            }
        }
    }
}

