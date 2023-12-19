using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebSocConsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start().Wait();
        }

        public async Task Start()
        {
            Console.Title = "Client";

            Console.Write("Connectant....\n");
            var cts = new CancellationTokenSource();
            var socket = new ClientWebSocket();

            Console.Write("Nom d'usuari\n");
            String? nom = Console.ReadLine();

            string wsUri = "ws://localhost:6666/ws/" + nom;
            await socket.ConnectAsync(new Uri(wsUri), cts.Token);
            Console.WriteLine(socket.State);



            var buffer = new byte[256];
            if (socket.State == WebSocketState.Open)
            {
                await Task.Factory.StartNew(
                    async () =>
                    {
                        var rcvBytes = new byte[256];
                        var rcvBuffer = new ArraySegment<byte>(rcvBytes);
                        while (true)
                        {
                            WebSocketReceiveResult rcvResult = await socket.ReceiveAsync(rcvBuffer, cts.Token);
                            if (rcvResult.MessageType == WebSocketMessageType.Close)
                            {
                                await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, null, CancellationToken.None);
                            }
                            else
                            {
                                byte[] msgBytes = rcvBuffer.Skip(rcvBuffer.Offset).Take(rcvResult.Count).ToArray();
                                string rcvMsg = Encoding.UTF8.GetString(msgBytes);
                                Console.WriteLine(rcvMsg);
                            }
                        }
                    }, cts.Token, TaskCreationOptions.LongRunning, TaskScheduler.Default);

                while (true)
                {
                    string? missatge = Console.ReadLine();
                    if (missatge == "Adeu")
                    {
                        cts.Cancel();
                        return;
                    }
                    byte[] sendBytes = Encoding.UTF8.GetBytes(missatge);
                    var sendBuffer = new ArraySegment<byte>(sendBytes);
                    await socket.SendAsync(sendBuffer, WebSocketMessageType.Text, endOfMessage: true, cancellationToken: cts.Token);
                }
            }
        }
    }
}
