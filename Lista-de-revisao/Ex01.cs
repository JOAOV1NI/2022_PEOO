using System;

class program{
  public static void Main(){
    Console.WriteLine("informe uma data no formato dd/mm/aaaa");
    string data = Console.ReadLine();
    Console.WriteLine(data);
    string [] v = data.Split("/");
    Console.WriteLine(v[0]);
    Console.WriteLine(v[1]);
    Console.WriteLine(v[2]);
    int ano = int.Parse(v[2]) + 1;
    Console.WriteLine(ano);
    String novadata = $"v[0]}/{v[1]}/{ano}";
    Console.WriteLine(novadata);
    
  }
}