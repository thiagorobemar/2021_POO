using System;
class MainClass{
  
  public static double Frete(double massa, double distancia){
    double frete = 0.01 * massa * distancia;
    return frete;
  }
  
  public static void Main(string[] args){
    Console.WriteLine("Informe o peso da carga em quilos:");
    double massa = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a distância do frete em quilometros:");
    double distancia = double.Parse(Console.ReadLine());

    Console.WriteLine($"O valor do frete é R${Frete(massa, distancia):0.00}");
  }
}