using System;
using System.Linq;
using System.Collections.Generic;


namespace SimonGameClass
{

    public class Button
    {
        
        int _buttonValue;
        
        


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

            
