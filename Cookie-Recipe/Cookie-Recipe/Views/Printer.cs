using Cookie_Recipe.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cookie_Recipe.Views
{
    internal class Printer
    {
        
        public static void PrintMenu(List<Ingredient> ingredients)
        {
            Console.WriteLine("Create a new cookie recipe! Available ingredients are: ");

            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Id}. {ingredient.Name}");
            }
        }

        public static void PrintEnterInput()
        {
            Console.WriteLine("Enter Id to add ingredient.");
            Console.WriteLine("Enter 'q' to finish .\n");
        }
    }
}
