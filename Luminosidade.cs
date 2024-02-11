public class LuminosidadeSensor : Sensor
{
  protected override int ObterValor()
  {
    Random random = new Random();
    return random.Next(0, 1000);
  }
}