using System;
using System.IO;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
        	
        	string insert=Console.ReadLine();
        	File.WriteAllText("news.txt",insert);
            // int i = Convert.ToInt32(Console.ReadLine());
            // switch (i)
            // {
            //     case 1: Console.WriteLine("month is january"); break;
            //     case 2: Console.WriteLine("month is july"); break;
            //     case 3: Console.WriteLine("month is june"); break;
            //     case 4: Console.WriteLine("month is may"); break;
            //     default: Console.WriteLine("enter number"); break;
            // }
            Console.ReadLine();
        } }
        }