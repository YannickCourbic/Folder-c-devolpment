using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArray
{
    class ListArrayApprentiship
    {
        private static int SomArray(int[] array)
        {
            int som = 0;
            for (int i = 0; i < array.Length; i++)
            {
                som += array[i];
            }
            return som;
        }
        private static void DisplayValuesArrayString(string[] values, List<string> list = null)
        {
            if (values.Length > 0 || values != null)
            {
                for (int i = 0; i < values.Length; i++)
                {

                    Console.Write(values[i] + " , ");
                }
            }
            else if (list.Count > 0 && list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i] + ", ");
                }
            }

        }
        private static void DisplayListe(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {

                Console.Write(list[i] + ", ");
            }
        }
        private static void DisplayArray(int[] values)
        {
            // [0] 40 

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {values[i]}");
            }
        }
        private static void DisplayMaxValue(int[] values)
        {
            int max = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > max) max = values[i];
            }

            Console.WriteLine($"La valeur maximale du tableau : {max}");
        }
        public static void Array()
        {
            //Array => stocke plusieurs valeurs 

            // type[] => tableau de int avec in[] tab = [1,2,3,4]
            //tableau de int 
            //on initialise avec le nombre d'élèment de type int 
            int[] list = new int[3];
            list[0] = 1;
            list[1] = 2;
            list[2] = 3;

            //autre syntaxe pour accéder à une valeur par l'index
            Console.WriteLine(list.GetValue(0));

            //autre syntaxe 

            //les tableaux ont une taille , pour inérer une nouvelle valeur , il faudra , utiliser les collections , similaire à java 
            int[] list2 = { 1, 2, 3 };

            int som = SomArray(list);
            int som2 = SomArray(list2);
            Console.WriteLine("La somme des valeurs contenue dans le tableau est : " + som);
            Console.WriteLine("La somme des valeurs contenue dans le tableau est : " + som2);


            //tableau de châine 

            string[] listChar = { "Yannick", "Hajime", "SkyProtect" };

            //afficher un tableau de chaîne de caractère

            DisplayValuesArrayString(listChar);

            //avoir la première lettre du premier nom


            Console.WriteLine("première lettre du nom à double index , tableau de string et tableau de char" + listChar[0][0]);
            //string -> char[]


            DisplayArray(list);

            const int TAILLE_ARRAY = 20;
            //int[]
            //Initialiser chaque élèment valeur alétoire entre 0 et 100
            Random rand = new Random();
            int[] randArray = new int[TAILLE_ARRAY];

            for (int i = 0; i < randArray.Length; i++)
            {

                randArray[i] = rand.Next(0, 101);
            }

            DisplayArray(randArray);

            //trouver la valeur maximale du tableau 

            DisplayMaxValue(randArray);
        }
        private static void DisplayList(List<int> arrListe)
        {
            for (int i = 0; i < arrListe.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] = {arrListe[i]}");

            }
        }
        public static void Listes()
        {
            //les listes , taille non fixe

            List<int> arrListe = new List<int>();

            arrListe.Add(8);
            arrListe.Add(2);
            arrListe.Add(1);
            arrListe.Add(3);
            arrListe.Add(4);
            arrListe.Add(5);

            arrListe.Remove(0);
            DisplayList(arrListe);

            List<string> arrListStr = new List<string>();

            while (true)
            {
                Console.Write("Rentrez un nom (ENTER pour finir )  :");
                string name = Console.ReadLine();
                if (name == "") { break; }
                if (!arrListStr.Contains(name)) { arrListStr.Add(name); }
                else { Console.WriteLine("ERREUR: veuillez entrez un nom non existant."); }



                //getRange
            }

            DisplayListe(arrListStr);
            Console.WriteLine("\n++++++++++++++++++++++++++++++++\n");
            List<String> firstnameArr = arrListStr.GetRange(0, 2);
            DisplayListe(firstnameArr);
            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++\n\n\n");
            DisplayListOrder(arrListStr, true);
            Console.WriteLine("\n***************************************\n");
            Console.WriteLine($"Le nom le plus grand est : {MaxNameCharacters(arrListStr)}");
            Console.WriteLine("\n********************************************\n");
            Console.WriteLine("Suppression des nom se terminant par la lettre e ");
            List<string> LRemoveLetterE = RemoveNameWithLetter('e', arrListStr);
            DisplayListOrder(LRemoveLetterE, true);

            List<string> l1 = new List<string>() { "paul", "jean", "pierre", "emilie", "martin" };
            List<string> l2 = new List<string>() { "spophie", "jean", "martin", "toto" };

            //afficher les élèments commun entre les deux listes
            Console.WriteLine("\n**************************************\n\n");
            Console.WriteLine("Afficher les noms commun : ");
            DisplayListCommonName(l1, l2);

        }
        private static void DisplayListOrder(List<string> list, bool desc = false)
        {

            if (!desc)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            else
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
        private static string MaxNameCharacters(List<string> list)
        {
            string maxCharacters = "";
            foreach (string name in list)
            {
                if (name.Length > maxCharacters.Length) maxCharacters = name;
            }

            return maxCharacters;
        }
        private static List<string> RemoveNameWithLetter(char letter, List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains(letter))
                {
                    list.RemoveAt(i);
                }
            }
            return list;
        }
        private static void DisplayListCommonName(List<string> l1, List<string> l2)
        {
            List<string> listCommon = new List<string>();

            for (int i = 0; i < l1.Count; i++)
            {
                string name1 = l1[i];
                if (l2.Contains(name1))
                {
                    listCommon.Add(name1);
                }
            }

            DisplayListOrder(listCommon);
        }
        public static void ArrayListe()
        {
            //les tableau ou liste , on est limité par le type , avec array list , on peut stocker prls type diff
            //peu utilisée , car c'est faiblement typée !

            ArrayList arrayList = new ArrayList();// <string> <int> <bool>
            arrayList.Add("Yannick");
            arrayList.Add(49);
            arrayList.Add(true);

            string name = (string)arrayList[0];//cast
            Console.WriteLine("Nom de la personne" + name);
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }


        }
        public static void ListOfList()
        {
            var country = new List<List<string>>();
            var french = new List<String>() {"France" , "Paris" , "Toulouse" , "Nice" , "Bordeaux" , "Lille"};
            country.Add(french);
            country.Add(new List<string> {"Etats-Unis" , "New-York" , "Chicago" , "Los Angeles" , "San Francisco" });
            country.Add(new List<string> {"Italie", "Venise", "Florence", "Milan", "Pise" });

            
            for(int i = 0; i < country.Count; i++) {
                
                var p = country[i];
                Console.WriteLine($"{p[0]} - {p.Count - 1} villes");  
                //for sur les villes    
                for(int j = 1; j < p.Count; j++)
                {
                    Console.WriteLine($"  - {p[j]}");
                }

            }


        }
        public static void Dictionnaries()
        {
            Dictionary<string , string> dictionnary = new Dictionary<string, string>();
            dictionnary.Add("Yannick", "0641902783");
            dictionnary.Add("Ferhat" , "0610643911");
            dictionnary.Add("Ferroudja", "0651268977");

            Console.WriteLine(dictionnary["Yannick"]);
        }
        public static void LoopForEach()
        {
            var names = new List<string>(){ "yannick", "hajime", "sofiane" , "amara"};
            var trie =  names.OrderBy(name => name); // trie par ordre alphabétique 
            names = names.Where(name => name.Length > 6).ToList();
            Console.WriteLine("\n***********************");
            foreach(string n in names)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n");
            Dictionary<string, string> dictionnary = new Dictionary<string, string>();
            dictionnary.Add("Yannick", "0641902783");
            dictionnary.Add("Ferhat", "0610643911");
            dictionnary.Add("Ferroudja", "0651268977");

            foreach (var item in dictionnary)
            {
                Console.WriteLine($"key {item.Key}  -> value {item.Value}" );
            }

            //trier par ordre alphabetique 

            var notes = new List<int> {10,8,9,81,-9,-1,0 };
            notes = notes.OrderBy(note => note).ToList();
            Console.WriteLine("\n***** Par Ordre Décroissant****\n");
            foreach (var note in notes)
            {
                if (note != notes[notes.Count - 1]) Console.Write($"{note} , ");
                else Console.Write($"{note}");
            }


        }
    }




}
