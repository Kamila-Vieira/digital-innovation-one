namespace primeiros_passos_dotnet_c_.Heranca
{
  public class Ponto
  {
    public int x, y;
    private int distancia;

    public Ponto(int x, int y)
    {
      this.x = x;
      this.y = y;
    }

    protected void CalcularDistancia(int distancia)
    {
      //Faz alguma coisa...
      this.distancia = distancia;
      CalcularDistancia2();
    }

    private void CalcularDistancia2()
    {
      //Faz alguma coisa...
    }

    public virtual void CalcularDistancia3()
    {
      //Faz alguma coisa...
    }
  }
}