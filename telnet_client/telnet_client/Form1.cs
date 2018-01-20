using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using SimpleTCP;
using System.Threading;



namespace telnet_client
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader sr , sr1;
        public StreamWriter sw , sw1;
        public string recv;
        public string tosend;


        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIp = Dns.GetHostAddresses(Dns.GetHostName());

            /* Stores IP Addresses returned by 
           GetHostAddresses using HostName in Byte format in localIp array
           */
            foreach (IPAddress addr in localIp)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    continue;
                }

            }

        }
        
        private void startConnection_Click(object sender, EventArgs e) //Start Server Button
        {
            TcpListener list = null;
            try
            {
                list = new TcpListener(IPAddress.Any, int.Parse(textBox2.Text));
                    /*
                     * Creates Instance of the TcpListener class that listens for incoming 
                     * connection attempts on the 
                     * specified local IP address and port number
                     */
                    list.Start();
                    /* starts listening for incoming connection requests */
                    MessageBox.Show("Server Started on IP : " + textBox1.Text + " Port Number : " + textBox2.Text + "  !! Listening For Clients !!");
                    toSender.AppendText("Server Started !! \n");
                    this.fromClient.ReadOnly = true;

                
                
                    client = list.AcceptTcpClient();

                
                    /*
                    * TcpListener instance accepts the pending connection 
                    * and assign it as client
                    */


                    sr = new StreamReader(client.GetStream());
                    sr1 = new StreamReader(client.GetStream());
                    /*
                     * sr takes the type of stream to receive data that 
                     * is used by client to send data 
                     * GetStream() return the NetworkStream used by client to send or receive data
                     */

                    sw = new StreamWriter(client.GetStream());
                    sw1 = new StreamWriter(client.GetStream());
                    /*
                     * sw takes the type of stream to send data that
                     * is used by client to receive data 
                     */
                    sw.AutoFlush = true;
                    sw1.AutoFlush = true;
                    /*
                     * To clear the stream writer buffer                 
                     */
                    bw2.RunWorkerAsync();
                    /*
                     * Allows Multiple Application to work in background 
                     */
                    bw1.WorkerSupportsCancellation = true;
                    /*
                     * Allows backgroundWorker to cancel asynchronously 
                     */
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server Starting Error with exception : " + ex.ToString());
            }

        }

        private void clientConnect_Click(object sender, EventArgs e) // connect to server button 
        {
            client = new TcpClient();
            /* 
             * Creating new TcpClient Instance 
             */
            IPEndPoint ipend = new IPEndPoint(IPAddress.Parse(textBox3.Text), int.Parse(textBox4.Text));
            /*
             * Creates an instance of IpEndPoint which holds the IP address and 
             * port number needed by application to connect to the server 
             */
            try
            {
                client.Connect(ipend);
                /*
                 * Connecting to server using the above port number and ip address 
                 */
                if (client.Connected)
                {
                    toSender.AppendText("Connected To Server " + "\n");
                    sr = new StreamReader(client.GetStream());
                    sw = new StreamWriter(client.GetStream());
                    sr1 = new StreamReader(client.GetStream());
                    sw1 = new StreamWriter(client.GetStream());
                    sw.AutoFlush = true;
                    sw1.AutoFlush = true;

                    bw2.RunWorkerAsync();
                    bw1.WorkerSupportsCancellation = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed with exception : " + ex.ToString());
            }

        }

        private void send_Click(object sender, EventArgs e) // Send Button 
        {
            try
            {
                if (fromClient.Text != "")
                {
                    tosend = fromClient.Text;
                    bw1.RunWorkerAsync();
                }
                fromClient.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't  Send The Data ");
            }
        }
        private void bw1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                sw.WriteLine(tosend);
                this.fromClient.Invoke(new MethodInvoker(delegate ()
                { toSender.AppendText("Client Sending : " + tosend + "\n"); }));
                string r = tosend;
                r.ToCharArray();
                int i;
                for (i = 0; i < r.Length; i++)
                {
                    this.fromClient.Invoke(new MethodInvoker(delegate ()
                    { toSender.AppendText("Server Sent : " + r[i] + "\n"); }));
                    
                }
                sw.Flush();
            }
            else
            {
                MessageBox.Show("Sending Failed !!! ");
            }
           
            bw1.CancelAsync();

        }

    private void bw2_DoWork(object sender, DoWorkEventArgs e)
    {
        while (client.Connected)
        {
            try
            {
                recv = sr.ReadLine();
                this.toSender.Invoke(new MethodInvoker(delegate ()
                { toSender.AppendText("Client Sent : " + recv + "\n"); }));
                /*
                 * To Receive the data sent by client in background
                 */
                recv.ToCharArray();
               
                    int i = 0;

                for (i = 0; i < recv.Length; i++)
                {
                    this.toSender.Invoke(new MethodInvoker(delegate ()
                    { toSender.AppendText("Server Sending : " + recv[i] + "\n"); }));
                        /*
                         * Invokes bacgkroundWorker2 textbox to write data into it 
                         */
        
                 }
                recv = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server Sending Fail with exception : " + ex.ToString());
            }

            /*
             * Requests cancellation of pending Operations
             */
        }
    }
    }
}
