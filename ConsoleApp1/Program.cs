using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello");
            //Console.WriteLine("Hello World!");
            //Console.Write("Your name?");

            //string name = Console.ReadLine();
            //Console.Write("Hi, ");
            //Console.Write(name);
            //Console.WriteLine (" sir!");

            //Console.Write("Age?");
            //var age = int.Parse(Console.ReadLine());
            //Console.Write("Your age is ");
            //Console.WriteLine(age);

            //Console.Write("Nick name char?");
            //char 별칭 = char.Parse(Console.ReadLine());
            //Console.WriteLine(별칭);

            Console.Write("Yes\n");
            string noes = @"c:\Docs\dfef";
            Console.WriteLine(noes);
            int x = 10;

            int x2 = x + 4 ;
            Console.WriteLine(x2);

            string a = "hello";
            string b = "h";

            b = b + "ello";
            Console.WriteLine(a == b);
            Console.WriteLine("b =" + b);

            string c = b + '!' + "" + x;
            Console.WriteLine("c = " + c);

            string myinf;
            myinf = string.Format("my h {0}, my w{1}", 165, 59);
            Console.WriteLine(myinf);

            int d1 = 11;
            double d2 = 1.234;
            Console.WriteLine(d1.ToString() +", "+ d2.ToString());

            Console.WriteLine($"d1 = {d1}, d2 = {d2}");

        }
    }
}
