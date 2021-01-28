using System;

class MainClass{
  public static void Main(string[] args){

    Console.WriteLine("Digite a operação no formato op1+op2:");
    string[] operacao = Console.ReadLine().Split('+');
    int soma = int.Parse(operacao[0]) + int.Parse(operacao[1]);
    Console.WriteLine($"Soma = {soma}");

  }

}