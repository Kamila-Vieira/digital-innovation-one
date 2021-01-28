using System;
using primeiros_passos_dotnet_c_.Exemplos;
using primeiros_passos_dotnet_c_.Heranca;
using primeiros_passos_dotnet_c_.Metodos;
using primeiros_passos_dotnet_c_.Revisao;

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
      Console.WriteLine("Aula 4");
      Instrucoes instrucoes = new Instrucoes();
      Instrucoes.Declaracoes();
      Instrucoes.InstrucaoIf(args);
      //instrucoes.InstrucaoSwitch(args);
      //instrucoes.InstrucaoWhile(args);
      //instrucoes.InstrucaoDo(args);
      //instrucoes.InstrucaoFor(args);
      //instrucoes.InstrucaoForeach(args);
      //instrucoes.InstrucaoBreak(args);
      //instrucoes.InstrucaoContinue(args);
      //instrucoes.InstrucaoReturn(args);
      //instrucoes.InstrucoesTryCatchFinallyThrow(args);
      //instrucoes.InstrucaoUsing(args);
      /* AULA 5 */
      Console.WriteLine("Aula 5");
      Ponto p1 = new Ponto(10, 20);
      Ponto3D p2 = new Ponto3D(20, 30, 40);
      Ponto3D.Calcular();
      p1.CalcularDistancia3();
      int yp1 = p1.y;
      int xp1 = p1.x;
      int zp2 = p2.z;
      Out.Dividir(10, 3, out int resultado, out int resto);
      Console.WriteLine(resultado);
      Console.WriteLine(resto);
      Aluno[] alunos = new Aluno[5];
      var indiceAluno = 0;

      string opcaoUsuario = ObterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            Console.WriteLine();
            Console.WriteLine("Informe o nome do aluno: ");
            var aluno = new Aluno();
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a nota do aluno: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
              aluno.Nota = nota;
            }
            else
            {
              throw new ArgumentException("O valor da nota deve ser decimal");
            }

            alunos[indiceAluno] = aluno;
            indiceAluno++;

            break;
          case "2":
            Console.WriteLine();
            Console.WriteLine("Listagem de alunos:");
            foreach (var a in alunos)
            {
              if (!string.IsNullOrEmpty(a.Nome))
              {
                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
              }
            }
            break;
          case "3":
            decimal notaTotal = 0;
            var nrAlunos = 0;

            for (int i = 0; i < alunos.Length; i++)
            {
              if (!string.IsNullOrEmpty(alunos[i].Nome))
              {
                notaTotal += alunos[i].Nota;
                nrAlunos++;
              }
            }
            var mediaGeral = notaTotal / nrAlunos;
            Conceito conceitoGeral;

            if (mediaGeral < 2)
            {
              conceitoGeral = Conceito.E;
            }
            else if (mediaGeral < 4)
            {
              conceitoGeral = Conceito.D;
            }
            else if (mediaGeral < 6)
            {
              conceitoGeral = Conceito.C;
            }
            else if (mediaGeral < 8)
            {
              conceitoGeral = Conceito.B;
            }
            else
            {
              conceitoGeral = Conceito.A;
            }
            Console.WriteLine();
            Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}");
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }
        opcaoUsuario = ObterOpcaoUsuario();
      }
    }

    private static string ObterOpcaoUsuario()
    {
      Console.WriteLine();
      Console.WriteLine("Informe a opção desejada: ");
      Console.WriteLine("1 - Inserir novo aluno");
      Console.WriteLine("2 - Listar alunos");
      Console.WriteLine("3 - Calcular média geral");
      Console.WriteLine("X - Sair");
      Console.WriteLine();
      string opcaoUsuario = Console.ReadLine();
      return opcaoUsuario;
    }

  }
}
