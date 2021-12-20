using System;

namespace NLogProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Nlog nlog = new Nlog();
            int i = 1;
            while (true)
            {
                nlog.Trace("Loop number= " + i);
                Console.WriteLine("Enter value of a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value of b: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Math m = new Math();
                Console.WriteLine(m.DivideTwoNumbers(a,b));

                i++;
            }
        }
    }
}
