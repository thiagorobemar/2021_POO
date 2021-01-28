using System;
class MainClass{
  public static void Main(string[] args){

    Console.WriteLine("Digite três valores separados por vírgulas:");
    string[] numeros = Console.ReadLine().Split(',');
    int produto = int.Parse(numeros[0]) * int.Parse(numeros[1]) * int.Parse(numeros[2]);
    Console.WriteLine($"O produto entre os valores é {produto}");

  }
}