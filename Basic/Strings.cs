using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In C#, you can use strings as array of characters, However, more common practice is to use the string keyword
//to declare a string variable. The string keyword is an alias for the System.String class.
namespace c_sharp_tutorial
{
    class Strings
    {
        static void Main(string[] args)
        {
            //from string literal and string concatenation
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            //by using string constructor { 'H', 'e', 'l', 'l','o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            //methods returning string { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            //formatting method to convert a value
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);


            //Comparing Strings
            string str1 = "This is test";
            string str2 = "This is text";

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }
            Console.ReadKey();

            //string contains string
            string str = "This is test";

            if (str.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }
            Console.ReadKey();

            //getting a substring
            string str = "Last night I dreamt of San Pedro";
            Console.WriteLine(str);
            string substr = str.Substring(23);
            Console.WriteLine(substr);

            //joining string
            string[] starray = new string[]{"Down the way nights are dark",
            "And the sun shines daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"};

            string str = String.Join("\n", starray);
            Console.WriteLine(str);


        }

        //output
        //Full Name: RowanAtkinson
        //Greetings: Hello
        //Message: Hello From Tutorials Point
        //Message: Message sent at 5:58 PM on Wednesday, October 10, 2012
    }
}
/*
    Clone()
    It is used to return a reference to this instance of String.

    Compare(String, String)
    It is used to compares two specified String objects. It returns an integer that indicates their relative position in the sort order.

    CompareOrdinal(String, String)	
    It is used to compare two specified String objects by evaluating the numeric values of the corresponding Char objects in each string..

    CompareTo(String)
    It is used to compare this instance with a specified String object. It indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified string.

    Concat(String, String)
    It is used to concatenate two specified instances of String.

    Contains(String)
    It is used to return a value indicating whether a specified substring occurs within this string.

    Copy(String)
    It is used to create a new instance of String with the same value as a specified String.

    CopyTo(Int32, Char[], Int32, Int32)
    It is used to copy a specified number of characters from a specified position in this instance to a specified position in an array of Unicode characters.

    EndsWith(String)	
    It is used to check that the end of this string instance matches the specified string.

    Equals(String, String)
    It is used to determine that two specified String objects have the same value.

    Format(String, Object)
    It is used to replace one or more format items in a specified string with the string representation of a specified object.

    GetEnumerator()
    It is used to retrieve an object that can iterate through the individual characters in this string.

    GetHashCode()	
    It returns the hash code for this string.
    
    GetType()
    It is used to get the Type of the current instance.

    GetTypeCode()  
    It is used to return the TypeCode for class String.

    IndexOf(String) 
    It is used to report the zero-based index of the first occurrence of the specified string in this instance.

    Insert(Int32, String)
    It is used to return a new string in which a specified string is inserted at a specified index position.
    
    Intern(String) 
    It is used to retrieve the system's reference to the specified String.

    IsInterned(String) 
    It is used to retrieve a reference to a specified String.

    IsNormalized()
    It is used to indicate that this string is in Unicode normalization form C.

    IsNullOrEmpty(String)
    It is used to indicate that the specified string is null or an Empty string.

    IsNullOrWhiteSpace(String)	
    It is used to indicate whether a specified string is null, empty, or consists only of white-space characters.

    Join(String, String [])
    It is used to concatenate all the elements of a string array, using the specified separator between each element.
 
    LastIndexOf(Char)	
    It is used to report the zero-based index position of the last occurrence of a specified character within String.
 
    LastIndexOfAny(Char[])
    It is used to report the zero-based index position of the last occurrence in this instance of one or more characters specified in a Unicode array.
     
    Normalize()	
    It is used to return a new string whose textual value is the same as this string, but whose binary representation is in Unicode normalization form C.

    PadLeft(Int32)	
     It is used to return a new string that right-aligns the characters in this instance by padding them with spaces on the left.

    PadRight(Int32)
    It is used to return a new string that left-aligns the characters in this string by padding them with spaces on the right.
    
    Remove(Int32)
    It is used to return a new string in which all the characters in the current instance, beginning at a specified position and continuing through the last position, have been deleted.
    
    Replace(String, String)
    It is used to return a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.

    Split(Char[])  
    It is used to split a string into substrings that are based on the characters in an array.
     
   StartsWith(String)
    It is used to check whether the beginning of this string instance matches the specified string.

    Substring(Int32)
    It is used to retrieve a substring from this instance. The substring starts at a specified character position and continues to the end of the string.
    
    ToCharArray()	
    It is used to copy the characters in this instance to a Unicode character array.
    
    ToLower()	
    It is used to convert String into lowercase.

    ToLowerInvariant()
    It is used to return convert String into lowercase using the casing rules of the invariant culture.

    ToString() 
    It is used to return instance of String.

    ToUpper()
    It is used to convert String into uppercase.

    Trim()
    It is used to remove all leading and trailing white-space characters from the current String object.

    TrimEnd(Char[])
    It Is used to remove all trailing occurrences of a set of characters specified in an array from the current String object.

    TrimStart(Char[])  
    It is used to remove all leading occurrences of a set of characters specified in an array from the current String object.
*/
