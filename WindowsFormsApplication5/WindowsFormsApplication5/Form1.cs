using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiscordRpcDemo;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("752662108583493673", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("752662108583493673", ref this.handlers, true, null);
            this.presence.details = textBox1.Text;
            this.presence.state = "Emir Karapelit coder deneme v2 ";
            this.presence.largeImageKey = "wpkapatm";
            this.presence.largeImageText = "Lavinia :)";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

    }
}
