using System;

class Program
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Vamos Calcular a média do aluno");
    double avaliacao1,avaliacao2,media;
    String C = "S";

    do
    {
      Console.WriteLine("Digite a avaliação 1: ");
      avaliacao1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a avaliação 2: ");
      avaliacao2 = double.Parse(Console.ReadLine());

          media = (avaliacao1 + avaliacao2)/2;
      
      Console.WriteLine("A media é: " + media);
      
    if (media > 6)
    {
      Console.WriteLine("Aluno Aprovado!");

    }
    else 
    {
      Console.WriteLine("Aluno reprovado");
      }

      Console.WriteLine("Deseja Digitar outra nota?: (S/N)");
      C = Console.ReadLine();
      
      }while (C.Equals("S",StringComparison.CurrentCultureIgnoreCase));
    }
  }