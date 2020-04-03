using System;
using System.Linq;
using System.Collections.Generic;


namespace SimonGame
{

    public class Button
    {
        
        int _buttonValue;
        List<int> _UserInputList;
        


        public Button(int buttonValue)
        {
            _buttonValue = buttonValue;
            

        }

        public void addToInputList(List<int> UserInputList, int UserIn)
        {
           
            if (UserIn == _buttonValue)
            {
                UserInputList.Add(_buttonValue);
            }
        }
    }
}

            
