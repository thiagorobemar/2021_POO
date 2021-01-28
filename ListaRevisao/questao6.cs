using System;
class MainClass{
  public static void Main(string[] args){

    Console.WriteLine("Digite a largura do ambiente em metros:");
    double largura_ambiente = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o comprimento do ambiente em metros:");
    double comprimento_ambiente = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a largura do revestimento em centímetros:");
    double largura_revestimento = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o comprimento do revestimento em centímetros:");
    double comprimento_revestimento = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o número de peças por caixa:");
    int pecas_por_caixa = int.Parse(Console.ReadLine());
    
    double area_ambiente = (comprimento_ambiente*100) * (largura_ambiente*100);
    double area_revestimento = comprimento_revestimento * largura_revestimento;
    double n_pecas = area_ambiente/area_revestimento;
    double n_caixas = n_pecas/pecas_por_caixa;

    Console.WriteLine($"São necessárias {n_caixas:0.0} caixas do revestimento.");


  }
}