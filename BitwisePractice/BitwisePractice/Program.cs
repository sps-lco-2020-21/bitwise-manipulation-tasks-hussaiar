using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BitwisePractice
{
    class Program
    {
        static void Main(string[] args)
        {


            Converting(31, 16);
            Console.ReadKey();

        }
        static void q19()
        {
            Console.WriteLine("enter input of bits and the rightmost bit will be returned to you");
            string bits = Console.ReadLine();
            Console.WriteLine(bits[bits.Count() - 1]);
;       }
        static void q20()
        {
            Console.WriteLine("enter input of bits and the 3 rightmost bits will be returned to you");
            string bits = Console.ReadLine();
            Console.WriteLine(bits.Substring(bits.Count()-3));
        }
        static void q21()
        {
            Console.WriteLine("enter input of bits and the leftmost bit will be returned to you");
            string bits = Console.ReadLine();
            Console.WriteLine(bits[0]);
        }

        static void q22()
        {
            Console.WriteLine("enter input of bits and the 3 leftmost bits will be returned to you");
            string bits = Console.ReadLine();
            Console.WriteLine(bits.Substring(bits.Count() - 3));
        }
        static void q23()
        {
            Console.WriteLine("enter input of bits and the rightmost will be removed");
            string bits = Console.ReadLine();
            string new_bits = bits.Substring(0, bits.Count() - 1);
            Console.WriteLine(new_bits);
        }
        static void q24()
        {
            Console.WriteLine("enter input of bits and the 3 rightmost bits will be removed");
            string bits = Console.ReadLine();
            string new_bits = bits.Substring(0, bits.Count() - 3);
            Console.WriteLine(new_bits);
        }
        static void q25()
        {
            Console.WriteLine("enter input of bits and the leftmost bit will be removed");
            string bits = Console.ReadLine();
            string new_bits = bits.Substring(1);
            Console.WriteLine(new_bits);
        }
        static void q26()
        {
            Console.WriteLine("enter input of bits and the 3 leftmost bits will be removed");
            string bits = Console.ReadLine();
            string new_bits = bits.Substring(3);
            Console.WriteLine(new_bits);
        }
        static void q27()
        {
            Console.WriteLine("enter input of bits");
            string bits = Console.ReadLine();
            string new_bits = bits.Substring(bits.Count() - 4);
            string final_bits = new_bits.Substring(0, new_bits.Count() - 1);
            Console.WriteLine(final_bits);    
        }
        static void q28()
        {
            Console.WriteLine("enter input of bits");
            string bits = Console.ReadLine();
            string new_bits = bits.Substring(1) + bits[0];
           
            Console.WriteLine(new_bits);
        }
        static void getbits(int x, int n, int p)
        {
           
            Console.WriteLine((x >> (p +1 - n)) & ~(~0 << n));    //had help from stack overflow.


        }

        static void countsetbits()
        {
            Console.WriteLine("enter integer");
            int number = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(number, 2);
            int counter = 0;
            foreach(char x in binary)
            {
                if (Convert.ToString(x)=="1")
                {
                    counter = counter + 1;
                }
            }
            Console.WriteLine(counter + " bit(s are 1s");
        }

        static void Converting(int n , int b)
        {
            double highest = Math.Log(n, b);
            Math.Floor(highest);
            double first_digit = Math.Floor(n / highest);
            double second_digit = Math.Floor((n - (first_digit * highest)) / (highest / b));
            Console.WriteLine(first_digit + " " + second_digit);
        }   // stuck on how to get the value of the digit correctly.
        
    }
}
