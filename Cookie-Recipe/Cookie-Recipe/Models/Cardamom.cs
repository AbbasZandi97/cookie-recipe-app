namespace Cookie_Recipe.Models
{
    internal class Cardamom : Ingredient
    {
        public Cardamom(string name, int id) : base("Cardamom", 6)
        {
        }

        public override string GetInstruction() => "Lightly crush the cardamom pods to release their aroma before adding to the batter.";
    }
}
