using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PooPearson;

namespace PooStudent
{
    class Student : Pearson
    {
        string formation;
        public Student(string name, int year, string formation) : base(name, year)
        {
            this.formation = formation;
       
        }
           
        public virtual void Display()
        {
            Console.WriteLine("ETUDIANT N° " + (this.numero + 1));
            this.DisplayNameAndYear();
            Console.WriteLine($" La formation de l'étudiant suivie : {this.formation}");
        }
    }
}
