 using System;

 public class Program {

   public static void Main(string[] args) 
     {
      double n1, n2, MEDIA;
      n1 = Convert.ToDouble(Console.ReadLine());
      n2 = Convert.ToDouble(Console.ReadLine());

      MEDIA=(n1 * 3.5 + n2 * 7.5) / 11;

     Console.WriteLine($"MEDIA = {MEDIA.ToString ("F5")}");
    
     
     Console.ReadKey();
       
     
    }  
 }
