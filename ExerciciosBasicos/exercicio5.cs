using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a base e a altura do retângulo");
    double b = int.Parse(Console.ReadLine());
    double h = int.Parse(Console.ReadLine());
    double area = b*h;
    double per = b*2+h*2;
    double diag = Math.Sqrt(b*b+h*h);
    Console.WriteLine($"Área = {area:0.00} - Perímetro = {per:0.00} - Diagonal = {diag:0.00}"); 
  }
}