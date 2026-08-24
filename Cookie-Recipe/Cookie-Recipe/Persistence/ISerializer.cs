namespace Cookie_Recipe.Persistence
{
    internal interface ISerializer
    {
        void Serialize(HashSet<int> ingredientIds);

        HashSet<int> Deserialize();

        bool CheckExistence();
    }
}
