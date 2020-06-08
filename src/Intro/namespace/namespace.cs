using System;
using MyOtherNamespace;
// Caller namespace
namespace HelloWorldNamespace
{
  class Hello
  {
    static void Main()
    {
      MyOtherClass cls = new MyOtherClass();
      cls.Hello();
    }
  }
}
// Called namespace
namespace MyOtherNamespace
{
  class MyOtherClass
  {
    public void Hello()
    {
      Console.WriteLine("Hello, C# World!");
    }
  }
}