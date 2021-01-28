using System;
class MainClass{
  public static void Main(string[] args){

    Console.WriteLine("Digite a cidade de origem:");
    string origem = Console.ReadLine();
    Console.WriteLine("Digite a cidade de destino:");
    string destino = Console.ReadLine();
    Console.WriteLine("Digite a distância percorrida em quilômetros:");
    int distancia = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a velocidade média em km/h:");
    int velocidade = int.Parse(Console.ReadLine());

    int horas = distancia/velocidade;
    float minutos = (distancia%velocidade*60)/velocidade;
    Console.WriteLine($"O tempo de viagem estimado entre {origem} e {destino} é de {horas} horas e {minutos} minutos.");

  }
}