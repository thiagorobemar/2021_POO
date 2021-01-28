using System;
class MainClass{
  public static void Main(string[] args){

    Console.WriteLine("Digite a dimensão do ambiente em metros no formato largura X comprimento:");
    string[] ambiente = Console.ReadLine().Split('X');
    Console.WriteLine("Digite a dimensão do revestimento em centímetros no formato largura X comprimento:");
    string[] revestimento = Console.ReadLine().Split('X');
    Console.WriteLine("Digite o número de peças por caixa:");
    int pecas_por_caixa = int.Parse(Console.ReadLine());

    double area_ambiente = (double.Parse(ambiente[0])*100) * (double.Parse(ambiente[1])*100);
    double area_revestimento = double.Parse(revestimento[0]) * double.Parse(revestimento[1]);
    double n_pecas = area_ambiente/area_revestimento;
    double n_caixas = n_pecas/pecas_por_caixa;

    Console.WriteLine($"São necessárias {n_caixas:0.0} caixas do revestimento.");

  }
}