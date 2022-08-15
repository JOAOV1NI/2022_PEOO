using System;
 class Program{
  public static void Main(string[] args){
    Circulo circ1 = new Circulo();
    circ1.raio = Double.Parse(Console.ReadLine()) ;
    Console.WriteLine(circ1.CalcArea());
  }
}

class Circulo {
  public double raio;      // Atributo
  public double  CalcArea(){   // Métodos
    return Math.PI * raio * raio;
   }
   double Circunferencia(){
    return 2 * Math.PI * raio;
  }
}
