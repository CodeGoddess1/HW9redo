using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace BlackJack.Console
{
    public class Cards
    {
       
        public int PlayerCards()
        {
            int RanNum;
            Random myNum = new Random();
            Thread.Sleep(2000);
            RanNum = myNum.Next(1,10);
            return RanNum;

        }
        public int PlayerCards2()
        {
           
            int RanNum;
            Random myNum = new Random();
            Thread.Sleep(2000);
            RanNum = myNum.Next(1, 10);
            return RanNum;

        }
        public int PlayerCards3()
        {

            int RanNum;
            Random myNum = new Random();

            RanNum = myNum.Next(1, 10);
            return RanNum;

        }

        public int DealerCards()
        {
            int DemNum;
            Random myDemNum = new Random();
            Thread.Sleep(2000);
            DemNum = myDemNum.Next(1, 10);
           
           
            return DemNum;
            

        }
        public int DealerCard2()
        {
            int DemNum2;
            Random myDemNum = new Random();
            Thread.Sleep(2000);
            DemNum2 = myDemNum.Next(1, 10);

            return DemNum2;
        }

       
       
    }








    
    
}

