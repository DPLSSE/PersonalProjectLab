using System;
using System.Collections.Generic;


namespace SimonGame
{

    public class Button
    {
        
        int _buttonValue;
        


        public Button(int buttonValue)
        {
            _buttonValue = buttonValue;
            

        }

        public void addToInputList(List<int> InputtyList, int UserIn)
        {
            
            if (UserIn == _buttonValue)
            {
                InputtyList.Add(_buttonValue);
            }
        }
    }
}

            
