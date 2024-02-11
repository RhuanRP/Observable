public class LimiteObservador : IObservador
{
  private int limite;
  private string tipoSensor;

  public LimiteObservador(int limite, string tipoSensor)
  {
    this.limite = limite;
    this.tipoSensor = tipoSensor;
  }

  public void Atualizar(int valor)
  {
    if (valor > limite)
    {
      Console.WriteLine($"{tipoSensor} excedeu o limite! Valor atual: {valor}");
    }
  }
}
