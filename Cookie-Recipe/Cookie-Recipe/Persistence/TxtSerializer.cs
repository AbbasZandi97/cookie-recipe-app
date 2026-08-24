namespace Cookie_Recipe.Persistence
{
    internal class TxtSerializer : ISerializer
    {

        public void Serialize(HashSet<int> ingredientIds)
        {

            using StreamWriter writer = new StreamWriter("ingredientIds.txt");

            foreach (int id in ingredientIds)
            {
                writer.WriteLine(id);
            }
        }


        public HashSet<int> Deserialize()
        {
            var ids = new HashSet<int>();

            string[] lines = File.ReadAllLines("ingredientIds.txt");


            foreach (string line in lines)
            {
                ids.Add(int.Parse(line));
            }

            return ids;

        }

        public bool CheckExistence()
        {
            return File.Exists("ingredientIds.txt");
        }
    }
}
