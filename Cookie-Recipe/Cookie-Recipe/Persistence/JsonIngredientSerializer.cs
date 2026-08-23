using System.Text.Json;

namespace Cookie_Recipe.Persistence
{
    internal class JsonIngredientSerializer : ISerializer
    {
        
        public void Serialize(HashSet<int> ingredientIds)
        {

            string json = JsonSerializer.Serialize(ingredientIds);
            File.WriteAllText("ingredientIds.json", json);
        }

        public HashSet<int> Deserialize()
        {
            string json = File.ReadAllText("ingredientIds.json");

            return JsonSerializer.Deserialize<HashSet<int>>(json);
        }

    }
}
