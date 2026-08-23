namespace Cookie_Recipe.Models
{
    internal class Cardamom : Ingredient
    {
        public Cardamom(string name, int id) : base(name, id)
        {
        }

        public override string GetInstruction() => "Lightly crush the cardamom pods to release their aroma before adding to the batter.";
    }
}
