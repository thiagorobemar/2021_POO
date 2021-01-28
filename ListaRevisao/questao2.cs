using System;

class MainClass{
  public static void Main(string[] args){

    Console.WriteLine("Digite o valor gasto com combustível em reais:");
    double valor_gasto = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor do litro do combustível em reais:");
    double valor_litro = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a distância percorrida em quilômetros:");
    double distancia = double.Parse(Console.ReadLine());

    double consumo = distancia/(valor_gasto/valor_litro);
    double gasto_km = valor_gasto/distancia;

    Console.WriteLine($"O consumo médio é de {consumo:0.00} Km por litro");
    Console.WriteLine($"O gasto por Km percorrido é R${gasto_km:0.00}");

  }
}