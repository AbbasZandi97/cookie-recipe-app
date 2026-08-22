using Cookie_Recipe.Input;
using Cookie_Recipe.Models;

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
            int numberOfIngredients = ingredients.Count;
            int? id = inputHandler.GetIngredientId(numberOfIngredients);

            if (id == null)
            {
                return;
            }

            int ingredientId = id.Value;
            
            // other parts of the program to be completed
        }
    }
}
