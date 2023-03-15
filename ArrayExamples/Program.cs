/* ArrayExamples
 * 
 * To demonstrate the use of arrays and lists
 * 
 * Revision History:
 *     Tony Theo...,  2023.03.15:  Created
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayStuff();

            Console.ReadLine();
        }

        static void ArrayStuff()
        {
            int sum = 0;
            int temp;
            int[] numbers = new int[5];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            // 1. Display all the values in the array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // 2. Add 1 to each value in array and display
            //
            // Sample Output:
            // 2 3 4 5 6 

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]++;
                Console.Write(numbers[i] + " ");
            }

            // 3. Sum all the values in the array and display 
            //    Use a foreach loop
            //
            // Sample Output:
            // The sum is 20
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            Console.WriteLine($"The sum is {sum}");

            // 4. Perform the following on the array and display
            //    
            //    - add 5 to the element at index 1
            //    - multiple the element at index 2 by element 
            //      at index 4, and place result back at index 2
            //    - subtract the element at index 1 from element 
            //      at index 0 and place result in at index 0
            //    - swap the elements at index 3 and index 4
            //    - output with a foreach loop
            //
            // Sample Output
            // -6 8 24 6 5
            numbers[1] = numbers[1] + 5;   //numbers[1] += 5;
            numbers[2] = numbers[2] * numbers[4];
            numbers[0] = numbers[0] - numbers[1];
            temp = numbers[3];
            numbers[3] = numbers[4];
            numbers[4] = temp;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
