namespace Cookie_Recipe.Models
{
    internal class Sugar : Ingredient
    {
        public Sugar(string name, int id) : base(name, id)
        {
        }

        public override string GetInstruction() => $"Add sugar to the" +
            $"mixture and mix until it is evenly distributed.";
    }
}
