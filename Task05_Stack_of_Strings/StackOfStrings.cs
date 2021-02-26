using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if(this.Count == 0)
            {
                Console.WriteLine("Empty!");
                return true;
            }
            else
            {
                Console.WriteLine("Not Empty!");
                return false;
            }
        }

        public Stack<string> AddRange(string newString)
        {
            this.Push(newString);
            return this;
        }



    }
}
