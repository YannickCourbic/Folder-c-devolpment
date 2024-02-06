using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsFormationCS
{
     static class Utils
    {
        enum Choice_Alphabet
        {
            MINISCULE = 1,
            MAJUSCULE_AND_MINISCULE=2,
            CHARACTERS_AND_NUMBER=3,
            CHARACTERS_AND_NUMBER_AND_SPECIAL_CHARACTERS = 4
        }
        public static int AskNumberPositifAndNotNull(string question)
        {
            return AskNumberEntry(question, 1, int.MaxValue , "ERREUR : Le nombre doit être positif et non null.");
        }
        public static int AskNumberEntry(string question, int min, int max , string customError = null)
        {

            //DemanderNombre(question)
            //si le nombre est bien min et max -> Erreur/boucle 

            while (true)
            {
                int longueur = AskNumber($"{question} (compris entre {min} et {max}) ");
                try
                {
                    if (longueur < min || longueur > max)
                    {
                        throw new Exception();
                    }
                    return longueur;
                }
                catch
                {   
                    if(customError == null)  Console.WriteLine($"ERREUR : La longueur du mot de passe doit être comprise entre {min} et {max}");
                    else Console.WriteLine(customError);    
                }

            }
        }


        static int AskNumber(string question)
        {

            //poser la question
            //récupérer la réponse 
            //convertir
            //gérer l'erreur de conversion
            //boucler  tant qu'on a pas reçu une réponse valide (qui contient des chiffres)
            int resNbr;
            string resNbrStr;
            while (true)
            {
                Console.Write(question);
                try
                {
                    resNbrStr = Console.ReadLine();
                    resNbr = int.Parse(resNbrStr);
                    return resNbr;
                }
                catch
                {

                    Console.WriteLine("ERREUR: La longueur du mot de passe est invalide.");
                    Console.WriteLine();
                }
            }

        }

      
    }
}
