using System;

namespace JMM_ECE2310_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initiate Driver Program
            //Instantiate RightTriangle Object Array
            const int size = 2;
            RightTriangle[] rt = new RightTriangle[size];

            //Instantiate individual RightTriangle Objects
            rt[0] = new RightTriangle(6, 8);
            rt[1] = new RightTriangle(5, 15);

            //Instantiate Square Object Array
            Square[] s = new Square[size];

            //Instantiate individual Square Objects
            s[0] = new Square(8);
            s[1] = new Square(7);

            double[] a = new double[2 * size]; //array to store the areas calculated
            double[] p = new double[2 * size]; //array to store the perimeters calculated
            
                //Printing out the Objects in the specific order
            for (int i = 0; i < 2 * size; i++)
            {
                if (i % 2 == 0)
                {//i/2 for the inner indexing for rt is to balance out the fact that the for loop goes out of bounds of the object array


                     a[i] = rt[i / 2].cal_area(); 
                    //we are both storing the area value into an array and setting the value of data member area
                     p[i] = rt[i / 2].cal_perimeter(); 
                    //we are both storing the perimeter value into an array and setting the value of data member perimeter 
                    Console.WriteLine("#{0} object: {1}", i + 1, rt[i / 2]); 
                    //Printing of each object with pertinent information
                }
                else
                {//the area and perimeter array however, have enough room to store each value as it is printed by the for loop
                     a[i] = s[i / 2].cal_area(); 
                     //we are both storing the area value into an array and setting the value of data member area
                     p[i] = s[i / 2].cal_perimeter(); 
                     //we are both storing the perimeter value into an array and setting the value of data member perimeter
                Console.WriteLine("#{0} object: {1}", (i + 1), s[(i / 2)]);
                    //printing of each object with pertinent information
                }
            }
            //Printing out the stored values of the area array and perimeter array
            Console.WriteLine("\nThese are the stored values for area:");

            for (int i = 0; i < 2 * size; i++)
                Console.Write(" {0} ", a[i]);

            Console.WriteLine("\nThese are the stored values for perimeter:");

            for (int i = 0; i < 2 * size; i++)
                Console.Write(" {0} ", p[i]);

            Console.WriteLine("\n");

            //Now we will identify the largest Area and its index
            double largestArea = 0;
            int indexLargestA = 0;
            Utilities.FindLargest(ref indexLargestA, ref largestArea, ref a);
            
            //Console.WriteLine("\nThe largest area is: {0} at index {1}", largestArea, indexLargestA); Preliminary print to check if the indexing and value match
            Console.WriteLine("#{0} object has the largest area of\t{1}u", indexLargestA + 1, largestArea);
            Console.WriteLine("\n");
            
            //Now we will identify the largest Perimeter and its index
            double largestPerimeter = 0;
            int indexLargestP = 0;
            Utilities.FindLargest(ref indexLargestP, ref largestPerimeter, ref p);
            
            //Console.WriteLine("\nThe largest perimeter is: {0} at index {1}", largestPerimeter, indexLargestP); Preliminary print to check if the indexing and valuematch
        
            Console.WriteLine("#{0} object has the largest perimeter of {1}u\n", indexLargestP + 1, largestPerimeter);
        }

    }
}
