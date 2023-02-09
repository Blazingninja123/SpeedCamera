using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please Enter a Speed Limit: ");
        var speedLimit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter the Speed of a Car: ");
        var carSpeed = Convert.ToInt32(Console.ReadLine());

        if (carSpeed < speedLimit)
            Console.WriteLine("Ok");
        else
        {
            const int kmPerDemeritPoint = 5;
            var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
            if (demeritPoints > 12)
                Console.WriteLine("License Suspended");
            else
                Console.WriteLine("Demerit points: " + demeritPoints);


        }
    }
}