using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Voice
{
    internal class Program
    {
        static string[] one = {"", "один ", "два ", "три ", "четыре ","пять ",
            "шесть ", "семь ", "восемь" ,"девять ","десять ","одинацать ",
            "двенадцать ", "тринадцать ", "четырнадцать ", "пятнадцать ", "шестнадцать ",
            "семнадцать ", "восемнадцать ", "девятнадцать "};

        static string[] ten = {"","","двадцать ", "тридцать ", "сорок ","пятьдесят ",
            "шестьдесят ", "семьдесят ", "восемьдесят ", "девяносто "};

        static string ToWords(int n,string w)
        {
            string str = "";

            if (n > 19)
            {
                str += ten[n / 10] + one[n % 10];
            }
            else
                str += one[n];

            if(n != 0)
            {
                str += w;
            }
            return str;
        }

        static string ConvertNumber(long n)
        {
            string output1 = "";

            output1 += ToWords((int)(n / 1000000), "миллион ");

            output1 += ToWords((int)((n / 100000) % 100), "сто тысяч ");

            output1 += ToWords((int)((n / 1000) % 100), "тысяч ");

            output1 += ToWords((int)((n / 100) % 10), "сот ");

            //if(n > 100 && n % 100 > 0)
            //{
            //    output1 += "и ";
            //}

            output1 += ToWords((int)(n % 100), " ");

            return output1;
        }

        static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(ConvertNumber(number));
        }
    }   
}








