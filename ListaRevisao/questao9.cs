using System;
class MainClass{
  public static void Main(string[] args){

    Console.WriteLine("Digite uma frase com três palavras:");
    string[] frase = Console.ReadLine().Split(' ');
    Console.WriteLine(frase[0][0].ToString() + frase[1][0].ToString() + frase[2][0].ToString());

  }
}