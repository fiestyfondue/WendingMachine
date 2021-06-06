using System;
using System.Collections.Generic;
using System.Text;

namespace Wending_Machine
{
    class WendingMachine
    {
        private int Cost_of_Drink=75;
        private int depositedAmount;
        

       
        public WendingMachine()                      //Constructor
        {
            depositedAmount += 0;
        }

        public void depositCoin(int coinAmount)
        {
            depositedAmount = coinAmount;
        }
        public void GetDrink()
        {
            if(depositedAmount>=Cost_of_Drink)
            {
                Console.WriteLine("Your change is {0} rupees",depositedAmount - Cost_of_Drink);
                depositCoin(0);
            }
            else
            {
                Console.WriteLine("Insert more coins");
            }
        }

        public void Refund()
        {
            Console.WriteLine("You are refunded {0}", depositedAmount);
            depositedAmount=0;
        }
    }
}
