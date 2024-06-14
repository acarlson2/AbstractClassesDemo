using System;

public class Motorcycle : Vehicle
{
    public Motorcycle()
    {

    }

    public override void DriveAbstract()
    {
        Console.WriteLine("This is the DriveAbstract method of the Motorcycle class");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("This is the DriveVirtual method of the Motorcycle class");
    }

    public bool HasSideCart {get; set;}
}