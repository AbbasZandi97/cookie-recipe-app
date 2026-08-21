namespace Cookie_Recipe.Models
{
    internal class WheatFlour : Ingredient
    {
        public WheatFlour() : base("Wheat Flour", 1)
        {
        }

        public override string GetInstruction() => "Sift the wheat flour before adding it to the dry ingredients to remove any lumps.";
    }
}
