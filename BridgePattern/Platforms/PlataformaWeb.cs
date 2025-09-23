using BridgePattern.Interfaces;

namespace BridgePattern.Platforms
{
    public class PlataformaWeb : INotificacionPlataforma
    {
        public void Mostrar(string mensaje)
        {
            Console.WriteLine($"[Web] {mensaje}");
        }
    }
}