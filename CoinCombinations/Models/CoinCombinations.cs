using System;
using System.Threading;
using System.Collections.Generic;

namespace CoinLogic 
{
    public class CoinTactics
    {
    
    public CoinTactics(double userInput)
    {
        change = userInput;
    }

        double change = 0;
        int quarter = 0;
        int dime = 0;
        int nickel = 0;
        int penny = 0;

    public int GetQuarter()
    {
        return quarter;
    }
    public int GetDime()
    {
        return dime;
    }
    public int GetNickel()
    {
        return nickel;
    }
    public int GetPenny()
    {
        return penny;
    }

           public void ChangeCalculator()
           {
               while(change > 0)
               {
                    if (change >= .25)
                    {
                        quarter ++;
                        change -= .25;
                    }
                    else if(change < .25 && change >= .10)
                    {
                        dime ++;
                        change -= .10;
                    }
                    else if (change < .10 && change >= .05)
                    {
                        nickel ++;
                        change -= .05;
                    }
                    else {
                        penny++;
                        change -= .01;
                    }
               }
           }
    }

}