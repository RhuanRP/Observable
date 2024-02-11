public interface IObservavel
{
  void RegistrarObservador(IObservador observador);
  void RemoverObservador(IObservador observador);
  void NotificarObservadores();
}