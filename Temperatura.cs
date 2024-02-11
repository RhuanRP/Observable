public class TemperaturaSensor : Sensor
{
  protected override int ObterValor()
  {
    Random random = new Random();
    return random.Next(-20, 90); // 
  }
}