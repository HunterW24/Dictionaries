using System;
using System.Collections.Generic;
using System.Collections;

namespace Dictionaries_Wixson_Hunter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary to store top games
            Dictionary<int, string> topGames = new Dictionary<int, string>();

            // Add games to the dictionary
            topGames.Add(1, "Tiny Tina's Wonderland");
            topGames.Add(2, "CS:GO");
            // ... add more games

            // Iterate through the dictionary and print key-value pairs
            foreach (KeyValuePair<int, string> kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Check if a specific key exists
            if (topGames.ContainsKey(1))
            {
                Console.WriteLine($"My favorite game is: {topGames[1]}!");
            }

            // Try to get a value using TryGetValue
            string result = "";
            topGames.TryGetValue(11, out result);
            if (result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no game in the eleventh position.");

            }

            // Update a value in the dictionary
            if (topGames.ContainsKey(5))
            {
                topGames[5] = "Rocket League";
            }
            Console.WriteLine(topGames[5]);

            // Convert the dictionary to a Hashtable
            Hashtable hashtable = new Hashtable(topGames);
            string favGame = (string)hashtable[1];
            Console.WriteLine($"Favorite Game:  {favGame}");

            // Create a Hashtable using collection initializer
            Hashtable capitals = new Hashtable()
            {
                { "Oklahoma", "Oklahoma City" },
                // ... add more capitals
            };

            // Iterate through the Hashtable
            foreach (DictionaryEntry kvp in capitals)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Clear the Hashtable
            capitals.Clear();
        }
    }
}