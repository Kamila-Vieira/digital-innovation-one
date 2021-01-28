using System;
using primeiros_passos_dotnet_c_.Exemplos;

namespace primeiros_passos_dotnet_c_
{
  class Program
  {
    static void Main()
    {
      /* AULA 1 */
      int numeroDeVezes = 5;
      for (int i = 1; i <= numeroDeVezes; i++)
      {
        Console.WriteLine($"Bem-vindo ao curso de .NET {i}");
      }
      /* AULA 2 */
      var pilha = new Pilha();
      pilha.Empilha(1);
      pilha.Empilha(10);
      pilha.Empilha(100);
      Console.WriteLine(pilha.Desempilha());
      Console.WriteLine(pilha.Desempilha());
      Console.WriteLine(pilha.Desempilha());
      //Console.WriteLine(pilha.Desempilha());
    }
  }
}
