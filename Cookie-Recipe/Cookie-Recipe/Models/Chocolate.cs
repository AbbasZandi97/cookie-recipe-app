namespace Cookie_Recipe.Models
{
    internal class Chocolate : Ingredient
    {
        public Chocolate(string name, int id) : base("Chocolate", 4)
        {
        }

        public override string GetInstruction() => "Chop or melt the chocolate as required; temper if needed for a glossy finish.";
    }
}
