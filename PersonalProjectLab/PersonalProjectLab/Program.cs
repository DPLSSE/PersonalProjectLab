using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SimonGameClass;
using GamestatsClass;

namespace SimonGame
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Simon.  The objective is simple: Survive");
            Thread.Sleep(3000);
            Console.WriteLine("To play, enter the string of numbers that appears.  Then enter zero to end your turn.");
            Thread.Sleep(5000);
            var randomButton = new Random();
            List<int> OutList = new List<int>();
            List<int> InList = new List<int>();
            OutList.Add(0);
            InList.Add(0);
            bool listsMatch = true;
            Button Button1 = new Button(1);
            Button Button2 = new Button(2);
            Button Button3 = new Button(3);
            Button Button4 = new Button(4);
            int iterationCounter = 0;

            while (listsMatch == true)
            {
                Console.Clear();
                OutList.Remove(0);
                for (int j = 0; j <= iterationCounter; j++)
                {
                    
                    int outValue = randomButton.Next(1, 5);
                    //console colors: just for fun!
                    //if (outValue == 1)
                  //  {
                  //      Console.ForegroundColor = ConsoleColor.Cyan;
                  //  }
                  //  else if (outValue == 2)
                  //  {
                  //      Console.ForegroundColor = ConsoleColor.Green;
                  //  }
                  //  else if (outValue == 3)
                  //  {
                  //      Console.ForegroundColor = ConsoleColor.Yellow;
                   // }
                  //  else
                  //  {
                  //      Console.ForegroundColor = ConsoleColor.Red;
                  //  }
                    //back to actual code
                    Console.WriteLine(outValue);
                    OutList.Add(outValue);


                }
                OutList.Add(0);
                iterationCounter += 1;
                InList.Remove(0);

                for (int i = 0; i <= (iterationCounter); i++)
                {
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput != 0)
                    {
                        Button1.addToInputList(InList, userInput);
                        Button2.addToInputList(InList, userInput);
                        Button3.addToInputList(InList, userInput);
                        Button4.addToInputList(InList, userInput);
                    }


                    else if (userInput == 0)
                    {
                        InList.Add(0);
                        if (OutList.SequenceEqual(InList))
                        {
                            listsMatch = true;

                        }
                        else
                        {
                            listsMatch = false;
                            GameStats FinalStats = new GameStats();
                            FinalStats.printStats(iterationCounter);

                        }

                    }

                }


            }
            
        }
        







    }
}