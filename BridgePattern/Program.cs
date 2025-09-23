
using BridgePattern.Interfaces;
using BridgePattern.Models;
using BridgePattern.Platforms;

INotificacionPlataforma web = new PlataformaWeb();
INotificacionPlataforma movil = new PlataformaMovil();
INotificacionPlataforma desktop = new PlataformaDesktop();

Notificacion notificacionMensajeWeb = new NotificacionMensaje(web);
notificacionMensajeWeb.Enviar("Tienes un nuevo mensaje");

Notificacion notificacionAlertaMovil = new NotificacionAlerta(movil);
notificacionAlertaMovil.Enviar("Batería baja");

Notificacion notificacionAdvertenciaDesktop = new NotificacionAdvertencia(desktop);
notificacionAdvertenciaDesktop.Enviar("Error Windows");

Notificacion notificacionConfirmacionDesktop = new NotificacionConfirmacion(desktop);
notificacionConfirmacionDesktop.Enviar("Registro Eliminado");

Console.ReadLine();
