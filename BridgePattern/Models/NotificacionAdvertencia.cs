
using BridgePattern.Interfaces;

namespace BridgePattern.Models
{
    public class NotificacionAdvertencia : Notificacion
    {
        public NotificacionAdvertencia(INotificacionPlataforma plataforma) : base(plataforma) { }

        public override void Enviar(string mensaje)
        {
            plataforma.Mostrar($"Advertencia: {mensaje}");
        }
    }
}