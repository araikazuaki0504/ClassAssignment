﻿using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            uint Sum = 0, person_Num = 0, discount_Num = 0;

            Console.WriteLine("大人の人数を入力してください。");
            person_Num = uint.Parse(Console.ReadLine());
            discount_Num = person_Num / 2;
            Sum += 1500 * person_Num;

            Console.WriteLine("子供の人数を入力してください。");
            person_Num = uint.Parse(Console.ReadLine());
            Sum += 750 * (person_Num - discount_Num);

            Console.WriteLine("料金は\n" + Sum.ToString() + "\nなります。");

            Console.ReadLine();

        }
    }
}
