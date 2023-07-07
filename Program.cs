using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_17
{
    class Program
    {
        static void Main(string[] args)
        {
            sort();                                                                   // Here we are calling max_min function
        }
        static void sort()
        {
            int[] Array = new int[5] { 2, 0, 1, 7, 8 };                                 //  Here we are taking randomly unsorted numbers
            int temp = 0;
          
            Console.WriteLine("Array is Displayed below : ");
            for (int i = 0; i < Array.Length-1; i++)                                   // in this loop we are actually doing sorting
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])                                   // Check previous index value eith the next value if greater than execute below condition
                    {
                        temp = Array[i];                                      // store index value into temp variable
                        Array[i] = Array[j];                                 // assign next index value to previous index
                        Array[j] = temp;                                    // assign temp value to next index value

                    }

                }
            }
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);                            // print whole array
            }

            Console.ReadKey();
        }
    }
}
