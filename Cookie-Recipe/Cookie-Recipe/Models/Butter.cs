namespace Cookie_Recipe.Models
{
    internal class Butter : Ingredient
    {
        public Butter() : base("Butter", 3)
        {
        }

        public override string GetInstruction() => "Soften the butter at room temperature before creaming it with sugar for a smooth texture.";
    }
}
