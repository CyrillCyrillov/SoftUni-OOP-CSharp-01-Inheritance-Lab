using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random randomElement;

        /*
        public RandomList()
        {
            randomElement = new Random();
        }
        */


        public void RandomString()
        {
            randomElement = new Random();
            int indexToRemove = randomElement.Next(0, this.Count);
            Console.WriteLine($"Random removed: {this[indexToRemove]}");
            this.RemoveAt(indexToRemove);
        }

    }
}
