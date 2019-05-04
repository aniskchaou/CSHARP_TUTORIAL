using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tutorial.Basic
{
    class Programm
    {
        static void Main(string[] args)
        {
            // Creating an array  
            int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };
            // Creating an empty array  
            int[] arr2 = new int[6];
            // Displaying length of array  
            Console.WriteLine("length of first array: " + arr.Length);
            // Sorting array  
            Array.Sort(arr);
            Console.Write("First array elements: ");
            // Displaying sorted array  
            PrintArray(arr);
            // Finding index of an array element  
            Console.WriteLine("\nIndex position of 25 is " + Array.IndexOf(arr, 25));
            // Coping first array to empty array  
            Array.Copy(arr, arr2, arr.Length);
            Console.Write("Second array elements: ");
            // Displaying second array  
            PrintArray(arr2);
            Array.Reverse(arr);
            Console.Write("\nFirst Array elements in reverse order: ");
            PrintArray(arr);
        }
        // User defined method for iterating array elements  
        static void PrintArray(int[] arr)
        {
            foreach (Object elem in arr)
            {
                Console.Write(elem + " ");
            }
        }
    }

    //AsReadOnly<T>(T[])	
    //It returns a read-only wrapper for the specified array.

    //BinarySearch(Array,Int32,Int32,Object)	
    //It is used to search a range of elements in a one-dimensional sorted array for a value.

    //BinarySearch(Array, Object)  
    //It is used to search an entire one-dimensional sorted array for a specific element.

    //Clear(Array,Int32,Int32)	
    //It is used to set a range of elements in an array to the default value.

    //Clone()	
    //It is used to create a shallow copy of the Array.

    //Copy(Array,Array,Int32)	
    //It is used to copy elements of an array into another array by specifying starting index.

    //CopyTo(Array, Int32) 
    //It copies all the elements of the current one-dimensional array to the specified one-dimensional array starting at the specified destination array index

    //CreateInstance(Type, Int32)  
    //It is used to create a one-dimensional Array of the specified Type and length.

    //Empty<T>()  
    //It is used to return an empty array.

    //Finalize()	
    //It is used to free resources and perform cleanup operations.

    //Find<T>(T[], Predicate<T>)   
    //It is used to search for an element that matches the conditions defined by the specified predicate.

    // IndexOf(Array,Object)	
    //It is used to search for the specified object and returns the index of its first occurrence in a one-dimensional array.

    // Initialize()    
    //It is used to initialize every element of the value-type Array by calling the default constructor of the value type.

    // Reverse(Array)	
    //It is used to reverse the sequence of the elements in the entire one-dimensional Array.

    // Sort(Array) 
    //It is used to sort the elements in an entire one-dimensional Array.

    // ToString()  
    //It is used to return a string that represents the current object.
}
