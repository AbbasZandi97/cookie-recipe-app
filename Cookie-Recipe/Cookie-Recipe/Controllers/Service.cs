using Cookie_Recipe.Input;
using Cookie_Recipe.Models;
using Cookie_Recipe.Views;

namespace Cookie_Recipe.Controllers
{
    internal class Service
    {
        private InputHandler inputHandler;
        private List<Ingredient> ingredients;

        public Service()
        {
            inputHandler = new InputHandler();

            
            // if a new ingredient is added to the project, an object of it must be added here also.
            ingredients = new List<Ingredient>
            {
                new Butter(),
                new Sugar(),
                new WheatFlour(),
                new CocoaPowder(),
                new Cinnamon(),
                new Chocolate(),
                new Cardamom(),
                new CoconutFlour()
            };
        }

        public void StartApp()
        {
            Printer.PrintMenu(ingredients);
            var inputs = GetUserInput();

            // mapping selected items in numbers to real ingredients
            List<Ingredient> selectedIngredients =
                GetSelectedIngredietns(inputs);

            Printer.PrintRecipe(selectedIngredients);

            // other parts of the program to be completed
        }

        
        public HashSet<int> GetUserInput()
        {
            int numberOfIngredients = ingredients.Count;
            var choices = new HashSet<int>();
            
            
            while (true)
            {

                Printer.PrintEnterInput();
                int? id = inputHandler.ValidateIngredientId(numberOfIngredients);

                if (id == null)
                    break;

                choices.Add(id.Value);

            }

            return choices;

        }

        private List<Ingredient> GetSelectedIngredietns(HashSet<int> inputs)
        {
            var selectedIngredients = new List<Ingredient>();

            foreach (int id in inputs)
            {
                foreach (Ingredient ingredient in ingredients)
                {
                    if (ingredient.Id == id)
                    {
                        selectedIngredients.Add(ingredient);
                        break;
                    }
                }
            }

            return selectedIngredients;
        }
    }
}
