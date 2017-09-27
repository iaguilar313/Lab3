using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinue = true;

            while (ProgramContinue == true)
            {
                int Input;
                Console.WriteLine("Learn Your Squares and Cubes");
                Console.WriteLine("Please Enter A Integer");
                Input = int.Parse(Console.ReadLine());
                Console.WriteLine("Number" + "\t" + "Square" + "\t" + "Cubed");

                for (int i = 1; i <= Input; i++)
                    // for (int i = input; i>=1;i--)

                {
                    Console.WriteLine(i + "\t" + Math.Pow(i, 2) + "\t" + Math.Pow(i, 3));
                }

                string UserChoice;
                Console.WriteLine("Do you want to run the code again? (N/No/y/yes)");
                UserChoice = Console.ReadLine();
                if (UserChoice == "N" || UserChoice == "No")
                {
                    ProgramContinue = false;
                    Console.WriteLine("Bye");
                }
            }
        }
    }
}
