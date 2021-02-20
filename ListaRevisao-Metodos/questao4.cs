using System;
class MainClass{
  
  public static double VolumeLitros(double h, double l, double p){
    double volume = (h * l * p) * 1000;
    return volume;
  }
  
  public static void Main(string[] args){
    Console.WriteLine("Digite a altura da caixa d'água em metros:");
    double h = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a largura da caixa d'água em metros:");
    double l = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a profundidade da caixa d'água em metros:");
    double p = double.Parse(Console.ReadLine());

    Console.WriteLine($"O volume da caixa d'água é {VolumeLitros(h,l,p):0.00} litros.");
  }
}