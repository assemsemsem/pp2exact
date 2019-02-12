using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static bool isPrime(int n)
        {
            int cnt = 0;
            if (n == 1) // exception
                return false;
            else
                {
                    for (int i = 2; i < n; i++) //determinig a range from 2 to the number itself 
                    {
                        if (n % i == 0)
                            cnt++; // counter 
                    }
                }

                if (cnt < 1) // if number is not divisible to any number in a given range then it is prime
                    return true;
                else
                    return false;
            }

static void Main(string[] args)
        {

            FileStream fs = new FileStream(@"C:\Users\User\Desktop\pp2\array.txt", FileMode.Open, FileAccess.Read);
            StreamReader fd = new StreamReader(fs);
            string lines = fd.ReadLine();
            string[] line = lines.Split();
            int x;
            for (int i = 0; i < line.Length; i++)
            {
                x = int.Parse(line[i]);
                if (isPrime(x))
                    Console.WriteLine(line[i]);
            }
         }
    }
}
