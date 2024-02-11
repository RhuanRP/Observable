public abstract class Sensor : IObservavel
{
  protected List<IObservador> observadores = new List<IObservador>();

  public void RegistrarObservador(IObservador observador)
  {
    observadores.Add(observador);
  }

  public void RemoverObservador(IObservador observador)
  {
    observadores.Remove(observador);
  }

  public void NotificarObservadores()
  {
    int valor = ObterValor();
    foreach (var observador in observadores)
    {
      observador.Atualizar(valor);
    }
  }
  protected abstract int ObterValor();
}