using System.Net.WebSockets;
using System.Net;
using System.Text;
using System.Net.Sockets;
using Microsoft.AspNetCore.DataProtection;

Console.Title = "Server";
var builder = WebApplication.CreateBuilder();
builder.WebHost.UseUrls("http://localhost:6666");
var app = builder.Build();
app.UseWebSockets();
app.Map("/ws/{nom}", async (string nom, HttpContext context) =>
{
    Console.Write("Hola " + nom + "\n");

    if (context.WebSockets.IsWebSocketRequest)
    {
        using (var webSocket = await context.WebSockets.AcceptWebSocketAsync())
        {
            while (true)
            {
                Echo(webSocket);
            }
        }
    }
    else
    {
        context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
    }

   
});

async Task Echo(WebSocket webSocket)
{
    var rcvBytes = new byte[256];
    var cts = new CancellationTokenSource();
    var rcvBuffer = new ArraySegment<byte>(rcvBytes);
    await webSocket.ReceiveAsync(rcvBuffer, cts.Token);
    await webSocket.SendAsync(rcvBuffer, WebSocketMessageType.Text, true, CancellationToken.None);


}
await app.RunAsync();
