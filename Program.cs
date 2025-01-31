using System;
using System.Net.Mail;

namespace String
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string a = "DDDDDARTI";
            string b = "TI";

            Console.WriteLine(a); Console.WriteLine(b);
            
            Console.WriteLine(a.Concat(b));
            Console.WriteLine(a.Contains(b));
            Console.WriteLine(a.IndexOf('A'));
            Console.WriteLine(a.Insert(3,"OOOOOO"));
        }
    }
    
