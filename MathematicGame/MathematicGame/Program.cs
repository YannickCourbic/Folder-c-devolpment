namespace MathematicGame
{
    class Program
    {
        private static readonly Random rand = new Random();
        private static readonly int min = 1;
        private static readonly int max = 100;
        private static readonly int question = 5;
        static int result;

        enum e_Operator
        {
            ADDITION= 1,
            MULTIPLICATION=2,
            SOUSTRACTION= 3
        }

        static void Main(string[] args) {


            //5 + 2 =  7 nombre aléatoire 
            ExecMathematicGame();  
        }
  


        static bool EntryResponse(int a , int b, e_Operator o) 
        {
            int responseInt;
            string strAnswer;

            if (o == e_Operator.ADDITION)
            {
                strAnswer = $"{a} + {b} = ";
                result = a + b;

            }
            else if (o == e_Operator.MULTIPLICATION)
            {
                strAnswer = $"{a} x {b} = ";
                result = a * b;
            }
            else if (o == e_Operator.SOUSTRACTION)
            {
                strAnswer = $"{a} - {b} = ";
                result = a - b;
            }
            else
            {
                strAnswer = "";
            }

            while (true)
            {
                try {
                    Console.Write(strAnswer);
                    String response = Console.ReadLine();
                    responseInt = int.Parse(response);
                    break;
                }catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

              
            }

      
            return  responseInt == result;
        }

        static void MessageResult(bool res) {
            Console.WriteLine(res ? "Bonne réponse.\n\n++++++++++++++" : "Mauvaise réponse.\n\n-------------");
        }

        static void MessageScore(int point) {

            int m = question / 2;
            if (point == question)
            {
                 Console.WriteLine("Excellent !");
            }
            else if (point == 0)
            {
                Console.WriteLine("Révisez vos cours de maths.");
            }
            else if(point > m)
            {
                Console.WriteLine("Pas Mal.");
            }
            else if(point < m)
            {
                Console.WriteLine("Peut mieux faire.");
            }
      

        }

        static void ExecMathematicGame()
        {
            int point = 0;
            for (int i = 0; i < question; i++)
            {
                Console.WriteLine($"Question n°{i+1}/{question}");
                Console.WriteLine();   
                int randFirstNumber = rand.Next(min, max + 1);
                int randSecondNumber = rand.Next(min, max + 1);
                e_Operator o = (e_Operator)rand.Next(1,3);
                bool res = EntryResponse(randFirstNumber, randSecondNumber, o);
                if(res) point += 1;
                MessageResult(res);
            }
            Console.WriteLine();
            Console.WriteLine($"Votre score est de {point}/{question}"); 
            MessageScore(point);
        }
    }
}