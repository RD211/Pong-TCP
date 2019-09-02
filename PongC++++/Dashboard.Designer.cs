namespace PongC____
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.pBox_game = new System.Windows.Forms.PictureBox();
            this.gameSendTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_server = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_game)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox_game
            // 
            this.pBox_game.Location = new System.Drawing.Point(0, 0);
            this.pBox_game.Name = "pBox_game";
            this.pBox_game.Size = new System.Drawing.Size(611, 617);
            this.pBox_game.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_game.TabIndex = 0;
            this.pBox_game.TabStop = false;
            // 
            // gameSendTimer
            // 
            this.gameSendTimer.Interval = 50;
            this.gameSendTimer.Tick += new System.EventHandler(this.gameControlsTimer_Tick);
            // 
            // lbl_server
            // 
            this.lbl_server.AutoSize = true;
            this.lbl_server.Location = new System.Drawing.Point(0, 600);
            this.lbl_server.Name = "lbl_server";
            this.lbl_server.Size = new System.Drawing.Size(0, 13);
            this.lbl_server.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 614);
            this.Controls.Add(this.lbl_server);
            this.Controls.Add(this.pBox_game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dashboard_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Dashboard_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_game)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox_game;
        private System.Windows.Forms.Timer gameSendTimer;
        private System.Windows.Forms.Label lbl_server;
    }
}

