using System;

namespace ContosoPetsApplication
{
    class Program
    {
        // Define the multidimensional array to store pet information
        static string[,] ourAnimals = new string[10, 6]; // Adjust size as needed

        static void Main(string[] args)
        {
            // Populate sample data for dogs
            AddSamplePet("1", "dog", "3", "Golden Retriever, Male, Neutered", "Friendly, Energetic", "Buddy");
            AddSamplePet("2", "dog", "5", "Labrador Retriever, Female, Spayed", "Gentle, Playful", "Luna");

            // Populate sample data for cats
            AddSamplePet("3", "cat", "2", "Domestic Shorthair, Female, Spayed", "Calm, Affectionate", "Mittens");
            AddSamplePet("4", "cat", "1", "Siamese, Male, Neutered", "Talkative, Intelligent", "Whiskers");

            // Main menu loop
            while (true)
            {
                DisplayMainMenu();

                string userInput = Console.ReadLine().ToLower();
                if (userInput == "exit")
                {
                    break;
                }

                // Menu option selection
                switch (userInput)
                {
                    case "1":
                        DisplayAllPetInformation();
                        break;
                    case "2":
                        AddNewAnimal();
                        break;
                    // Add cases for other menu options here
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }

        // Method to display the main menu
        static void DisplayMainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. List all of our current pet information");
            Console.WriteLine("2. Add new animal");
            // Add other menu options here
            Console.WriteLine("Enter menu item selection or type 'Exit' to exit the program");
        }

        // Method to add a sample pet to the ourAnimals array
        static void AddSamplePet(string id, string species, string age, string physicalCondition, string personality, string nickname)
        {
            ourAnimals[int.Parse(id) - 1, 0] = id;
            ourAnimals[int.Parse(id) - 1, 1] = species;
            ourAnimals[int.Parse(id) - 1, 2] = age;
            ourAnimals[int.Parse(id) - 1, 3] = physicalCondition;
            ourAnimals[int.Parse(id) - 1, 4] = personality;
            ourAnimals[int.Parse(id) - 1, 5] = nickname;
        }

        // Method to display all pet information
        static void DisplayAllPetInformation()
        {
            Console.WriteLine("All Pet Information:");
            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (ourAnimals[i, 0] != null)
                {
                    Console.WriteLine($"Pet ID: {ourAnimals[i, 0]}");
                    Console.WriteLine($"Species: {ourAnimals[i, 1]}");
                    Console.WriteLine($"Age: {ourAnimals[i, 2]} years");
                    Console.WriteLine($"Physical Condition: {ourAnimals[i, 3]}");
                    Console.WriteLine($"Personality: {ourAnimals[i, 4]}");
                    Console.WriteLine($"Nickname: {ourAnimals[i, 5]}");
                    Console.WriteLine();
                }
            }
        }
        // Method to add a new animal
        static void AddNewAnimal()
        {
            Console.WriteLine("Adding a new animal:");
        
            // Generate a new ID for the animal
            int newId = GetNextAvailableId();
        
            // Prompt user to enter pet species
            Console.Write("Enter pet species (dog or cat): ");
            string species = Console.ReadLine().ToLower();
        
            // Prompt user to enter pet age
            Console.Write("Enter pet age (years): ");
            string age = Console.ReadLine();
        
            // Prompt user to enter physical condition
            Console.Write("Enter physical condition: ");
            string physicalCondition = Console.ReadLine();
        
            // Prompt user to enter personality
            Console.Write("Enter personality: ");
            string personality = Console.ReadLine();
        
            // Prompt user to enter nickname
            Console.Write("Enter nickname: ");
            string nickname = Console.ReadLine();
        
            // Add the new animal to the array
            ourAnimals[newId - 1, 0] = newId.ToString();
            ourAnimals[newId - 1, 1] = species;
            ourAnimals[newId - 1, 2] = age;
            ourAnimals[newId - 1, 3] = physicalCondition;
            ourAnimals[newId - 1, 4] = personality;
            ourAnimals[newId - 1, 5] = nickname;
        
            Console.WriteLine("New animal added successfully!");
        }
        
        // Method to get the next available ID for a new animal
        static int GetNextAvailableId()
        {
            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (ourAnimals[i, 0] == null)
                {
                    return i + 1; // IDs are 1-based
                }
            }
            // If no available ID found, return -1 (error condition)
            return -1;
        }
    }
}
