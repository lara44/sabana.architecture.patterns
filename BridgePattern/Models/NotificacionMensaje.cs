using BridgePattern.Interfaces;

namespace BridgePattern.Models
{
    public class NotificacionMensaje : Notificacion
    {
        public NotificacionMensaje(INotificacionPlataforma plataforma) : base(plataforma) { }
        public override void Enviar(string mensaje)
        {
            plataforma.Mostrar($"Mensaje: {mensaje}");
        }
    }
}