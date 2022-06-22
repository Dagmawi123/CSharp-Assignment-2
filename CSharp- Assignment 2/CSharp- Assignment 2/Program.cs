using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp5
{
    class Program

    {
        static void Main(string[] args)
        {
            String a = "No";
            do
            {
                Console.WriteLine("What do you want to read?JOKE,NEWS,FUNFACT ");
                String a1 = Console.ReadLine();
                if (a1.Equals("News"))
                {
                    Console.WriteLine("Prosperity Party executive committee sets directions to strengthen law enforcement measures.The executive committee of the ruling PP is currently holding its regular meeting and discussing current issues including ongoing law enforcement measures being carried out by federal and regional security forces."

+ " The Executive Committee condemned the mass killings of innocent civilians by terrorist organizations in several parts of the country." +

"The committee noted that the terrorist group was carrying out the attack in a bid to cover up the losses incurred by the crackdown." +

"Executive put in place directives to strengthen the law enforcement measures based on the decision made by the National Security Council.");
                }
                else if (a1.Equals("Joke")) { Console.WriteLine("What is corn’s favorite music? .....Pop"); }
                else if (a1.Equals("Fun Fact"))
                {
                    Console.WriteLine("The sentence, The quick brown fox jumps over the lazy dog uses every letter in the English language.");
                }


                else { Console.WriteLine("Sorry I can't understand your choice"); }
                Console.WriteLine("Should we Continue?");
                a = Console.ReadLine();
            } while (a.Equals("Yes"));
        }
    }

}
