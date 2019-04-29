using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Console;
using System.Diagnostics;
using System.Threading;

namespace BlackJack.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Cards myCards = new Cards();
            int PlayerCards;
            int PlayerCards2;
            int PlayerCards3;
            int DealerCards;
            int DealerCards2;
            int total3 = 0;
            int dTotal3 = 0;
            bool play = true;
            string wager;
            int winningTot;
            int dTotal2;
            

            do
            {

                System.Console.Write(" Player what is your name? ");
                string playerName = System.Console.ReadLine();
                System.Console.WriteLine($" Welcome To BlackJack:   {playerName} ");
                System.Console.Write(" How much would you like to wager? ");
                wager = System.Console.ReadLine();
                System.Console.WriteLine($" Thank you for your bet of:   {wager}, {playerName}");


                try
                {
                    System.Console.WriteLine(" Lets Play !!! ");
                    PlayerCards = myCards.PlayerCards();
                    string card = PlayerCards.ToString();
                    System.Console.WriteLine (PlayerCards);
                    

                    PlayerCards2 = myCards.PlayerCards();
                    System.Console.WriteLine(PlayerCards2);
                    int total = PlayerCards + PlayerCards2;
                    System.Console.WriteLine(total);

                    System.Console.Write(" Would You like another card ? Type { Y }  if Not Type  { N } and Double click ENTER key  ");
                    string thirdCard = System.Console.ReadLine();
                    string noCard = System.Console.ReadLine();

                    if (thirdCard == "Y")
                    {
                        PlayerCards3 = myCards.PlayerCards();
                        System.Console.WriteLine(PlayerCards3);
                        total3 = total + PlayerCards3;
                        System.Console.WriteLine(total3);
                    }
                    else if (noCard == "N")
                    {

                    }
                        System.Console.WriteLine("Dealers Turn");
                        DealerCards = myCards.DealerCards();
                        string deCards = DealerCards.ToString();
                        System.Console.WriteLine(DealerCards);

                        DealerCards2 = myCards.DealerCards();
                        System.Console.WriteLine(DealerCards2);
                        dTotal2 = DealerCards + DealerCards2;
                        System.Console.WriteLine(dTotal2);
                    
                    if (dTotal2 <= 17)
                    {
                         DealerCards = myCards.DealerCards();
                         System.Console.WriteLine(DealerCards);
                         dTotal3 = dTotal2 + DealerCards;
                         System.Console.WriteLine(dTotal3);
                    }
                    winningTot = int.Parse(wager);
                    try
                    {
                        if ((total3 >= 21 & dTotal3 >= 21) || (total3 > dTotal3))//if player card is greater then or equal to 21 an dealers card is greater then or equal to 21 but players card is higher then player wins
                        {
                            System.Console.WriteLine($"{ playerName } YOU WIN { winningTot * 2 }!!!! ");
                        }
                        else if ((total3 <= 21 & dTotal3 <= 21) || (total3 < dTotal3))//if player card is less then or equal to 21 an dealers is less then or equal to 21 but dealers card is higher then dealer wins
                        {
                            System.Console.WriteLine($"DEALER WINS { winningTot * 2 }!!!! ");
                        }
                        else if (total3 > 21 )
                        {
                            System.Console.WriteLine($"DEALER WINS {winningTot * 2 }!!!!");
                        }
                       else if (dTotal3 > 21)
                        {
                            System.Console.WriteLine( $"{playerName} YOU WIN {winningTot * 2}!!!!");
                        }
                        if (total3 > 21 && dTotal3 > 21)
                            System.Console.WriteLine(" NO WINNER ");
                    }
                    catch (OverflowException)
                    {
                        if((total >=21 & dTotal3 >= 21)|| (total > dTotal3))
                        {
                            System.Console.WriteLine($"{playerName} YOU WIN {winningTot * 2}!!!!");
                        }
                        else if ((total <= 21 & dTotal3 <= 21) || (total < dTotal3))
                        {
                            System.Console.WriteLine($"DEALER WINS { winningTot * 2 }!!!! ");
                        }

                        else if (total > 21)//if first two player cards exceed 21 player losese
                        {
                            System.Console.WriteLine($"{ playerName } YOU LOSE....Sorry Play Again ");
                        }
                        
                    }

                }
                catch (Exception)
                {
                    System.Console.WriteLine(" An Error Occurred ");
                }
                
                System.Console.WriteLine(" Thank you for Playing ");
                System.Console.WriteLine(" Do you want to play again type {play} if not {exit} ");
                string exitGame = System.Console.ReadLine();
                if (exitGame == "exit")
                {
                    break;
                }
            } while (play == true);

           
        }
        
    }
}
