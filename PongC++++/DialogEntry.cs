using SimpleTCP;
using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace PongC____
{
    public partial class DialogEntry : Form
    {
        Color gameArea;
        Color platform;
        Color ball;
        Color score;
        public DialogEntry()
        {
            InitializeComponent();
        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        private void rbtn_server_CheckedChanged(object sender, EventArgs e)
        {
            txt_ip.Enabled = false;
            txt_ip.Text = GetLocalIPAddress();
        }

        private void DialogEntry_Load(object sender, EventArgs e)
        {
            rbtn_server.Checked = true;
            gameArea = Color.Cyan;
            platform = Color.Black;
            ball = Color.Black;
            score = Color.White;
        }

        private void rbtn_join_CheckedChanged(object sender, EventArgs e)
        {
            txt_ip.Enabled = true;
            txt_ip.Text = "";
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (rbtn_join.Checked)
            {
                try
                {
                    SimpleTcpClient client = new SimpleTcpClient().Connect(txt_ip.Text, 8910);
                    Dashboard dash = new Dashboard();
                    dash.startClient(txt_ip.Text);
                    dash.gameAreaColor = gameArea;
                    dash.platformColor = platform;
                    dash.ballColor = ball;
                    dash.scoreColor = score;
                    dash.timeToReceive = int.Parse(numRefreshTime.Value.ToString());
                    this.Hide();
                    dash.ShowDialog();
                    this.Show();
                }
                catch
                {
                    txt_ip.Text = "";
                    MessageBox.Show("Room not found!");
                }
            }
            else
            {
                Dashboard dash = new Dashboard();
                dash.startServer();
                this.Hide();
                dash.gameAreaColor = gameArea;
                dash.platformColor = platform;
                dash.ballColor = ball;
                dash.scoreColor = score;
                dash.ShowDialog();
                this.Show();
            }
        }

        private void btn_gameAreaColor_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if(clr.ShowDialog() == DialogResult.OK)
            {
                gameArea = clr.Color;
            }
        }

        private void btn_platformColor_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                platform = clr.Color;
            }
        }

        private void btn_ball_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                ball = clr.Color;
            }
        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                score = clr.Color;
            }
        }
    }
}
