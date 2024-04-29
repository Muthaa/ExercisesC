using System;

namespace ContosoPetsApplication
{
    class Program
    {
        // Define the multidimensional array to store pet information
        static string[,] ourAnimals = new string[10, 6]; // Adjust size as needed

        static void Main(string[] args)
        {
            // Populate sample data for dogs and cats
            PopulateSampleData();

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
                    case "3":
                        EnsureAnimalAgesAndDescriptions();
                        break;
                    case "4":
                        EnsureAnimalNicknamesAndPersonalities();
                        break;
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
            Console.WriteLine("3. Ensure animal ages and physical descriptions are complete");
            Console.WriteLine("4. Ensure animal nicknames and personality descriptions are complete");
            Console.WriteLine("Enter menu item selection or type 'Exit' to exit the program");
        }

        // Method to populate sample data for dogs and cats
        static void PopulateSampleData()
        {
            // Sample data population
            ourAnimals[0, 0] = "1";
            ourAnimals[0, 1] = "dog";
            ourAnimals[0, 2] = "3";
            ourAnimals[0, 3] = "Golden Retriever, Male, Neutered";
            ourAnimals[0, 4] = "Friendly, Energetic";
            ourAnimals[0, 5] = "Buddy";

            ourAnimals[1, 0] = "2";
            ourAnimals[1, 1] = "dog";
            ourAnimals[1, 2] = "5";
            ourAnimals[1, 3] = "Labrador Retriever, Female, Spayed";
            ourAnimals[1, 4] = "Gentle, Playful";
            ourAnimals[1, 5] = "Luna";

            ourAnimals[2, 0] = "3";
            ourAnimals[2, 1] = "cat";
            ourAnimals[2, 2] = "2";
            ourAnimals[2, 3] = "Domestic Shorthair, Female, Spayed";
            ourAnimals[2, 4] = "Calm, Affectionate";
            ourAnimals[2, 5] = "Mittens";

            ourAnimals[3, 0] = "4";
            ourAnimals[3, 1] = "cat";
            ourAnimals[3, 2] = "1";
            ourAnimals[3, 3] = "Siamese, Male, Neutered";
            ourAnimals[3, 4] = "Talkative, Intelligent";
            ourAnimals[3, 5] = "Whiskers";
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

            // Find the next available ID
            int newId = FindNextAvailableId();

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
            ourAnimals[newId, 0] = (newId + 1).ToString();
            ourAnimals[newId, 1] = species;
            ourAnimals[newId, 2] = age;
            ourAnimals[newId, 3] = physicalCondition;
            ourAnimals[newId, 4] = personality;
            ourAnimals[newId, 5] = nickname;

            Console.WriteLine("New animal added successfully!");
        }

        // Method to find the next available ID for a new animal
        static int FindNextAvailableId()
        {
            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (ourAnimals[i, 0] == null)
                {
                    return i;
                }
            }
            return -1; // If no available ID found
        }

        // Method to ensure animal ages and physical descriptions are complete
        static void EnsureAnimalAgesAndDescriptions()
        {
            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (ourAnimals[i, 0] != null)
                {
                    if (string.IsNullOrEmpty(ourAnimals[i, 2]) || !int.TryParse(ourAnimals[i, 2], out _))
                    {
                        Console.WriteLine($"Age for pet {ourAnimals[i, 0]} ({ourAnimals[i, 5]}):");
                        ourAnimals[i, 2] = Console.ReadLine();
                    }

                    if (string.IsNullOrEmpty(ourAnimals[i, 3]))
                    {
                        Console.WriteLine($"Physical description for pet {ourAnimals[i, 0]} ({ourAnimals[i, 5]}):");
                        ourAnimals[i, 3] = Console.ReadLine();
                    }
                }
            }

            Console.WriteLine("Animal ages and physical descriptions are now complete.");
        }

        // Method to ensure animal nicknames and personality descriptions are complete
        static void EnsureAnimalNicknamesAndPersonalities()
        {
            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (ourAnimals[i, 0] != null)
                {
                    if (string.IsNullOrEmpty(ourAnimals[i, 5]))
                    {
                        Console.WriteLine($"Nickname for pet {ourAnimals[i, 0]} ({ourAnimals[i, 1]}):");
                        ourAnimals[i, 5] = Console.ReadLine();
                    }

                    if (string.IsNullOrEmpty(ourAnimals[i, 4]))
                    {
                        Console.WriteLine($"Personality description for pet {ourAnimals[i, 0]} ({ourAnimals[i, 5]}):");
                        ourAnimals[i, 4] = Console.ReadLine();
                    }
                }
            }

            Console.WriteLine("Animal nicknames and personality descriptions are now complete.");
        }
    }
}
