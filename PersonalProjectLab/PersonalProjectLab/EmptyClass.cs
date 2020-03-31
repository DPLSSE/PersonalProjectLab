using System;
using System.Collections.Generic;
<<<<<<< Updated upstream

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
            
=======
namespace SimonGame
{
    

    public class Button
    {
      

        public Button()
        {

>>>>>>> Stashed changes
        }
    }
}
