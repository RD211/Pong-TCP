namespace PongC____
{
    partial class DialogEntry
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
            this.rbtn_server = new System.Windows.Forms.RadioButton();
            this.rbtn_join = new System.Windows.Forms.RadioButton();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_gameAreaColor = new System.Windows.Forms.Button();
            this.btn_platformColor = new System.Windows.Forms.Button();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.btn_score = new System.Windows.Forms.Button();
            this.btn_ball = new System.Windows.Forms.Button();
            this.numRefreshTime = new System.Windows.Forms.NumericUpDown();
            this.lbl_refresh = new System.Windows.Forms.Label();
            this.gBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshTime)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_server
            // 
            this.rbtn_server.AutoSize = true;
            this.rbtn_server.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_server.Location = new System.Drawing.Point(13, 13);
            this.rbtn_server.Name = "rbtn_server";
            this.rbtn_server.Size = new System.Drawing.Size(139, 24);
            this.rbtn_server.TabIndex = 0;
            this.rbtn_server.TabStop = true;
            this.rbtn_server.Text = "Host a room";
            this.rbtn_server.UseVisualStyleBackColor = true;
            this.rbtn_server.CheckedChanged += new System.EventHandler(this.rbtn_server_CheckedChanged);
            // 
            // rbtn_join
            // 
            this.rbtn_join.AutoSize = true;
            this.rbtn_join.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_join.Location = new System.Drawing.Point(158, 13);
            this.rbtn_join.Name = "rbtn_join";
            this.rbtn_join.Size = new System.Drawing.Size(133, 24);
            this.rbtn_join.TabIndex = 1;
            this.rbtn_join.TabStop = true;
            this.rbtn_join.Text = "Join a room";
            this.rbtn_join.UseVisualStyleBackColor = true;
            this.rbtn_join.CheckedChanged += new System.EventHandler(this.rbtn_join_CheckedChanged);
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ip.Location = new System.Drawing.Point(10, 54);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(19, 15);
            this.lbl_ip.TabIndex = 2;
            this.lbl_ip.Text = "IP";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(38, 52);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(253, 20);
            this.txt_ip.TabIndex = 3;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(13, 195);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(278, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_gameAreaColor
            // 
            this.btn_gameAreaColor.Location = new System.Drawing.Point(6, 19);
            this.btn_gameAreaColor.Name = "btn_gameAreaColor";
            this.btn_gameAreaColor.Size = new System.Drawing.Size(124, 23);
            this.btn_gameAreaColor.TabIndex = 5;
            this.btn_gameAreaColor.Text = "Game area color";
            this.btn_gameAreaColor.UseVisualStyleBackColor = true;
            this.btn_gameAreaColor.Click += new System.EventHandler(this.btn_gameAreaColor_Click);
            // 
            // btn_platformColor
            // 
            this.btn_platformColor.Location = new System.Drawing.Point(136, 19);
            this.btn_platformColor.Name = "btn_platformColor";
            this.btn_platformColor.Size = new System.Drawing.Size(133, 23);
            this.btn_platformColor.TabIndex = 6;
            this.btn_platformColor.Text = "Platform color";
            this.btn_platformColor.UseVisualStyleBackColor = true;
            this.btn_platformColor.Click += new System.EventHandler(this.btn_platformColor_Click);
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.btn_ball);
            this.gBox.Controls.Add(this.btn_score);
            this.gBox.Controls.Add(this.btn_gameAreaColor);
            this.gBox.Controls.Add(this.btn_platformColor);
            this.gBox.Location = new System.Drawing.Point(13, 111);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(278, 78);
            this.gBox.TabIndex = 7;
            this.gBox.TabStop = false;
            this.gBox.Text = "Color Settings";
            // 
            // btn_score
            // 
            this.btn_score.Location = new System.Drawing.Point(136, 48);
            this.btn_score.Name = "btn_score";
            this.btn_score.Size = new System.Drawing.Size(133, 23);
            this.btn_score.TabIndex = 7;
            this.btn_score.Text = "Score color";
            this.btn_score.UseVisualStyleBackColor = true;
            this.btn_score.Click += new System.EventHandler(this.btn_score_Click);
            // 
            // btn_ball
            // 
            this.btn_ball.Location = new System.Drawing.Point(6, 48);
            this.btn_ball.Name = "btn_ball";
            this.btn_ball.Size = new System.Drawing.Size(124, 23);
            this.btn_ball.TabIndex = 8;
            this.btn_ball.Text = "Ball color";
            this.btn_ball.UseVisualStyleBackColor = true;
            this.btn_ball.Click += new System.EventHandler(this.btn_ball_Click);
            // 
            // numRefreshTime
            // 
            this.numRefreshTime.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRefreshTime.Location = new System.Drawing.Point(96, 78);
            this.numRefreshTime.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numRefreshTime.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numRefreshTime.Name = "numRefreshTime";
            this.numRefreshTime.Size = new System.Drawing.Size(195, 20);
            this.numRefreshTime.TabIndex = 8;
            this.numRefreshTime.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // lbl_refresh
            // 
            this.lbl_refresh.AutoSize = true;
            this.lbl_refresh.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_refresh.Location = new System.Drawing.Point(10, 79);
            this.lbl_refresh.Name = "lbl_refresh";
            this.lbl_refresh.Size = new System.Drawing.Size(80, 15);
            this.lbl_refresh.TabIndex = 9;
            this.lbl_refresh.Text = "Refresh time";
            // 
            // DialogEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 230);
            this.Controls.Add(this.lbl_refresh);
            this.Controls.Add(this.numRefreshTime);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.lbl_ip);
            this.Controls.Add(this.rbtn_join);
            this.Controls.Add(this.rbtn_server);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.DialogEntry_Load);
            this.gBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_server;
        private System.Windows.Forms.RadioButton rbtn_join;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_gameAreaColor;
        private System.Windows.Forms.Button btn_platformColor;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.Button btn_ball;
        private System.Windows.Forms.Button btn_score;
        private System.Windows.Forms.NumericUpDown numRefreshTime;
        private System.Windows.Forms.Label lbl_refresh;
    }
}