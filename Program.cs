using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Get_user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, "+name);
            Console.WriteLine("how old are you?");
           int age = int.Parse(Console.ReadLine());
            Console.WriteLine(name+" your age is " + age);



        }
    }
}
