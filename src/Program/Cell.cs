using System;

namespace Program
{
    public class Cell
    {
        private bool state;
        public bool State
        {
            get {return state;}
            set {state = value;}
        }
        
        public void ChangeState()
        {
            if (State == true)
            {
                State = false;
            } else
            {
                State = true;
            }
        }
    }
}