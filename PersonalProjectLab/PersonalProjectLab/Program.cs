using System;
using System.Collections.Generic;

namespace SimonGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var randomButton = new Random();
            List<int> OutList = new List<int>();
            List<int> InList = new List<int>();
            OutList.Add(0);
            bool listsMatch = true;
            Button Button1 = new Button(1);
            Button Button2 = new Button(2);
            Button Button3 = new Button(3);
            Button Button4 = new Button(4);
            int iterationCounter = 0;

            while (listsMatch == true)
            {
                OutList.Remove(0);
                for (int j = 0; j <= iterationCounter; j++)
                {
                    int outValue = randomButton.Next(1, 5);
                    Console.WriteLine(outValue);
                    OutList.Add(outValue);
                    
                }
                OutList.Add(0);
                iterationCounter += 1;

                for (int i = 0; i <= (iterationCounter); i++)
                {
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput != 0)
                    {
                        Button2.addToInputList(InList, userInput);
                        Button2.addToInputList(InList, userInput);
                        Button2.addToInputList(InList, userInput);
                        Button2.addToInputList(InList, userInput);
                    }


                    else if (userInput == 0)
                    {
                        if (OutList == InList)
                        {
                            listsMatch = true;

                        }
                        else
                        {
                            listsMatch = false;
                        }

                    }
                }
                

            }
        }







    }
}