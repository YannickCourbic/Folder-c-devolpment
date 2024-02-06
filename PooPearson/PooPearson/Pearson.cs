
namespace PooPearson
{
    class Pearson
    {
        protected string name;
        protected int year;
        protected string work;
        protected static int count = 0;
        protected int numero = 0;
        public Pearson(string name, int year, string work = null)
        {
            this.name = name;
            this.year = year;
            this.work = work;
            this.numero = count++;

        }

        public static int CountTotal()
        {
            return count;
        }

        protected void DisplayNameAndYear()
        {
            Console.WriteLine($" Le nom de la personne : {this.name} ,");
            Console.WriteLine($" L'âge de la personne : {this.year},");
        }
        public void Display()
        {
            Console.WriteLine("PERSONNE N° " + (this.numero + 1));
            this.DisplayNameAndYear();
            Console.WriteLine((this.work != null) ? $" L'emploi de la personne : {this.work}" : " Aucun emploi spécifié");
           
        }
    }
}