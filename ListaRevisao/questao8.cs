using System;
class MainClass{
  public static void Main(string[] args){

    Console.WriteLine("Digite três valores reais separados por ponto e vírgula:");
    string[] valores = Console.ReadLine().Split(';');
    double soma = double.Parse(valores[0]) + double.Parse(valores[1]) + double.Parse(valores[2]);
    Console.WriteLine($"A soma entre os valores é {soma:0.00}");

  }
}