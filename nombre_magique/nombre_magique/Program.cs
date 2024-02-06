using System;
using System.Text.RegularExpressions;

namespace nombre_magique
{
    class Program
    {
        private static readonly int number_min = 1;
        private static readonly int number_max = 100;
       
        public Program() {
        
        }

        static void Main(string[] args)
        {   
            Random  random = new Random();
            //const int NOMBRE_MIN = 1;
            //const int NOMBRE_MAX = 10;
            int randomNumber = random.Next(number_min , number_max + 1);
            int number = number_min - 1;
            compareToNumberAndDisplayResult(number, randomNumber , 6);
            
          

        
        } 

        static int AskNumber(int min , int max)
        {
            int number = min - 1;
            while (number < min || (number > max))
            {
                try
                {
                    Console.Write($"Veuillez entrez un nombre entre {min} et {max} : ");
                    string strNumber = Console.ReadLine();
                    strNumber = strNumber.Trim();
              
                    if (strNumber.Equals(""))
                    {
                        throw new Exception("ERREUR : le nombre ne peut être vide.");
                    }
                    else if (Regex.IsMatch(strNumber , @"^[A-Za-z]+$"))
                    {
                        throw new Exception("Erreur :  le nombre ne peut être que des chiffres et non des lettres.");

                    }
                    else if (Regex.IsMatch(strNumber , @"^\d+\.\d+$"))
                    {
                        throw new Exception("Erreur :  le nombre ne peut être un nombre flottant , il n'accepte que des entier.");  
                    }

                    number = int.Parse(strNumber);
                    if(number == (min - 1))
                    {
                        throw new Exception("ERREUR : le nombre ne peut être égale à 0.");
                    }
                    else if (number < min)
                    {   
                        number = min - 1;
                        throw new Exception("ERREUR : le nombre ne peut être inférieur à 0.");
                    }
                    else if (number < min || number > max) {
                        number = min - 1;
                        throw new Exception($"ERREUR : le nombre doit être compris entre {min} et {max}");
                    }
                }
                catch (Exception e)
                {   
                    Console.WriteLine("ERREUR: ce nombre n'est pas valide.");
                    Console.WriteLine(e.Message);
                }
            }
            return number;
        }


       static void compareToNumberAndDisplayResult(int number , int randomNumber , int life)
        {   
            while (number != randomNumber)
            {   
                Console.WriteLine($"Il vous reste actuellement {life} chance.");
                number = AskNumber(number_min, number_max);
                if (number < randomNumber)
                {
                    Console.WriteLine("-------------------------------------------\n");
                    Console.WriteLine("Le nombre magique est plus grand.");
                    Console.WriteLine("-------------------------------------------\n");
                }
                else if (number > randomNumber)
                {
                    Console.WriteLine("-------------------------------------------\n");
                    Console.WriteLine("Le nombre magique est plus petit.");
                    Console.WriteLine("-------------------------------------------\n");
                }

                else if (number == randomNumber)
                {
                    Console.WriteLine("-------------------------------------------\n");
                    Console.WriteLine("Bravo, vous avez trouvé le nombre magique.\n");
                    Console.WriteLine("-------------------------------------------\n");
                }
                
                if(life == 0)
                {
                    Console.WriteLine("-------------------------------------------\n");
                    Console.WriteLine($"Vous avez perdu , le nombre magique était {randomNumber}");
                    Console.WriteLine("-------------------------------------------\n");
                    break;
                }
                life--;
            }
        }

    }
}