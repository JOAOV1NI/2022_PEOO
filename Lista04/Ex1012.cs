using System; 

public class Program {

  public static void Main(string[] args) {
     string s = Console.ReadLine();
     string[] v = s.Split();
      double a = double.Parse(v[0]);
      double b = double.Parse(v[1]);
      double c = double.Parse(v[2]);
      double triangulo = (a * c) / 2 ;
      double circulo =  3.14159 * Math.Pow(c,2);
      double trapezio = ((a + b) * c) / 2;
      double quadrado = Math.Pow(b,2);
      double retangulo = a * b ;
      Console.WriteLine($"TRIANGULO: {triangulo:0.000}");
      Console.WriteLine($"CIRCULO: {circulo:0.000}");
      Console.WriteLine($"TRAPEZIO: {trapezio:0.000}");
      Console.WriteLine($"QUADRADO: {quadrado:0.000}");
      Console.WriteLine($"RETANGULO: {retangulo:0.000}");
  }
}
