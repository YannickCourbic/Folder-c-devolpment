
using System;
using UtilsFormationCS;

namespace password_generator
{
    class PasswordGenerator
    {
        static void Main(string[] args)
        {
            const int NB_PASS = 8;
            //1 -  Demander la longueur du mot de passe (DemanderNombre) int longueur_mot_de_passe ...

            //2 - alphabet "abcd123" 4 "id4e"

            //3 - comment choisir un caractère aléatoire

            int longueur = Utils.AskNumberPositifAndNotNull("Quel est la longueur du mot de passe ? : ");
            string minuscules = "azertyuiopqsdfghjklmwxcvbn";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123654789";
            string specialCharacters = "&é(-è_çà)=$ù!:;.,?]@^\\[|#{}~*";

            Console.WriteLine();
            int choiceAlphabet = Utils.AskNumberEntry(
                    "1 - Uniquement des caractères en minuscule\n" +
                    "2 - Des caractères minuscules et majuscules\n" +
                    "3 - Des caractères et des chiffres\n" +
                    "4 - Caractères , chiffres et caractères spéciaux\n" +
                    "***************************************************\n", 1 , 4);
            string alphabet;
            if(choiceAlphabet == 1)alphabet = minuscules;
            else if (choiceAlphabet == 2)alphabet = majuscules + minuscules;
            else if(choiceAlphabet == 3)alphabet = chiffres + majuscules + minuscules;
            else alphabet = chiffres + majuscules + minuscules + specialCharacters; 
            int l = alphabet.Length;
            Random random = new Random();
            string password = "";
            
       

      

            for (int i = 0; i < NB_PASS; i++)
            {
                for (int j = 0; j < longueur; j++)
                {
                    int index = random.Next(1, (l - 1));
                    password += alphabet[index];
                }

                Console.WriteLine($"\nMot de passe n°{i+1} : {password} \n");
                password = "";
            }

        }

    }
}