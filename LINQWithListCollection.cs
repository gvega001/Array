using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class LINQWithListCollection
    {
        static void Main(string[] args)
        {
            const int ArrayLength = 5; 
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


            int[] array = new int[5]; // array contains 5 int elements
            int plus2 = 0;
            for (var counter = 0; counter < array.Length; counter++)
            {
                
                    plus2 += 2;
                array[counter] = plus2;
            }

            Console.WriteLine("Index"+ " Value" + "   8"); //headings

            //output each array element's value
            for (var counter = 0; counter < array.Length; counter++)
            {
                Console.WriteLine(counter + "      " + array[counter]);
            }

            //initializer list specifies the vale of each element
            int[] arrayInt = {89, 98, 32, 56, 91, 87};

            Console.WriteLine("Index" + " Value" + "    8"); //headings

            //output each array elements value
            for (int counter = 0; counter < arrayInt.Length; counter++)
            {
                Console.WriteLine(counter + "      " + arrayInt[counter]);
            }

            //create the array using the const for length
            int[] arrayValue = new int[ArrayLength];

            //calculate value for each array
            for (int counter = 0; counter < arrayValue.Length; counter++)
            {
                arrayValue[counter] = 2 + 2 * (counter);
            }
            //Heading
            Console.WriteLine("Index"+ "   Value");
            //print out the array values calculated
            for (int count = 0; count < arrayValue.Length; count++)
            {
                Console.WriteLine(count + "   " + arrayValue[count]);
          
            }
            //initialize 
            int[] arraySum = {87, 68, 94, 100, 83, 78, 85, 91, 76, 87};
            int total = 0; 

            //calculate the sum
            for (int counter = 0; counter < arraySum.Length; counter++)
            {
                total += arraySum[counter];

            }

            //print out the 
            Console.WriteLine("The sum is:" + total);

            //initialize 
            int[] arraySum1 = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total1 = 0;

            //using a for each to calculate sum
            foreach (var counter in arraySum)
            {
                total1 += counter;
            }

            Console.WriteLine(total1);
        }
    }
}
