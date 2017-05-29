using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTestingClass
{
    class Program
    {

       



        static void Main(string[] args)
        {
            // Hello my dear friends : Iwan , Kala and Slav
            // 



            Console.WriteLine();
            for (int i = 1;i<=100;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Hello");
                }

                else
                    Console.WriteLine("Iwan,Kala and Slav");

            }

            string exit = Console.ReadLine();


        }
    }
}
