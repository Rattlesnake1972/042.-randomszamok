using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042.randomszamok
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(random.Next(0, 100));
            }

            //int num = random.Next(1, 7);     // 1-től 7-ig egész számokat generál

            //double num = random.NextDouble();   //tizedes törteket generál

            //Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
