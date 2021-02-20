using System;
class MainClass{
  
  public static double AreaCirculo(double raio){
    double area = Math.PI * Math.Pow(raio,2);
    return area;
  }

  public static void Main(string[] args){
    Console.WriteLine("Digite o valor do raio do círculo:");
    double n = double.Parse(Console.ReadLine());   
    Console.WriteLine($"Área = {AreaCirculo(n):0.00}");
  }  
}