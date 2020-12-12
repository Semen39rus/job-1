using System;

namespace job_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool x, y, z;
                Console.WriteLine("Введите x - true/false");
                x = bool.Parse(Console.ReadLine());
                Console.WriteLine("Введите y - true/false");
                y = bool.Parse(Console.ReadLine());
                Console.WriteLine("Введите z - true/false");
                z = bool.Parse(Console.ReadLine());
                bool r = !(!x && y) || (x && !z);
                Console.WriteLine("!(!x && y)||(x && !z)=");
                Console.WriteLine(r);
                bool r1 = !x;
                Console.WriteLine("!x=");
                Console.WriteLine(r1);
                bool r2 = !z;
                Console.WriteLine("!z=");
                Console.WriteLine(r2);
                bool r3 = (!x && y);
                Console.WriteLine("(!x && y)=");
                Console.WriteLine(r3);
                bool r4= !(!x && y);
                Console.WriteLine("!(!x && y)=");
                Console.WriteLine(r4);
                bool r5= (x && !z);
                Console.WriteLine("(x && !z)=");
                Console.WriteLine(r5); 

            }

                catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                Console.ReadKey();
        }
    }
}
