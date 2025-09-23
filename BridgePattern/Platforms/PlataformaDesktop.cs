
using BridgePattern.Interfaces;

namespace BridgePattern.Platforms
{
    public class PlataformaDesktop : INotificacionPlataforma
    {
        public void Mostrar(string mensaje)
        {
            Console.WriteLine($"[Desktop] {mensaje}");
        }
    }
}