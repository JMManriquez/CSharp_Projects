using System;
using System.Collections.Generic;
using System.Text;

namespace JMM_ECE2310_Final
{
    class Utilities
    {
        public static void FindLargest(ref int j, ref double largest, ref double[] a)
        //Passing all arguments by reference
        {
            j = 0; 
            //variable to store our index when the search algorithm has found the largest
             largest = a[0];
            //Largest Search Algorithm
            for (int i = 1; i < a.Length; i++) 
                //Note we begin at i = 1, since we have automatically stated largest to be a[0]
            {
                if (largest < a[i]) //here the testing condition to see if a[0] reall is the largest is tested in each iteration
                {
                    j = i; //here if the next number in the array is the largest, the index i is passed to j
                     largest = a[i]; //since the next number is the largest, it passes its value to largest and continues the comparison
                }
            }
        }
    }
}
