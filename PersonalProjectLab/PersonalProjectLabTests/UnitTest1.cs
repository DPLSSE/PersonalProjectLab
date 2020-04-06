using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using SimonGame;
using SimonGameClass;
using System.Linq;
using GamestatsClass;


namespace PersonalProjectLabTests
{
    [TestClass]
    public class UnitTest1
    {
        int iterations = 15;

        [TestMethod]
        public void ListComparison()
        {
            //arrange
            Button TestButton = new Button(5);
            List<int> TestOutput = new List<int>();
            List<int> TestInput = new List<int>();
            int TestUserIn = 5;
            
            //act
            for (int i = 0; i <= iterations; i++)
            {
                TestButton.addToInputList(TestInput, TestUserIn);
                TestOutput.Add(5);

            }
            bool ListsAreSame;
            if (TestOutput.SequenceEqual(TestInput))
            {
                ListsAreSame = true;
            }
            else
            {
                ListsAreSame = false;
            }
            //assert
            Assert.AreEqual(ListsAreSame, true);
        }
        public void GameStatsTest()
        {
            GameStats TestStats = new GameStats();
            TestStats.printStats(iterations);

           
        }
    }
}
