using System;
class MainClass{
  
  public static double VolumeEsfera(double r){
    double volume = (4/3) * Math.PI * Math.Pow(r,3);
    return volume;
  }
  
  public static void Main(string[] args){
    Console.WriteLine("Digite o raio da esfera:");
    double r = double.Parse(Console.ReadLine());
    Console.WriteLine($"O volume da esfera é {VolumeEsfera(r):0.00}");
  }
}