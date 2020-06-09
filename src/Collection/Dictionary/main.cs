using System;
using System.Collections.Generic;
using System.Linq;
class DictionaryApp
{
  static void Main(string[] args)
  {
    Dictionary<string, string> openWith =
    new Dictionary<string, string>();

    // Add some elements to the dictionary. There are no
    // duplicate keys, but some of the values are duplicates.
    openWith.Add("txt", "notepad.exe");
    openWith.Add("bmp", "paint.exe");
    openWith.Add("dib", "paint.exe");
    openWith.Add("rtf", "wordpad.exe");
    
    foreach (KeyValuePair<string, string> kvp in openWith)
    {
      Console.WriteLine("Key = {0}, Value = {1}",
          kvp.Key, kvp.Value);
    }
  }
}