   using System;

 public class Program {

   public static void Main(string[] args) 
   {
      double pi, raio,volume;
      pi = 3.14159;
      raio = Convert.ToDouble(Console.ReadLine());
      volume = (4.00 / 3) * pi * Math.Pow(raio, 3);
     
      Console.WriteLine("VOLUME = {0}", volume.ToString("F3"));

      Console.ReadKey();  
     
    }  
 }
