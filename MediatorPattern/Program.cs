



using MediatorPattern.Interfaces;
using MediatorPattern.Models;

IChat chatVIP = new Chat();

IUser andres = new User("Andres");
IUser luis = new User("Luis");
IUser astrid = new User("Astrid");
IUser efrain = new User("Efrain");
IUser robinson = new User("Robinson");
IUser oscar = new User("Oscar");

chatVIP.LogInChat(andres);
chatVIP.LogInChat(luis);
chatVIP.LogInChat(astrid);
chatVIP.LogInChat(efrain);
chatVIP.LogInChat(robinson);
chatVIP.LogInChat(oscar);

andres.Send("Hola a todos como estan");
luis.Send("buen dia, recuerden que tenemos el trabajo de arquitectura");
astrid.Send("Es verdad los 3 escenarios de patrones");
efrain.Send("yo me tomo el primer escenario");
robinson.Send("yo me tomo el segundo escenario");
oscar.Send("yo me tomo el tercer escenario");