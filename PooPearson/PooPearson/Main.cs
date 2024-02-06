using PooPearson;
using PooStudent;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class App
    {

        static void Main(string[] args)
        {
            var p = new Pearson("Yacine" , 26);

            p.Display();
            var p1 = new Pearson("Sofiane" , 20);
 
            p1.Display();

            var s = new Student("Yannick" , 20 , "Etudiant en développement C#");
            s.Display();

            var s2 = new Student("Yannick", 20, "Etudiant en développement C#");
            s2.Display();

            Console.WriteLine($"\nNombre Total de Personne : {Pearson.CountTotal()}");

        }
    }
} 