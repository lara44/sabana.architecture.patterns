using BridgePattern.Interfaces;
namespace BridgePattern.Models
{
    public abstract class Notificacion
    {
        protected INotificacionPlataforma plataforma;
        protected Notificacion(INotificacionPlataforma plataforma)
        {
            this.plataforma = plataforma;
        }
        public abstract void Enviar(string mensaje);
    }
}