/*Escriba un programa que pida una cantidad de horas, y que convierta dicha cantidad
de tiempo en minutos y segundos.*/ 

using System;

namespace Conversion
{
  class Program
  {
    public static void Main()
    {
      // Ask the user for the amount of hours
      Console.Write("Enter the amount of hours: ");
      int hours = int.Parse(Console.ReadLine());

      // Convert the hours to minutes and seconds
      int minutes = hours * 60;
      int seconds = minutes * 60;

      // Print the results
      Console.WriteLine("{0} hours are equivalent to {1} minutes or {2} seconds.", hours, minutes, seconds);
    }
  }

}