using System;
class MainClass{
  public static double Diagonal(double b, double h){
    double d = Math.Sqrt(Math.Pow(b,2) + Math.Pow(h,2));
    return d;
  }
  public static void Main(string[] args){
    Console.WriteLine("Digite a base do triângulo:");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a altura do triângulo:");
    double h = double.Parse(Console.ReadLine());
    Console.WriteLine($"A diagonal do retângulo é {Diagonal(b,h):0.00}");
  }
}