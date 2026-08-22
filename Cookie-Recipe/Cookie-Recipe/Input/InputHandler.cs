namespace Cookie_Recipe.Input
{
    internal class InputHandler
    {
        public int? ValidateIngredientId(int numberOfIngredients)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                
                // parsable string && within range output
                if (int.TryParse(input, out int id))
                {
                    if (id >= 1 && id <= numberOfIngredients)
                        return id;
                }

                
                if (input?.ToLower() == "q") return null;

                Console.WriteLine("Please enter a valid ID.");
            }
        }
    }
}
