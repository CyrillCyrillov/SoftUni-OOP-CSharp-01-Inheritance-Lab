using System;
using System.Linq;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings testStack = new StackOfStrings();

            testStack.IsEmpty();

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(n => n).ToArray();

            foreach (string item in input)
            {
                testStack.AddRange(item);
            }

            testStack.IsEmpty();


            //Console.WriteLine("Hello World!");
        }
    }
}
