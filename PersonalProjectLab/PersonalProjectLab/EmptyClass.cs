using System;
using System.Collections.Generic;

namespace SimonGame
{ 

    public class Button
    {
        List<int> _InputList;
        List<int> _OutputList;
        int _buttonValue;
        int _UserIn;


        public Button(int buttonValue)
        {
            _buttonValue = buttonValue;

        }
      
        public void addToInputList(List<int> InputtyList, int UserIn)
        {
            if (UserIn == _buttonValue)
            {
                _InputList.Add(_buttonValue);
            }
            
        }
    }
}
