 using System;

 public class Program {

   public static void Main(string[] args)
   {
     double n1, n2, med;
     
      Console.WriteLine("Digite a primeira nota: ");
      n1 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Digite a segunda nota: ");
      n2 = Convert.ToDouble(Console.ReadLine());
     
      med = (n1 + n2) / 2;
     
      {
        Console.WriteLine("sua media é " + med);
        Console.ReadLine();
      }  

      
    }  
 }
