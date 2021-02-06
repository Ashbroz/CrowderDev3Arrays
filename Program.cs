// Author: Ashton Crowder
// Date: 2/5/2021

using System;

namespace CrowderDev3Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Populating Array of 25
            int[] arr = new int[25];
            // Count Starting from 1
            int j = 1;
            // Count from 1 to 25
            for (int i = 0; i < 25; i++)
            {
                arr[i] = j;
                j++;
            }
            
            for (int i = 0; i < 25; i++)
            {
                // display array using writeline
                Console.WriteLine("Element Value = ");
                Console.WriteLine(arr[i]);
            }
        }
    }
}
