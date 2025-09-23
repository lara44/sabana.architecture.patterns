
using BridgePattern.Interfaces;

namespace BridgePattern.Platforms
{
    public class PlataformaMovil : INotificacionPlataforma
    {
        public void Mostrar(string mensaje)
        {
            Console.WriteLine($"[Movil] {mensaje}");
        }
    }
}