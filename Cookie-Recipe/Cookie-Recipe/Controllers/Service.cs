using Cookie_Recipe.Input;
using Cookie_Recipe.Models;
using Cookie_Recipe.Persistence;
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
                new Butter("Butter", 1),
                new Sugar("Sugar", 2),
                new WheatFlour("Wheat Flour", 3),
                new CocoaPowder("Cocoa Powder", 4),
                new Cinnamon("Cinnamon", 5),
                new Chocolate("Chocolate", 6),
                new Cardamom("Cardamom", 7),
                new CoconutFlour("Coconut Flour", 8)
            };
        }

        public void StartApp()
        {
            Printer.PrintMenu(ingredients);
            
            // repetitive values must not be counted as inputs
            // so we use HashSet which holds inputs as INT (NUMBER)
            var inputs = GetUserInput();

            // Recipe is made of selected ingredients
            // these ingredients must be saved for next use if user wants to save.
            Printer.PrintRecipe(inputs, ingredients);

            Printer.AskForSave();

            bool saveTheRecipe = inputHandler.DoesUserWantToSave();

            if (saveTheRecipe) Save(inputs);

            
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

        private void Save(HashSet<int> inputs)
        {
            // based on project needs, saving format must be set here.
            Format format = Format.JSON;

            if (format == Format.JSON)
                new JsonIngredientSerializer().Serialize(inputs);

            if (format == Format.TXT)
                new TxtSerializer().Serialize(inputs);

        }


    }
}
