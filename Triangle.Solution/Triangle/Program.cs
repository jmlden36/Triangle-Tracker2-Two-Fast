using System;
using System.Collections.Generic;
using TriangleStuff;

namespace TriangleTrack
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please input the length of the first side of a triangle");
      int sideA = int.Parse(Console.ReadLine());
      Console.WriteLine("Please input the length of the second side of a triangle");
      int sideB = int.Parse(Console.ReadLine());
      Console.WriteLine("Please input the length of the third side of a triangle");
      int sideC = int.Parse(Console.ReadLine());

      Triangle t1000 = new Triangle(sideA, sideB, sideC);
      if (t1000.isTriangle() == false)
      {
        Console.WriteLine("That is not a triangle, it's a spacestation");        
      }
      else if (t1000.isEquilateral())
      {
        Console.WriteLine("This is an Equilateral Triangle Congratulations!");
      }
      else if (t1000.isIsosceles())
      {
        Console.WriteLine("HOW DARE YOU BRING AN ISOSCELES TRIANGLE INTO THIS HOUSE!");
      }
      else
      {
        Console.WriteLine("This is a scalene triangle, you lose");
      }
    }
  }
}