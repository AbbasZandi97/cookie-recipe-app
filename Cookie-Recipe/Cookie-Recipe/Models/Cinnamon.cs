namespace Cookie_Recipe.Models
{
    internal class Cinnamon : Ingredient
    {
        public Cinnamon(string name, int id) : base("Cinnamon", 7)
        {
        }

        public override string GetInstruction() => "Measure ground cinnamon carefully and add to the dry mix for a warm, aromatic flavor.";
    }
}
