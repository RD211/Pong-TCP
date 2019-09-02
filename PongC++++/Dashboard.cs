using SimpleTCP;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace PongC____
{
    public partial class Dashboard : Form
    {
        Bitmap bmp;
        Graphics g;
        Rectangle Player;
        Rectangle Enemy;
        Rectangle Ball;
        bool a = false;
        bool d = false;
        bool timerThreadSwitch = true;
        int ballDirection;
        int scorePlayer = 0;
        int scoreEnemy = 0;
        bool inPosession = false;
        bool playerHasBall = false;
        public SimpleTcpClient client;
        public SimpleTcpServer server;
        public int width = 600;
        public int height = 600;
        public int platformSize = 150;
        public int platformHeight = 2;
        public int ballSize = 10;
        public Color gameAreaColor;
        public Color platformColor;
        public Color ballColor;
        public Color scoreColor;
        public int timeToReceive = 3000;
        bool shoot = false;
        string enemyName = "";
        public Dashboard()
        {
            InitializeComponent();
        }
        private void updateDirectionIfHit()
        {
            if (Ball.X >= width-ballSize)
            {
                if (ballDirection == 3)
                    ballDirection = 2;
                if (ballDirection == 0)
                    ballDirection = 1;
            }
            if (Ball.X <= 1)
            {
                if (ballDirection == 1)
                    ballDirection = 0;
                if (ballDirection == 2)
                    ballDirection = 3;
            }
            if (Ball.Y >= Player.Y - ballSize && Ball.X >= Player.X && Ball.X <= Player.X + platformSize+5)
            {
                if (ballDirection == 3)
                    ballDirection = 0;
                if (ballDirection == 2)
                    ballDirection = 1;
            }
            if (Ball.Y <= Enemy.Y && Ball.X >= Enemy.X && Ball.X <= Enemy.X + platformSize+5)
            {
                if (ballDirection == 0)
                    ballDirection = 3;
                if (ballDirection == 1)
                    ballDirection = 2;
            }
            if (Ball.Y>= width - ballSize)
            {
                Ball.X = Player.X + 75;
                Ball.Y = 530;
                ballDirection = 0;
                scoreEnemy++;
                inPosession = true;
                playerHasBall = true;
            }
            if (Ball.Y <= 1)
            {
                Ball.X = Enemy.X+75;
                Ball.Y = 60;
                scorePlayer++;
                ballDirection = 3;
                inPosession = true;
                playerHasBall = false;
            }
        }
        private void drawGame()
        {
            bmp = new Bitmap(width, height);
            g = Graphics.FromImage(bmp);
            g.FillRegion(new SolidBrush(gameAreaColor), new Region(new Rectangle(0, 0, width, height)));
            Brush brsh = new SolidBrush(platformColor);
            g.FillRectangle(brsh, Enemy);
            updateDirectionIfHit();
            g.FillRectangle(brsh, Player);
            if (!inPosession) {
                if (ballDirection == 1 || ballDirection == 2)
                    Ball.X -= 2;
                else
                    Ball.X += 2;
                if (ballDirection == 0 || ballDirection == 1)
                    Ball.Y -= 2;
                else
                    Ball.Y += 2;
            }
            updateDirectionIfHit();
            if (!inPosession)
            {
                if (ballDirection == 1 || ballDirection == 2)
                    Ball.X -= 2;
                else
                    Ball.X += 2;
                if (ballDirection == 0 || ballDirection == 1)
                    Ball.Y -= 2;
                else
                    Ball.Y += 2;
            }
            else
            {
                if (playerHasBall)
                {
                    Ball.X = Player.X + 75;
                    Ball.Y = 530;
                }
                else
                {
                    Ball.X = Enemy.X + 75;
                    Ball.Y = 60;
                }
            }
            g.DrawString(enemyName, new Font(FontFamily.GenericSansSerif, 10), new SolidBrush(scoreColor), Enemy.X, Enemy.Y-20);
            g.DrawString(scoreEnemy+"\n"+scorePlayer, new Font(FontFamily.GenericSansSerif, 40), new SolidBrush(scoreColor), 560, 200);

            g.FillEllipse(new SolidBrush(ballColor), Ball);
            try
            {
                pBox_game.Image = bmp;
            }
            catch
            {

            }
            if(scoreEnemy==10)
            {
                MessageBox.Show("You lost!");
                this.Close();
            }
            if(scorePlayer == 10)
            {
                MessageBox.Show("You won!");
                this.Close();
            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            Player = new Rectangle(260, 550, 150, 2);
            Enemy = new Rectangle(260, 50, 150, 2);
            Ball = new Rectangle(300, 200, 10, 10);
            ballDirection = 3;
            inPosession = true;
            drawGame();
            Thread t = new Thread(timerThread);
            t.Start();
        }
        private void launchBall()
        {
            if (playerHasBall)
            {
                shoot = true;
                inPosession = false;
                ballDirection = 0;
            }
        }
        private void Dashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                a = true;
            if (e.KeyCode == Keys.D)
                d = true;
            if (e.KeyCode == Keys.Space)
            {
                Thread launch = new Thread(launchBall);
                launch.Start();
            }
        }

        private void Dashboard_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                a = false;
            if (e.KeyCode == Keys.D)
                d = false;
        }
        private void updatePlayerPos()
        {
            if (a)
            {
                if (Player.X != 0)
                {
                    Player.X -= 10;
                }
            }
            else if (d)
            {
                if (Player.X != 450)
                {
                    Player.X += 10;
                }
            }
        }
        private void timerThread()
        {
            while (timerThreadSwitch)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                updatePlayerPos();
                drawGame();
                GC.Collect();
                stopwatch.Stop();
                long elapsed_time = stopwatch.ElapsedMilliseconds;
                if (elapsed_time < 30)
                    System.Threading.Thread.Sleep((int)(30 - elapsed_time));
            }
        }
        private void gameControlsTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                var reply = client.WriteLineAndGetReply(Player.X + ";" + shoot + ";" + Environment.UserName + ";", TimeSpan.FromMilliseconds(timeToReceive));
                string replyMessage = reply.MessageString;
                string[] splitReply = replyMessage.Split(';');
                Enemy.X = int.Parse(splitReply[0]);
                if (inPosession && !playerHasBall)
                {
                    if (bool.Parse(splitReply[1]))
                    {
                        inPosession = false;
                    }
                }
                enemyName = splitReply[2];
                shoot = false;
            }
            catch
            {
                this.Close();
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerThreadSwitch = false;
            try
            {
                server.Stop();
            }
            catch
            {

            }
            try
            {
                client.Disconnect();
            }
            catch
            {

            }
        }
        public void startClient(string ip)
        {
            client = new SimpleTcpClient().Connect(ip, 8910);
            gameSendTimer.Start();
            playerHasBall = true;
            ballDirection = 0;
        }
        private static string GetLocalIPAddress()
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
        public void startServer()
        {
            server = new SimpleTcpServer().Start(8910);
            server.DataReceived += Server_DataReceived;
            lbl_server.Text = "Server running on : "+GetLocalIPAddress();
            lbl_server.BackColor = gameAreaColor;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            e.ReplyLine(Player.X + ";" + shoot + ";" + Environment.UserName +";");
            string received = e.MessageString;
            string[] splitReceived = received.Split(';');
            Enemy.X = int.Parse(splitReceived[0]);
            if (inPosession && !playerHasBall)
            {
                if (bool.Parse(splitReceived[1]))
                {
                    inPosession = false;
                }
            }
            enemyName = splitReceived[2];
            shoot = false;
        }

    }
}
