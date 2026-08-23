using Cookie_Recipe.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookie_Recipe.Persistence
{
    internal interface ISerializer
    {
        void Serialize(HashSet<int> ingredientIds);

        HashSet<int> Deserialize();
    }
}
