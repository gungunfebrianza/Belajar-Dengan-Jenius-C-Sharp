using System;

namespace HelloWorldNamespace
{
  class Hello
  {
    static void Main()
    {
      Console.WriteLine("Hello");
      ActivityEmployee a = new ActivityEmployee("Firefox", 4, 3);
      Console.WriteLine(a.apptitle);
    }
  }

  public class ActivityEmployee
  {
    public string apptitle;
    public float duration;
    public float percentage;
    public ActivityEmployee(string apptitle, float duration, float percentage)
    {
      this.apptitle = apptitle;
      this.duration = duration;
      this.percentage = percentage;
    }
  }

  public class Employee
  {
    private string HWID;
    public string employeeName;
    private List<ActivityEmployee> log;

    public Employee(string employeeName, ActivityEmployee x)
    {
      this.employeeName = employeeName;
    }

  }
}