public class UmidadeSensor : Sensor
{
  protected override int ObterValor()
  {
    Random random = new Random();
    return random.Next(0, 65);
  }
}