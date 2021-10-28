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
            
                string combinaison;
                Console.WriteLine("Entrez vos 4 nombre");
                combinaison = Console.ReadLine();
            }

            static void StringToArray(string combinaison, out int[] propo)
        propo = new int[4];
            for (int int n = 0; n <= 3; n++) ;
            propo[0] = combinaison[0];

            stringToArray(combinaison, out propo);
            Afficher(proposition);


            {
                int[] combi;
                int[] propo;
                Console.WriteLine("Encodez le nombre");
                combi = int.Parse(Console.ReadLine());

                mastermind(out combi);

                Console.WriteLine($"Le nombre est: {combi}");
                Console.ReadLine();
            /* petit commentaire */

            }
}
}
