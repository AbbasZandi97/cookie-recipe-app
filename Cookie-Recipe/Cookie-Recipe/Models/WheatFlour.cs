namespace Cookie_Recipe.Models
{
    internal class WheatFlour : Ingredient
    {
        public WheatFlour(string name, int id) : base(name, id)
        {
        }

        public override string GetInstruction() => "Sift the wheat flour before adding it to the dry ingredients to remove any lumps.";
    }
}
