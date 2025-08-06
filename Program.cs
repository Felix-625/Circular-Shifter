using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Price_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] origArray = new int[10];
            int[] shiftedArray = new int[10];

            // Ask ser to enter a 10-element array 
            Console.WriteLine("Enter 10 integer elements for the original array:");
            for (int i = 0; i < origArray.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                while(!int.TryParse(Console.ReadLine(), out origArray[i]))
                {
                    Console.Write("Invalid input. Please enter an integer: ");
                }
            }
            // Ask user for the number of positions to shift the array
            Console.WriteLine("Enter the number of positions to shift the array (positive for right, negative for left):");
            int k; // Number of positions to shift

            // Check if the user enter a integer
            while (!int.TryParse(Console.ReadLine(), out k))
            {
                Console.Write("Invalid input. Please enter an integer: ");
            }
            k = k % origArray.Length; // Normalize k to the length of the array

            for (int i = 0; i < origArray.Length; i++)
            {
                int newIndex = (i + k + origArray.Length) % origArray.Length; // Calculate new index with wrap-around
                shiftedArray[newIndex] = origArray[i];
            }

            Console.WriteLine("Original Array: " + string.Join(", ", origArray));
            Console.WriteLine("Shifted Array: " + string.Join(", ", shiftedArray));
        }
    }
}
