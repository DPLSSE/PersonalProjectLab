using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SimonGameClass;

namespace GamestatsClass
{
    public class GameStats
    {
        public GameStats()
        {
           
        }
        public void printStats(int finalNumber, int ListLength)
        {
            int numberOfPlays = finalNumber;
            Console.WriteLine("Game over. Your final number of plays was " + numberOfPlays);
            Thread.Sleep(2000);
            Console.WriteLine("The list that killed you was " + (ListLength-1) + " numbers long.");
            Thread.Sleep(1500);
            Console.WriteLine("Simon says,'Please play again!'");
            Thread.Sleep(1500);
            Console.WriteLine("Simon also says, 'Help! I'm trapped in a computer!'");
            Thread.Sleep(1500);
            
        }
    }
}
