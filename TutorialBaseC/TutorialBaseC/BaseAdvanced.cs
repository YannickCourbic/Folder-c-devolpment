using System;
using System.Text.RegularExpressions;

class BaseAdvanced
{
    public static void AskForUserAdvanced()
    {
        //string name1 = AskName(1);
        //int year1 = AskYear(name1);
        //DisplayResult(name1 , year1);
        //string name2 = AskName(2);
        //int year2 = AskYear(name2);
        //DisplayResult(name2 , year2);

        for (int i = 1; i < 3; i++)
        {
            string name = AskName(i);
            int year = AskYear(name);
            DisplayResult(name, year);
            Console.WriteLine();
            Console.WriteLine("---");
        }



    }

    static string AskName(int index)
    {
        string name = "";
        while (name == "")
        {
            Console.WriteLine("Quel est le nom de personne n° " + index + " ?");

            try
            {
                name = Console.ReadLine();
                name = name.Trim();
                if (name.Equals(""))
                {
                    throw new Exception("Une chaîne ne peut être vide.");
                }
                if (Regex.IsMatch(name, @"^[0-9\W]+$"))
                {
                    throw new Exception("La chaîne de caractère ne peut pas contenir des chiffres");
                }

            }
            catch (Exception e)
            {
                name = "";
                Console.WriteLine("Erreur , vous avez rentrez un nom non valide : " + e.Message);
            }
        }

        return name;
    }

    static int AskYear(string name)
    {
        int year = 0;
        while (year <= 0)
        {

            Console.WriteLine(name + " quel est ton âge ?");

            string year_str = Console.ReadLine();

            try
            {
                year = int.Parse(year_str);
                if (year < 0)
                {
                    throw new Exception("Erreur : Vous ne pas entrez des valeurs négative.");
                }
                else if (year == 0)
                {
                    throw new Exception("Erreur: l'âge ne doit pas être égal à 0.");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur , vous avez rentrez un âge non valide");
                Console.WriteLine(e.Message);
            }

        }

        return year;
    }



    static void DisplayResult(string name , int year , float size = 0) {
        Console.WriteLine("Bonjour , vous vous appelez " + name + ", vous avez " + year + " ans");
        int nextYear = year + 1;
        Console.WriteLine("Bientôt vous aurez " + nextYear + " ans");

        if(year == 18)
        {
            Console.WriteLine("Vous êtes tout juste majeur.");

        }
        else if(year == 1 || year == 2)
        {
            Console.WriteLine("Vous êtes un bébé");
        }
        else if(year == 17)
        {
            Console.WriteLine("Vous serez bientôt majeur");
        }
        else if (year >= 12 && year < 18)
        {
            Console.WriteLine("Vous êtes un adolescent.");
        }
        else if(year >= 60)
        {
            Console.WriteLine("Vous êtes un senior");
        }
        else if(year <= 10)
        {
            Console.WriteLine("Vous êtes un enfant.");
        }
        else if (year >= 18)
        {
            Console.WriteLine("Vous êtes majeur.");
        }
        else {
            Console.WriteLine("Vous êtes mineur.");    
        }
        if(size != 0)
        {
            Console.WriteLine("Vous faites " + size + "m de hauteur.");

        }
    }



}