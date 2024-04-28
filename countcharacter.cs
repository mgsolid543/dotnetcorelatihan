using System;
using System.Text;
using System.Globalization;

class Program
{
 // The Main() function is the first function to be executed in a program
 static void Main()
 {
    // Write the string "Hello World to the standard out
    Console.WriteLine(CountCharacters("Jakarta"));

    static int CountCharacters(String text)
    {
       if (String.IsNullOrEmpty(text))
          return 0;
          int count = 0;
          var enumerator = StringInfo.GetTextElementEnumerator(text);
          while (enumerator.MoveNext())
           ++count;
          return count;
    }

 
 }
}


