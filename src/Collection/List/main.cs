using System;
using System.Collections.Generic;
using System.Linq;
class ListApp
{
  static void Main(string[] args)
  {
    List<string> dinosaurs = new List<string>();

    Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);

    dinosaurs.Add("Tyrannosaurus");
    dinosaurs.Add("Amargasaurus");
    dinosaurs.Add("Mamenchisaurus");
    dinosaurs.Add("Deinonychus");
    dinosaurs.Add("Compsognathus");
    Console.WriteLine();
    foreach (string dinosaur in dinosaurs)
    {
      Console.WriteLine(dinosaur);
    }

    Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
    Console.WriteLine("Count: {0}", dinosaurs.Count);

    dinosaurs.TrimExcess();
    Console.WriteLine("\nTrimExcess()");
    Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);
    Console.WriteLine("Count: {0}", dinosaurs.Count);
  }
}