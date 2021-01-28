using System;
class MainClass{
  public static void Main(string[] args){

    Console.WriteLine("Digite a placa do veículo:");
    string placa = Console.ReadLine();

    if (placa[6]=='1' || placa[6]=='2'){
      Console.WriteLine("O mês de pagamento do IPVA do veículo é fevereiro.");
    } else{
      if (placa[6]=='3' || placa[6]=='4'){
        Console.WriteLine("O mês de pagamento do IPVA do veículo é março.");
      } else{
        if (placa[6]=='5' || placa[6]=='6'){
          Console.WriteLine("O mês de pagamento do IPVA do veículo é abril.");
        } else{
          if (placa[6]=='7' || placa[6]=='8'){
            Console.WriteLine("O mês de pagamento do IPVA do veículo é maio.");
          } else{
            if (placa[6]=='9' || placa[6]=='0'){
              Console.WriteLine("O mês de pagamento do IPVA do veículo é junho.");
            }
          }
        }
      }
    }
  }
}