using System;
class MainClass{
  public static void Main(string[] args){

    Console.WriteLine("Nota do 1º bimestre:");
    float n1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Nota do 2º bimestre:");
    float n2 = float.Parse(Console.ReadLine());
    Console.WriteLine("Nota do 3º bimestre:");
    float n3 = float.Parse(Console.ReadLine());
    Console.WriteLine("Nota do 4º bimestre:");
    float n4 = float.Parse(Console.ReadLine());

    float media_parcial = (n1*2 + n2*2 + n3*3 + n4*3)/10;
    if (media_parcial >= 6.0){
      Console.WriteLine($"O aluno foi aprovado com média {media_parcial}.");
    } else{
      Console.WriteLine($"O aluno ficou com média {media_parcial} e irá para a prova final.");
      Console.WriteLine("Nota da prova final:");
      float prova_final = float.Parse(Console.ReadLine());
      float media_final = (media_parcial + prova_final)/2;
      if (media_final >= 6.0){
        Console.WriteLine($"O aluno foi aprovado na prova final com média {media_final}.");
      } else{
        Console.WriteLine($"O anulo foi reprovado com média {media_final}.");
      }
    }
  }
}