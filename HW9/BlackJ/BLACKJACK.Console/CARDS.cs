using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Console
{
    public class Cards
    {
        Random myNum = new Random();
        public int PlayerCard()
        {
            int RanNum;

            
           return myNum.Next(1, 10);
            

        }
        public int PlayerCard2()
        {
            int RanNum = 0;
            int RanNum2;
            int TotalSum;

            Random myNum = new Random();
            RanNum2 = myNum.Next(1, 10);
            TotalSum = RanNum + RanNum2;

            return TotalSum;
        }


        public int DealerCard()
        {
            int DemNum;
            int DemNum2;
            int DemNum3;
            int TotDemNum;

            Random myDemNum = new Random();

            DemNum = myDemNum.Next(1, 10);
            DemNum2 = myDemNum.Next(1, 10);
            DemNum3 = myDemNum.Next(1, 10);
            TotDemNum = DemNum + DemNum2;
            System.Console.WriteLine();

            if (TotDemNum >= 17)
            {
                return DemNum3;
            }
            return TotDemNum;

        }
       
        public int SumTot()
        {
            int RanNum3;
            Random myTotSum = new Random();
            RanNum3 = myTotSum.Next(1, 10);

            return RanNum3;

        }

    }










}

