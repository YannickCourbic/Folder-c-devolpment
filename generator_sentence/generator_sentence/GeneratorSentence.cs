namespace generator_sentence
{
    class GeneratorSentence
    {   
        private static readonly Random rand = new Random();
        public static void Main(String[] args) {

            var sujets = new String[] {
                "Un Sacrieur" , 
                "Un Huppermage",
                "Un Scram",
                "Un Iop",
                "Un Zobal",
                "Un Féca",
                "Un Pandawa",
                "Un Steamer",
                "Un Crâ",
                "Un Enutrof",
                "Un Eliotrope",
                "Un Osamodas",
                "Un Ecaflip",
                "Un Ouginak",
                "Un Eniripsia",
                "Un Forgelance",
                "Un Xelor",
                "Un Roublard"
            };

            var verbes = new String[] { 
                "mange",
                "attaque",
                "détruit",
                "utilise",
                "nettoie",
                "se bat avec",
                "observe",
                "s'accroche à",
            };

            var complements = new String[] { 
                "des fougasse qui redonnent 90 point d'énergie",
                "des monstres sur incarnam",
                "des monstres sur astrub",
                "des monstres sur l'île de moon",
                "une compétence à 3 PA",
                "la compétence flammiche",
                "le sort cawotte et l'invoque",
                "un Iop sans cervelle féru de combat sanguinaire et se proclame le nouveau goultard",
                "des pious dans les plaines d'astrub, que c'est mignon!",
                "un arbre",
                "le soleil"
            };

            const int NB_SENTENCE = 100;


            DisplayRandomSentences(sujets, verbes, complements, NB_SENTENCE);
        }
        private static string RandomElementString(string[] s)
        {
          return s[rand.Next(0, s.Length)];
        }

        private static void DisplayRandomSentences(string[] sujets, string[] verbes, string[] complements, int nbSentences)
        {
            var listSentences = new List<string>();
            var doublons = 0;

            while(listSentences.Count < nbSentences)
            {
                var sujet = RandomElementString(sujets);
                var verbe = RandomElementString(verbes);
                var complement = RandomElementString(complements);

                var sentence = $"{sujet} {verbe} {complement}.";
                sentence = sentence.Replace("à le", "au");

                if (!listSentences.Contains(sentence))
                {
                    listSentences.Add(sentence);
                }
                else
                {
                    doublons++;
                }
            }
            

            foreach (var s in listSentences) {
                Console.WriteLine(s);
            }

            Console.WriteLine($"Nombre de doublon évitée pour {listSentences.Count} phrases générées : {doublons}");
        }




    }
}