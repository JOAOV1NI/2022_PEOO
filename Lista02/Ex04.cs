using System;

 public class Program {

   public static void Main(string[] args)  {
    Console.WriteLine("Digite a base e a altura do retângulo");
    double BaseRet, AlturaRet, Area, Perimetro, Diagonal;
    BaseRet = double.Parse(Console.ReadLine()); 
    AlturaRet = double.Parse(Console.ReadLine());
    Area = BaseRet * AlturaRet;
    Perimetro = BaseRet * 2 + AlturaRet * 2;
    Diagonal = Math.Sqrt(Math.Pow(BaseRet, 2) + Math.Pow(AlturaRet, 2));
    Console.WriteLine("Àrea = {0:0.00}", Area);
    Console.WriteLine("Perímetro = {0:0.00}", Perimetro);
    Console.WriteLine("Diagonal = {0:0.00}", Diagonal);
      
