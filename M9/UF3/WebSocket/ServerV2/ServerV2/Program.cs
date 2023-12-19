using System.Net.WebSockets;
using System.Net;
using System.Text;

Console.Title = "Server";
var builder = WebApplication.CreateBuilder();
builder.WebHost.UseUrls("http://localhost:6666");
var app = builder.Build();
app.UseWebSockets();
app.Map("/ws/{nom}", async (string nom, HttpContext context) =>
{
    Console.Write("Hola "+nom+"\n");
    

    if (context.WebSockets.IsWebSocketRequest)
    {
        using (var webSocket = await context.WebSockets.AcceptWebSocketAsync())
        {
            await webSocket.SendAsync(Encoding.UTF8.GetBytes($"Hola "+nom), WebSocketMessageType.Text, true, CancellationToken.None);

            while (true)
            {
                await webSocket.SendAsync(Encoding.UTF8.GetBytes($"Test - {DateTime.Now}"), WebSocketMessageType.Text, true, CancellationToken.None);
                await Task.Delay(1000);
            }
        }
    }
    else
    {
        context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
    }
});
await app.RunAsync();