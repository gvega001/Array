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
            string[] groceryListItems = new string[5];
            groceryListItems[0] = "cereal";
            groceryListItems[1] = "milk";
            groceryListItems[3] = "Butter";
            groceryListItems[4] = "oranges";

            for (int counter = 0; counter < groceryListItems.Length; counter++)
            {
                Console.WriteLine(groceryListItems[counter]);
            }

            foreach (var item in groceryListItems)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
