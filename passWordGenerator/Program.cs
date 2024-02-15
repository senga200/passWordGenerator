//using passWordGeneratorOutils;
using System;

namespace passWordGenerator
{
    class Program
    {


        static void Main(string[] args)
        {
            string messagePassWordType = "Quel type de mot de passe voulez-vous ?\n1. uniquement des minuscules \n2. des minuscules et des majuscules \n3. Chiffres, minuscules et majuscules \n4.Chiffres, lettres et caractères spéciaux";

            Console.WriteLine("Combien de caractères doit contenir votre mot de passe  dans length? ");
            const int NUMBEROFPASSWORD_TOGENERATE = 5;
            int length = passWordGeneratorOutils.outils.NumberBetween(5 , 15);


            Console.WriteLine();
            Console.WriteLine(messagePassWordType);
         
            int passWordStyle = passWordGeneratorOutils.outils.NumberBetween( 1, 4, messagePassWordType);

            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string speciaux = "?!#*-_&@/";
            string alphabet = minuscules + majuscules + chiffres + speciaux;
            string password;

            switch (passWordStyle)
            {
                case 1:
                    alphabet = minuscules;
                    break;
                case 2:
                    alphabet = majuscules + minuscules;
                    break;
                case 3:
                    alphabet = majuscules + minuscules + chiffres;
                    break;
                case 4:
                    alphabet = majuscules + minuscules + chiffres + speciaux;
                    break;
                default:
                    Console.WriteLine("Erreur dans le switch");
                    break;

            }

            Random rand = new Random();
            int index;
            int lengthAlphabet = alphabet.Length;

                Console.WriteLine("voici vos nouveaux passwords : ");
            for (int j = 0; j < NUMBEROFPASSWORD_TOGENERATE; j++)
            {
                password = ""; // pour vider le mot de passe à chaque fois que je veux en générer un nouveau 
                for (int i = 0; i < length; i++)
                {
                    index = rand.Next(0, lengthAlphabet);
                    password += alphabet[index];
                }
                Console.WriteLine(password);
            }
           

        }
    }
}
 
       
           // note : le type char peut contenir qu'un seul caractère (en simple cote) mais peut être converti en int : (int)char, car un char est un entier de 8 bits -> 0 à 255
           // (char)65 = A, (char)97 = a, (char)48 = 0, du coup on peut faire un int pour incrementer par exemple