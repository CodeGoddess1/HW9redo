using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Console;

namespace BlackJack.Console
{
    class Program
    {
        static void Main(string[] args)
        {
           // do
           // {

                int PlayerCard;
                int PlayerCard2;
                int PlayerCards3;
                int DealerCard;
                int SumTot;
                string E = string.Empty;
                string Y = string.Empty;



                //try
                //{
                    Cards myCards = new Cards();
                    
                    //System.Console.WriteLine("How much would you like to wager");
                    //string wager = System.Console.ReadLine();
                    //System.Console.WriteLine("Thank you for your bet");
                    
                    PlayerCard = myCards.PlayerCard();
                    System.Console.Write(PlayerCard);
                    
                   // System.Console.WriteLine("Would You like another card");
                   // string card = System.Console.ReadLine();
              //  }
                //catch (Exception)
                //{
                //    System.Console.WriteLine("An Error Occurred");
                //}
                //System.Console.WriteLine("Do you want to play again type Y");
                //System.Console.WriteLine(" If you want to Exit type E");
                //E = System.Console.ReadLine();
                //System.Console.WriteLine("Thank you for Playing ");

           // } while (true);

        }
    }
}
