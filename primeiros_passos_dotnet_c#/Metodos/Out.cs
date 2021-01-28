namespace primeiros_passos_dotnet_c_.Metodos
{
  public class Out
  {
    public static void Dividir(int x, int y, out int resultado, out int resto)
    {
      resultado = x / y;
      resto = x % y;
    }

    public static void Dividir()
    {
      Dividir(10, 3, out int resultado, out int resto);
      System.Console.WriteLine("{0} {1}", resultado, resto);  // Escreve "3 1"
    }
  }
}