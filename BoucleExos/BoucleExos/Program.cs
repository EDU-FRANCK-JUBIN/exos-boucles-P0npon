using System;
using System.Collections.Generic;
using System.Linq;

namespace exos_boucles
{
    class Program
    {
        static void Main(string[] args)
        {


            //Boucle For
            for (int i = 0; i < 21; i += 2)
            {
                Console.WriteLine("for "+i);
            }

            //Boucle While
            int compteur = 0;
            while (compteur < 21)
            {
                Console.WriteLine("while " + compteur);
                compteur += 2;
            }

            Console.WriteLine("Entrez le nombre dont vous souhaitez connaitre la somme des entiers inférieurs");
            string input = Console.ReadLine();
            try {
                int nbr = Int32.Parse(input);
                int total = 0;

                for (int i = nbr; i > 0; i--)
                {
                    total += i;
                }

                Console.WriteLine("La somme est de : " + total);
            }
            catch
            {
                Console.WriteLine("L'entrée ne correspond pas à un nombre");
            }
            List<int> nbrs = new List<int>();
            int nbr1;
            for(int i = 0;i<5;i++)
            {
                
                Console.WriteLine("Saisissez un nombre");
                nbr1 = Int32.Parse(Console.ReadLine());
                nbrs.Add(nbr1);
            }
            Console.WriteLine("La moyenne est de " + nbrs.Average());

            //Somme entier

            Console.WriteLine("Somme des entiers(1-10) : " + CalculSommeEntier(1, 10));
            Console.WriteLine("Somme des entiers(1-100) : " + CalculSommeEntier(1, 100));

            //Moyenne List
            List<float> testValues = new List<float> { 1f, 5.5f, 9.9f, 2.8f, 9.6f };
            Console.WriteLine("La moyenne  est de " + CalculMoyenne(testValues));

            //Multiple
            Console.WriteLine("Somme des multiple de 3 et 5 inférieur à 100 : " + SommeEntiersCommuns());


            Console.ReadLine();
        }

        public static int CalculSommeEntier(int x, int y)
        {
            int sum = 0;
            if (x > y)
            {
                return 0;
            }
            for (int i = x; i <= y; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static float CalculMoyenne(List<float> values)
        {
            float sum = 0;
            foreach (float value in values)
            {
                sum += value;
            }
            return sum / values.Count;
        }

        public static int SommeEntiersCommuns()
        {
            List<int> troisMult = new List<int>();
            List<int> cinqMult = new List<int>();
            for (int i = 0; i <=100; i++)
            {
                if(i%3==0)
                {
                    troisMult.Add(i);
                }
            }
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    cinqMult.Add(i);
                }
            }
            int sum = 0;
            foreach (int multiple in cinqMult)
            {
                if (troisMult.Contains(multiple))
                {
                    sum += multiple;
                }
            }

            return sum;
        }
    }
}
