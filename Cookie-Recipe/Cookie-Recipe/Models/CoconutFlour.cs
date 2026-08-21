namespace Cookie_Recipe.Models
{
    internal class CoconutFlour : Ingredient
    {
        public CoconutFlour(string name, int id) : base("Coconut Flour", 2)
        {
        }

        public override string GetInstruction() => $"Add the coconut flour to the" +
            $"mixture and stir until it is evenly incorporated.";
    }
}
