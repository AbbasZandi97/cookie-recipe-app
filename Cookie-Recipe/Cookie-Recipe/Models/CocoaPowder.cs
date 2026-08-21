namespace Cookie_Recipe.Models
{
    internal class CocoaPowder : Ingredient
    {
        public CocoaPowder() : base("Cocoa Powder", 8)
        {
        }

        public override string GetInstruction() => "Sift the cocoa powder to remove lumps and whisk into the dry ingredients for even distribution.";
    }
}
