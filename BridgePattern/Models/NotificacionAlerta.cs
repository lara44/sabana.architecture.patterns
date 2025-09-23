
using BridgePattern.Interfaces;

namespace BridgePattern.Models
{
    public class NotificacionAlerta : Notificacion
    {
        public NotificacionAlerta(INotificacionPlataforma plataforma) : base(plataforma) { }
        public override void Enviar(string mensaje)
        {
            plataforma.Mostrar($"Alerta: {mensaje}");
        }
    }
}