using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    class Program
    {
        static void mastermind(out int[] combi)
        {
            Random rnd = new Random();
            
            for (int n = 0; n < 3; n++)
            {
                int nombre = rnd.Next(1, 6);
                combi[n] = nombre;
            }
                
            
        }



        static void Main(string[] args)
        {
            int[] combi;

            Console.WriteLine("Encodez le nombre");
            combi = int.Parse(Console.ReadLine());

            mastermind(out combi);

            Console.WriteLine($"Le nombre est: {combi}");
            Console.ReadLine();



        }
    }
}
