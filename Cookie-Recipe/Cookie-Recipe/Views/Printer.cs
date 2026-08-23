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


        public static void PrintRecipe(List<Ingredient> selectedIngredients)
        {
            Console.WriteLine("\nRecipe added: ");

            foreach (var ingredient in selectedIngredients)
            {
                Console.WriteLine(ingredient.GetInstruction());
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
    }
}
