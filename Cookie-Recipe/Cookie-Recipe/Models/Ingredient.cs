namespace Cookie_Recipe.Models
{
    internal abstract class Ingredient
    {
        public string Name { get; set; }

        public int Id { get; set; }

        protected Ingredient(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public abstract string GetInstruction();
    }
}
