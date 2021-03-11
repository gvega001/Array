using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class LINQWithListCollection
    {
        static void Main(string[] args)
        {
            //populate list of strings
            var groceryListItems = new List<string>();
            groceryListItems.Add("Milk");
            groceryListItems.Add("cereal");
            groceryListItems.Add("Butter");
            groceryListItems.Add("oranges");

            for (int counter = 0; counter < groceryListItems.Count; counter++)
            {
                Console.WriteLine($"{counter}{groceryListItems[counter]}");
            }

        }
    }
}
