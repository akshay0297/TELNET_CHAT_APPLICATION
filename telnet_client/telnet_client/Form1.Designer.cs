namespace telnet_client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startConnection = new System.Windows.Forms.Button();
            this.clientConnect = new System.Windows.Forms.Button();
            this.toSender = new System.Windows.Forms.TextBox();
            this.fromClient = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ips = new System.Windows.Forms.Label();
            this.ports = new System.Windows.Forms.Label();
            this.ipc = new System.Windows.Forms.Label();
            this.portc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bw1 = new System.ComponentModel.BackgroundWorker();
            this.bw2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // startConnection
            // 
            this.startConnection.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startConnection.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.startConnection.Location = new System.Drawing.Point(590, 45);
            this.startConnection.Name = "startConnection";
            this.startConnection.Size = new System.Drawing.Size(199, 36);
            this.startConnection.TabIndex = 0;
            this.startConnection.Text = "Start Server";
            this.startConnection.UseVisualStyleBackColor = false;
            this.startConnection.Click += new System.EventHandler(this.startConnection_Click);
            // 
            // clientConnect
            // 
            this.clientConnect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clientConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientConnect.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.clientConnect.Location = new System.Drawing.Point(590, 140);
            this.clientConnect.Name = "clientConnect";
            this.clientConnect.Size = new System.Drawing.Size(199, 34);
            this.clientConnect.TabIndex = 1;
            this.clientConnect.Text = "Connect To Server";
            this.clientConnect.UseVisualStyleBackColor = false;
            this.clientConnect.Click += new System.EventHandler(this.clientConnect_Click);
            // 
            // toSender
            // 
            this.toSender.Location = new System.Drawing.Point(40, 226);
            this.toSender.Multiline = true;
            this.toSender.Name = "toSender";
            this.toSender.Size = new System.Drawing.Size(766, 147);
            this.toSender.TabIndex = 2;
            // 
            // fromClient
            // 
            this.fromClient.Location = new System.Drawing.Point(40, 413);
            this.fromClient.Multiline = true;
            this.fromClient.Name = "fromClient";
            this.fromClient.Size = new System.Drawing.Size(637, 40);
            this.fromClient.TabIndex = 4;
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.send.Location = new System.Drawing.Point(709, 413);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(124, 40);
            this.send.TabIndex = 5;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(405, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(405, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // ips
            // 
            this.ips.AutoSize = true;
            this.ips.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ips.Location = new System.Drawing.Point(65, 59);
            this.ips.Name = "ips";
            this.ips.Size = new System.Drawing.Size(22, 16);
            this.ips.TabIndex = 10;
            this.ips.Text = "IP";
            // 
            // ports
            // 
            this.ports.AutoSize = true;
            this.ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ports.Location = new System.Drawing.Point(336, 55);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(36, 16);
            this.ports.TabIndex = 11;
            this.ports.Text = "Port";
            // 
            // ipc
            // 
            this.ipc.AutoSize = true;
            this.ipc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipc.Location = new System.Drawing.Point(65, 144);
            this.ipc.Name = "ipc";
            this.ipc.Size = new System.Drawing.Size(22, 16);
            this.ipc.TabIndex = 12;
            this.ipc.Text = "IP";
            // 
            // portc
            // 
            this.portc.AutoSize = true;
            this.portc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portc.Location = new System.Drawing.Point(336, 141);
            this.portc.Name = "portc";
            this.portc.Size = new System.Drawing.Size(36, 16);
            this.portc.TabIndex = 13;
            this.portc.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Client";
            // 
            // bw1
            // 
            this.bw1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw1_DoWork);
            // 
            // bw2
            // 
            this.bw2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 485);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.portc);
            this.Controls.Add(this.ipc);
            this.Controls.Add(this.ports);
            this.Controls.Add(this.ips);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.fromClient);
            this.Controls.Add(this.toSender);
            this.Controls.Add(this.clientConnect);
            this.Controls.Add(this.startConnection);
            this.Name = "Form1";
            this.Text = "Telnet_Demo_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startConnection;
        private System.Windows.Forms.Button clientConnect;
        private System.Windows.Forms.TextBox toSender;
        private System.Windows.Forms.TextBox fromClient;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label ips;
        private System.Windows.Forms.Label ports;
        private System.Windows.Forms.Label ipc;
        private System.Windows.Forms.Label portc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker bw1;
        private System.ComponentModel.BackgroundWorker bw2;
    }
}

