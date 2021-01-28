using System;
using primeiros_passos_dotnet_c_.Exemplos;

namespace primeiros_passos_dotnet_c_
{
  class Program
  {
    static void Main(string[] args)
    {
      /* AULA 1 */
      Console.WriteLine("Aula 1");
      int numeroDeVezes = 5;
      for (int i = 1; i <= numeroDeVezes; i++)
      {
        Console.WriteLine($"Bem-vindo ao curso de .NET {i}");
      }
      /* AULA 2 */
      Console.WriteLine("Aula 2");
      var pilha = new Pilha();
      pilha.Empilha(1);
      pilha.Empilha(numeroDeVezes);
      pilha.Empilha(10);
      pilha.Empilha(100);
      Console.WriteLine(pilha.Desempilha());
      Console.WriteLine(pilha.Desempilha());
      Console.WriteLine(pilha.Desempilha());
      Console.WriteLine(pilha.Desempilha());
      /* AULA 3 */
      Console.WriteLine("Aula 3");
      int? numeroNullable = null; //nullable
      int numeroNaoNullable = 0;
      Console.WriteLine(numeroNullable);
      Console.WriteLine(numeroNaoNullable);
      /* AULA 4 */
      var instrucoes = new Instrucoes();
      //instrucoes.Declaracoes();
      //instrucoes.InstrucaoIf(args);
      //instrucoes.InstrucaoSwitch(args);
      //instrucoes.InstrucaoWhile(args);
      //instrucoes.InstrucaoDo(args);
      //instrucoes.InstrucaoFor(args);
      //instrucoes.InstrucaoForeach(args);
      //instrucoes.InstrucaoBreak(args);
      //instrucoes.InstrucaoContinue(args);
      //instrucoes.InstrucaoReturn(args);
      //instrucoes.InstrucoesTryCatchFinallyThrow(args);
      instrucoes.InstrucaoUsing(args);
    }
  }
}
