using System;

namespace develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            Word word1 = new Word();
            word1.Hide();
            word1._word = "Whether";
            Console.WriteLine($"The word is: {word1.Display()}");
            word1.Unhide();
            Console.WriteLine($"The word is: {word1.Display()}");

        }
    }
}