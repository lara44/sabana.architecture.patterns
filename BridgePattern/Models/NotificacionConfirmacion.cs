
using BridgePattern.Interfaces;

namespace BridgePattern.Models
{
    public class NotificacionConfirmacion : Notificacion
    {
        public NotificacionConfirmacion(INotificacionPlataforma plataforma) : base(plataforma) { }
        public override void Enviar(string mensaje)
        {
            plataforma.Mostrar($"Confirmacion: {mensaje}");
        }
    }
}