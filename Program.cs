using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 dimensional array!
            string[,] topics = { { "cat", "dog", "frog", "hedgehog"},
                                    { "zebra", "giraffe", "lion", "e;ephant"},
                                    { "stingray", "octopus", "shark", "whale"}};
            // we can use foreach to iterate through the list of lists, one list at a time.
            foreach (string topic in topics)

            {
                // output the current animal!
                Console.WriteLine("this animal is: {0}", topic);
            }
        }
    }

}
