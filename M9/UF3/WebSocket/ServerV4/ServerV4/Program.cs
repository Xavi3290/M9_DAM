using System.Net.WebSockets;
using System.Net;
using System.Text;
using System.Net.Sockets;
using Microsoft.AspNetCore.DataProtection;
using ServerV4;
using System.Linq;

Console.Title = "Server";
var builder = WebApplication.CreateBuilder();
builder.WebHost.UseUrls("http://localhost:6666");
var app = builder.Build();
app.UseWebSockets();
List<Usuari> usuList = new List<Usuari>();

app.Map("/ws/{nom}", async (string nom, HttpContext context) =>
{
    

    if (context.WebSockets.IsWebSocketRequest)
    {
        

        using (var webSocket = await context.WebSockets.AcceptWebSocketAsync())
        {
            Usuari usu = new Usuari(nom, webSocket);
            usuList.Add(usu);

            var cts = new CancellationTokenSource();    

            while (true)
            {
                var rcvBytes = new byte[256];
                var rcvBuffer = new ArraySegment<byte>(rcvBytes);

                WebSocketReceiveResult rcvResult = await usu.ws.ReceiveAsync( rcvBuffer, cts.Token);  //mensaje recibido

                byte[] msgBytes = rcvBuffer.Skip(rcvBuffer.Offset).Take(rcvResult.Count).ToArray();   //lo combierte en bytes          
                String missatge = Encoding.UTF8.GetString(msgBytes);                    // lo paso al mensaje

                missatge = usu.nom + ": " + missatge;
                byte[] missatgeBytes = Encoding.UTF8.GetBytes(missatge);        // lo convierto en bytes
                var missatgeBuffer = new ArraySegment<byte>(missatgeBytes);

                foreach (Usuari u in usuList){      // en un foreach para que envie a todos
                    if(u.ws != webSocket)  // para que el que escribe no lea su mensaje
                    {
                        await u.ws.SendAsync(missatgeBuffer, WebSocketMessageType.Text, true, CancellationToken.None);   // enviar el mensaje
                    }                                     
                }

                
            }
        }
    }
    else
    {
        context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
    }


});
await app.RunAsync();

