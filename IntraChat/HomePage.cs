using System.Text;
using System.Net;
using System.Net.Sockets;

namespace IntraChat
{
    public partial class HomePage : Form
    {
        Socket socket;
        EndPoint localEndPoint;
        EndPoint remoteEndPoint;

        private static bool DisconneectSocket = false;


        public HomePage()
        {
            InitializeComponent();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.ReuseAddress, true);

            // 
            YourIpTextBox.Text = GetIPaddress();
            FriendsIpAddressTextBox.Text = GetIPaddress();
            Disconnect.Enabled = false;
            Send.Enabled = false;
            MessageTextBox.Enabled = false;
        }

        /// <summary>
        /// Gets the IP address of the device.
        /// </summary>
        /// <returns>IP address.</returns>
        private string GetIPaddress()
        {
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress ip in localIPs)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return string.Empty;
        }

        private void GetUserName(IAsyncResult a)
        {
            try
            {
                MessageBox.Show("SDs");

                int size = socket.EndReceiveFrom(a, ref remoteEndPoint);

                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];

                    receivedData = (byte[])a.AsyncState;

                    ASCIIEncoding encoding = new ASCIIEncoding();
                    string receivedMessage = encoding.GetString(receivedData);

                    //FriendsUserNameTextBox.Text = string.Format("{0}:",receivedMessage);

                }


                // FriendsUserNameTextBox.Text = YourUserNameTextBox.Text;

                Connect.Text = "Connected";
                Connect.Enabled = false;

                byte[] buffer = new byte[8];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(GetUserName), buffer);

            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Connect button clicked.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                // 
                DisconneectSocket = false;




                if (socket.IsBound == false)
                {
                    localEndPoint = new IPEndPoint(IPAddress.Parse(YourIpTextBox.Text), Convert.ToInt32(YourPortTextBox.Text));
                    socket.Bind(localEndPoint);
                }


                if (socket.Connected == false)
                {
                    remoteEndPoint = new IPEndPoint(IPAddress.Parse(FriendsIpAddressTextBox.Text), Convert.ToInt32(FriendsPortTextBox.Text));
                    socket.Connect(remoteEndPoint);
                }


                byte[] buffer = new byte[Constants.MessageBuffer];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(ChatMessage), buffer);


                Connect.Text = "Connected";
                Connect.ForeColor = Color.Green;
                Disconnect.Enabled = true;
                Send.Enabled = true;
                MessageTextBox.Enabled = true;

                //byte[] UserNamebuffer = new byte[80];
                //socket.BeginReceiveFrom(UserNamebuffer, 0, UserNamebuffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(GetUserName), UserNamebuffer);


                //byte[] usename = new byte[80];

                //ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();

                //usename = aSCIIEncoding.GetBytes(YourUserNameTextBox.Text);

                ////socket.Send(usename);
                //socket.SendTo(usename, remoteEndPoint);

                //SetUserName();
                //socket.ReceiveFrom(UserNamebuffer, 0, UserNamebuffer.Length,SocketFlags.None,ref remoteEndPoint);
                //socket.Receive
                //socket.Receive(UserNamebuffer);
                //Connect.BackColor = Color.Green;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Adds messages to chat box.
        /// </summary>
        /// <param name="aResult"></param>
        private void ChatMessage(IAsyncResult aResult)
        {
            try
            {
                int size = socket.EndReceiveFrom(aResult, ref remoteEndPoint);

                // Disconnected singled.
                if (DisconneectSocket == true)
                {
                    socket.EndReceiveFrom(aResult, ref remoteEndPoint);
                    return;
                }

                // Message is not empty.
                if (size > 0)
                {
                    byte[] receivedData = new byte[Constants.MessageBuffer];
                    receivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    string receivedMessage = encoding.GetString(receivedData);
                    ChatBox.Items.Add(string.Format("Friend: {0}", receivedMessage));
                }

                byte[] buffer = new byte[Constants.MessageBuffer];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(ChatMessage), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Send Button clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding aSCIIEncoding = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[Constants.MessageBuffer];

                // Message box is not empty. 
                if (MessageTextBox.Text.Length > 0)
                {
                    msg = aSCIIEncoding.GetBytes(MessageTextBox.Text);
                    socket.Send(msg);
                    ChatBox.Items.Add(string.Format("You: {0}", MessageTextBox.Text));
                    MessageTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Disconnects the  current socket. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Sending disconnect signal.
                DisconneectSocket = true;

                // Changing the UI.
                Disconnect.Enabled = false;
                Send.Enabled = false;
                MessageTextBox.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static string GenerateName(int len)
        {
            Random randomWord = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[randomWord.Next(consonants.Length)].ToUpper();
            Name += vowels[randomWord.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[randomWord.Next(consonants.Length)];
                b++;
                Name += vowels[randomWord.Next(vowels.Length)];
                b++;
            }

            return Name;


        }

        /// <summary>
        /// Menu strip.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.Show();
        }
    }
}