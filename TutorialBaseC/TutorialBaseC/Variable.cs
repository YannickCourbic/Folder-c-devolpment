
using System.Numerics;
using System.Text.RegularExpressions;

class Variable
{
    public static void variableString()
    {
        String name = "Paul";
        Console.WriteLine(name);
        Console.WriteLine("Une variable de type string");
    }

    public static void variableBoolean()
    {
        Boolean bol = true;
        Console.WriteLine("Une variable de type booléen" + bol);
    }

    public static void variableInteger(string name , int years , bool dev)
    {
        Console.WriteLine("Je m'appelle " +  name + " , j'ai " + years + " ans " + (dev ? ", et je suis un développeur passionée. ": ""));
    }

    public static void askForUser()
    {   

        
        try
        {
            Console.Write("Quel est ton nom ? ");
            String name = Console.ReadLine();
            Console.Write("Quel est ton âge ? ");
            String years = Console.ReadLine();
            int years_sup = int.Parse(years) + 1;
            if(years_sup <= 0) { throw new Exception(); }
            Console.Write("Quel est ta profession ?");
            String professional = Console.ReadLine();
            Console.WriteLine("Vous vous appelez " + name + ", vous avez " + years + " ans et votre profession est " + professional + ".");
            Console.WriteLine("Vous aurez bientôt " + years_sup + " ans");
        }
        catch {
            Console.WriteLine("Erreur , vous devez rentrez un age valide.");
        }
        
   
    }


    public static void variableNumeric()
    {
        int numericVar = 1000000;
        Console.WriteLine(numericVar);

    }


    public static void loopAskUser()
    {
        string name = "";
        string strYears = "";
        string professional = "";

        try
        {
            while (name == "")
            {
                Console.Write("Veuillez entrez votre nom : ");
                name = Console.ReadLine();
                if(Regex.IsMatch(name , @"^([0-9!@#\$%\^&\*\(\)\]\[]+)$")) { 
                    throw new Exception("Veuillez écrire un nom valide."); 
                }
                else if (name.Equals("") ){
                   Console.WriteLine("Veuillez écire un nom qui n'est pas vide.");
                }

            }

            while (strYears == "") {
                Console.Write("Veuillez entrez votre age : ");
                strYears = Console.ReadLine();
                if (strYears.Equals(""))
                {
                    Console.WriteLine("Veuillez écrire un âge valide et non vide.");
                    Console.Write("Veuillez entrez voytre âge : ");
                    strYears = Console.ReadLine();
                }
                int intyears = int.Parse(strYears);
                if (intyears <= 0) {
                    Console.WriteLine("Veuillez écrire un âge valide et supérieur à 0.");
                    Console.Write("Veuillez entrez votre âge : ");
                    strYears = Console.ReadLine();
                }
            
            }

            while (professional == "") {
                Console.Write("Veuillez entrer votre profession : ");
                professional = Console.ReadLine();
                if (professional.Equals(""))
                {
                    Console.WriteLine("Veuillez écrire une profession valide et non vide.");
                    Console.Write("Veuillez entrez votre profession : ");
                    professional = Console.ReadLine();
                }
                else if (Regex.IsMatch(professional , @"^([0-9!@#\$%\^&\*\(\)\]\[]+)$"))
                {
                    throw new Exception("Veuillez entrez une profession valide.");
                }
            }

            Console.WriteLine("Vous vous appelez " + name + ", vous avez " + strYears + " ans et votre profession est " + professional + ".");


        }
        catch (Exception e) 
        {
            Console.Write("Une erreur est survenue... \n");
            Console.Write(e.ToString());
        }
    }




}