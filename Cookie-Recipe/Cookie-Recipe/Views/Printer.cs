using Cookie_Recipe.Models;

namespace Cookie_Recipe.Views
{
    internal class Printer
    {
        
        public static void PrintMenu(List<Ingredient> ingredients)
        {
            Console.WriteLine("Create a new cookie recipe! Available ingredients are: ");

            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Id}. {ingredient.Name}");
            }

            Console.WriteLine();
        }

        public static void PrintEnterInput()
        {
            Console.WriteLine("Enter Id to add ingredient. (repetitive ingredient does not count)");
            Console.WriteLine("Enter 'q' to finish .\n");
        }


        public static void PrintRecipe(HashSet<int> choices, List<Ingredient> ingredients)
        {
            if (choices.Count != 0)
            {
                Console.WriteLine("\nRecipe added: ");

                foreach (var choice in choices)
                {
                    Console.WriteLine(ingredients[choice - 1].GetInstruction());
                }

            }
            else
            {
                Console.WriteLine("You did not add anything to your Recipe.");
                Console.WriteLine("There's nothing to be printed.");
                Console.WriteLine("Next time, add some delicious ingredients to your Recipe.");
            }

            Console.WriteLine();
        }

        public static void AskForSave()
        {
            Console.Write("Save the Recipe ? (Y/N) : ");
        }

        public static void PrintInvalidInput()
        {
            Console.WriteLine("Invalid input.");
            Console.WriteLine("Try again.");
        }

        public static void PrintSavedRecipe(HashSet<int> savedItems, List<Ingredient> ingredients)
        {
            Console.WriteLine("Saved Recipe: ");

            foreach (var item in savedItems)
            {
                Console.WriteLine(ingredients[item - 1].GetInstruction());
            }

            Console.WriteLine();
        }

    }
}
