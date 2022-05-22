using System; 

public class Program {

  public static void Main(string[] args) {
  double b, h, a;
    Console.WriteLine("digite a base do triângulo");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine("digite a base do triangulo");
    h = double.Parse(Console.ReadLine());
    a= b+h / 2;
     Console.WriteLine($"Área = {a:0.00}");
  }
}
