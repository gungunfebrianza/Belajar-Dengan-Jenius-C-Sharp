using System;
using System.Collections.Generic;
using System.Linq;
class QueueApp
{
  static void Main(string[] args)
  {
    // Creating a Queue 
    Queue myQueue = new Queue();

    // Inserting the elements into the Queue 
    myQueue.Enqueue(5);
    myQueue.Enqueue(10);
    myQueue.Enqueue(15);
    myQueue.Enqueue(20);
    myQueue.Enqueue(25);

    // Checking whether the element is 
    // present in the Queue or not 
    // The function returns True if the 
    // element is present in the Queue, else 
    // returns False 
    Console.WriteLine(myQueue.Contains(7));
  }
}