using System.Text.RegularExpressions;
using AsciiArt;
namespace jeu_du_pendu
{
    class GamePendu
    {
        private static string[] LoadWords(string filename)
        {
            try
            {
                return File.ReadAllLines(filename);
            }
            catch (Exception ex ){
                Console.WriteLine($"Erreur de lecture du fichier : {filename} ({ex.Message})");
            }
            return null;
        }
        private static void AfficherMot(string mot, List<char> letters)
        {
            // _ _ _ _ _ 
            for (int i = 0; i < mot.Length; i++)
            {
                char l = mot[i];
                if(letters.Contains(l))
                {
                    Console.Write($"{l} ");
                }
                else
                {
                    Console.Write("_ ");

                }
            }

        }
        private static void ReLoad()
        {
            Console.Clear();
            Console.WriteLine("Voulez vous rejouez (o/n)");
            string res = Console.ReadLine();
            if (res.Equals("o"))
            {
                Main(null);
            }
        }            
        private static void DevinerMot(string mot)
        {
                ///

                //________
                //E__E_E 
                //boucler (true)
                //  -> Cette lettre est dans le mot
                //  -> Cette lettre n'est pas dans le mot
                var letters = new List<char> ();
                var lettersNotWord = new List<char> (); 
                const int NB_VIES = 6;
                int life = NB_VIES;
          
                while (life > 0) {
                   Console.WriteLine($"Chance restante : {life}");
                   if(lettersNotWord.Count > 0)Console.WriteLine("\nLe mot ne contient pas les lettres : " + String.Join(", ", lettersNotWord));

                   Console.WriteLine(Ascii.PENDU[NB_VIES - life]);
                AfficherMot(mot, letters);
                    char l = DemanderUneLettre();   
                    Console.Clear();
                    if (mot.Contains(l))
                    {
                        letters.Add(l);
                        Console.WriteLine("\nCette lettre est dans le mot.");
                        //GAGNE et sortir de la boucle
                        if(ToutesLettresDevinees(mot , letters))
                        {
                            Console.Clear();
                            Console.WriteLine("GAGNE ! Vous avez trouvé le mot avec succès.");
                            ReLoad();
                            break;
                        } 
                    
                    }
                    else {
                        life--;
                        if (!lettersNotWord.Contains(l)) {
                             
                            lettersNotWord.Add(l);
                        }
                    }
                     Console.WriteLine();
                }
                Console.WriteLine(Ascii.PENDU[NB_VIES - life]);

                if (life == 0)
                {   
                    Console.Clear ();
                    Console.WriteLine($"PERDU ! Le mot était : {mot}");
                    ReLoad();
                }

        }

        private static bool ToutesLettresDevinees(string mot , List<char> lettres)
        {
            //true -> toutes les lettres on été trouvées -> gagné
            //false 
            // mot.Replace()
            for (int i = 0; i < lettres.Count; i++) {
                mot = mot.Replace(lettres[i].ToString(), "");
            }

            if (mot == "") return true;
            return false;   
        }

        private static char DemanderUneLettre()
        {
            //Return une lettre 
            //ERREUR: Vous devez rentrez une seule lettre
            //return -> majuscules (ToUpper)
           bool valid = true;
           string letter = "";
           while (valid) {
                try {
                    Console.Write("\n\nVeuillez tapez une lettre : ");
                     letter = Console.ReadLine();
                    if (letter == null || letter == "") throw new Exception("Veuillez tapez  une lettre !");
                    if( letter.Length > 1) throw new Exception("Vous ne pouvez rentrez qu'une seule lettre.");
                    if (Regex.IsMatch(letter, @"^[0-9\W]$+")) throw new Exception("Veuillez tapez une lettre valide.");       
                    valid = false; 
                }catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
           }
           letter = letter.ToUpper();
           char l = letter[0];
           return l;
        }

            
        static void Main(string[] args)
        {
            Random rand = new Random();
            var mots = LoadWords("mots.txt");
            if (mots == null || mots.Length == 0) Console.WriteLine("La liste de mot est vide");
            else {
                string mot = mots[rand.Next(mots.Length)].Trim().ToUpper(); 
                DevinerMot(mot); 
            }
               
            
           
        }
    }
}
