namespace Cookie_Recipe.Models
{
    internal class Butter : Ingredient
    {
        public Butter(string name, int id) : base(name, id)
        {
        }

        public override string GetInstruction() => "Soften the butter at room temperature before creaming it with sugar for a smooth texture.";
    }
}
