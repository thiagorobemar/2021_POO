using System;

class MainClass{
  public static void Main (string[] args){
    Console.WriteLine("Digite o intervalo de tempo no formato \"HH:MM:SS\"");
    string [] tempo = Console.ReadLine().Split(':');
    long hora = long.Parse(tempo[0]);
    long minuto = long.Parse(tempo[1]);
    long segundo = long.Parse(tempo[2]);
    long distancia = 300000*(segundo+minuto*60+hora*3600);
    Console.WriteLine($"A luz percorreu {distancia} km nesse intervalo");
  }
}