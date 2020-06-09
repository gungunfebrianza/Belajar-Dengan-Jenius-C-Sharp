using System;
using System.Collections.Generic;
using System.Linq;
class StackApp
{
  static void Main(string[] args)
  {
    Stack<string> numbers = new Stack<string>();
    numbers.Push("one");
    numbers.Push("two");
    numbers.Push("three");
    numbers.Push("four");
    numbers.Push("five");

    // A stack can be enumerated without disturbing its contents.
    foreach (string number in numbers)
    {
      Console.WriteLine(number);
    }

    Console.WriteLine("\nPopping '{0}'", numbers.Pop());
    Console.WriteLine("Peek at next item to destack: {0}",
        numbers.Peek());
    Console.WriteLine("Popping '{0}'", numbers.Pop());
  }
}