using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// pour acceder il faut ajouter la classe public 
//le nom complet de la fonction que nous voulons importer dans le fichier Program.cs
//est passWordGenerator.outils.AskingNumber

namespace passWordGeneratorOutils
{
    static class outils
    {
        public static int AskingNumber(string question)
        {
            int number = 0;
            while (true)
            {
                Console.Write(question);
                string input = Console.ReadLine();
                try
                {
                    number = Convert.ToInt32(input);

                    if (number <= 0)
                    {
                        Console.WriteLine("Merci de renseigner un chiffre plus grand que 0");
                        Console.WriteLine();
                    }
                    else
                    {
                        return number;
                    }
                }
                catch
                {
                    Console.WriteLine("Entre un nombre valide");  
                    Console.WriteLine();
                }
            }

            //si je mets while(number <=0) dans ce cas je mets return number ici ;
            //mais true dans le while et je mets le return number dans le else puisque c'est la seule condition qui me permet de sortir de la boucle
        }
        public static string MinMax(int min, int max)
        {
            return $"Saisi un chiffre entre {min} et {max} : ";
        }
        public static int NumberBetween( int min, int max, string question = "")
        {
            string dynamicQuestion = MinMax(min, max);

            while (true)
            {
                int number = AskingNumber(dynamicQuestion);

                if ((number >= min) && (number <= max))
                {
                    return number;
                }
                {
                    Console.WriteLine("ERREUR : " + question);
                    Console.WriteLine();
                }
            }
        }
    }

}
