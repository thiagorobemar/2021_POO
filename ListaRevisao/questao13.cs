using System;
class MainClass{
  public static void Main(string[] args){

    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string[] data = Console.ReadLine().Split('/');
    int dia = int.Parse(data[0]);
    int mes = int.Parse(data[1]);
    int ano = int.Parse(data[2]);

    if (dia<1 || dia>31 || mes<1 || mes>31 || ano<1901 || ano>2099 || ){
      Console.WriteLine("Data inválida.");
    } else{
      Console.WriteLine("Data válida.");
    }
  }
}