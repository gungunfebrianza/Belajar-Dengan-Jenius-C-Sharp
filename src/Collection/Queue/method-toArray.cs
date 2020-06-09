using System;
using System.Collections.Generic;
using System.Linq;
class QueueApp
{
  static void Main(string[] args)
  {
    // Creating a Queue  
    Queue<string> myQueue = new Queue<string>();

    // Inserting the elements into the Queue 
    myQueue.Enqueue("Geeks");
    myQueue.Enqueue("Geeks Classes");
    myQueue.Enqueue("Noida");
    myQueue.Enqueue("Data Structures");
    myQueue.Enqueue("GeeksforGeeks");

    // Converting the Queue 
    // into object array 
    Object[] arr = myQueue.ToArray();

    // Displaying the elements in array 
    foreach (Object obj in arr)
    {
      Console.WriteLine(obj);
    }
  }
}