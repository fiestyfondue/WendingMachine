using System;

namespace Wending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            WendingMachine WM= new WendingMachine();

            WM.depositCoin(199);
            WM.GetDrink();
            //WM.Refund();
            Console.ReadLine();
        }
    }
}
