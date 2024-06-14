using System;

public class Car : Vehicle
{
    public Car()
    {

    }

    public override void DriveAbstract()
    {
        Console.WriteLine("This is the Drive Abstract method of the Car class");
    }

    public bool HasTrunk {get; set;}
}