using ChatWebSocket.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatWebSocket.Controller
{
    internal class Controller1
    {
        Form1 f;
        CancellationTokenSource cts;
        ClientWebSocket socket;


        public Controller1()
        {
            f = new Form1();            
            InitListeners();
            LoadData();
            Application.Run(f);
        }


        void LoadData()
        {
            f.textBoxServer.Text = "ws://localhost:6666/ws/";
        }
        private async Task Rebre(ClientWebSocket socket)
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
                               f.listBoxChat.Items.Add(rcvMsg);
                               //Console.WriteLine(rcvMsg);
                           }
                       }
                  
            
        }

        void InitListeners()
        {
           
            f.buttonConectar.Click += ButtonConectar_Click;
            f.buttonEnviar.Click += ButtonEnviar_Click;
        }

        private void ButtonEnviar_Click(object sender, EventArgs e)
        {
            enviar(socket);
      
        }

        public void enviar(ClientWebSocket socket)
        {
            string missatge = f.textBoxEnviar.Text;
            f.listBoxChat.Items.Add(missatge);
            if (missatge == "Adeu")
            {
                cts.Cancel();
                return;
            }
            byte[] sendBytes = Encoding.UTF8.GetBytes(missatge);
            var sendBuffer = new ArraySegment<byte>(sendBytes);
            socket.SendAsync(sendBuffer, WebSocketMessageType.Text, endOfMessage: true, cancellationToken: cts.Token);
            f.textBoxEnviar.Text = "";
        }

        private async void ButtonConectar_Click(object sender, EventArgs e)
        {
            f.listBoxChat.Text = "Conectant...\n";

            cts = new CancellationTokenSource();
            socket = new ClientWebSocket();

            String server = f.textBoxServer.Text.ToString();
            String usuari = f.textBoxUsuari.Text.ToString();
            //new Controller1().Start().Wait();           


            //"ws://localhost:6666/ws/"
            string wsUri = server + usuari;
            await socket.ConnectAsync(new Uri(wsUri), cts.Token);
            f.listBoxChat.Items.Add(socket.State.ToString());
            //Console.WriteLine(socket.State);

                      
            await Rebre(socket);
            

            
        }

       
    }
}
