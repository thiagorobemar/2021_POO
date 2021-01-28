using System;

class MainClass{
  public static void Main(string[] args){
    Console.WriteLine("Digite o nome do estado:");
    string estado = Console.ReadLine();
    Console.WriteLine("Digite o número de habitantes:");
    int habitantes = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a área do estado em Km²:");
    double area = double.Parse(Console.ReadLine());
    double densidade = habitantes/area;
    Console.WriteLine($"A densidade demográfica do estado {estado} é de {densidade:0.0} hab/Km²");

  }

}