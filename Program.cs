class Program
{
  static void Main(string[] args)
  {
    TemperaturaSensor sensorTemperatura = new TemperaturaSensor();
    UmidadeSensor sensorUmidade = new UmidadeSensor();
    LuminosidadeSensor sensorLuminosidade = new LuminosidadeSensor();

    LimiteObservador observadorTemperatura = new LimiteObservador(72, "Temperatura");
    LimiteObservador observadorUmidade = new LimiteObservador(50, "Umidade");
    LimiteObservador observadorLuminosidade = new LimiteObservador(800, "Luminosidade");

    sensorTemperatura.RegistrarObservador(observadorTemperatura);
    sensorUmidade.RegistrarObservador(observadorUmidade);
    sensorLuminosidade.RegistrarObservador(observadorLuminosidade);
    sensorTemperatura.NotificarObservadores();
    sensorUmidade.NotificarObservadores();
    sensorLuminosidade.NotificarObservadores();
  }
}