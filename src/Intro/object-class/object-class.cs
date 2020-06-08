using System;
class TypeClass
{
  static void Main(string[] args)
  {
    //create object of type object and string
    Object cls1 = new Object();
    System.String cls2 = "Test string";
    // Call Get Type to return the type
    Type type1 = cls1.GetType();
    Type type2 = cls2.GetType();

    // Object class output
    Console.WriteLine(type1.BaseType);
    Console.WriteLine(type1.Name); //Object
    Console.WriteLine(type1.FullName); //System.Object
    Console.WriteLine(type1.Namespace); //System

    // String output
    Console.WriteLine(type2.BaseType); //System.Object
    Console.WriteLine(type2.Name); //Name String
    Console.WriteLine(type2.FullName); //System.String
    Console.WriteLine(type2.Namespace); //System
  }
}