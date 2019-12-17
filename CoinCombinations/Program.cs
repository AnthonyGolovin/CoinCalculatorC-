
using System;
using System.Threading;
using System.Collections.Generic;
using CoinLogic;

namespace CoinMain
{
    public class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Enter the change amount");
            double userChange = double.Parse(Console.ReadLine());
            CoinTactics user = new CoinTactics(userChange);
            user.ChangeCalculator();
            Console.WriteLine("Quarter: " + user.GetQuarter());
            Console.WriteLine("Dime: " + user.GetDime());
            Console.WriteLine("Nickel: " + user.GetNickel());
            Console.WriteLine("Penny: " + user.GetPenny());
            
        }

    }
}