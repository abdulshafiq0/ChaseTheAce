namespace ChaseTheAce
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
            this.BTNnewgame = new System.Windows.Forms.Button();
            this.IpJoinGame = new System.Windows.Forms.Button();
            this.TBip = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.PNLPlay = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.WaitingPNL = new System.Windows.Forms.Panel();
            this.BTNVote = new System.Windows.Forms.Button();
            this.WaitingPlayers = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.PNLPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.WaitingPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNnewgame
            // 
            this.BTNnewgame.Location = new System.Drawing.Point(19, 169);
            this.BTNnewgame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNnewgame.Name = "BTNnewgame";
            this.BTNnewgame.Size = new System.Drawing.Size(114, 52);
            this.BTNnewgame.TabIndex = 0;
            this.BTNnewgame.Text = "Create Game";
            this.BTNnewgame.UseVisualStyleBackColor = true;
            this.BTNnewgame.Click += new System.EventHandler(this.BTNnewgame_Click);
            // 
            // IpJoinGame
            // 
            this.IpJoinGame.Location = new System.Drawing.Point(19, 101);
            this.IpJoinGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IpJoinGame.Name = "IpJoinGame";
            this.IpJoinGame.Size = new System.Drawing.Size(104, 35);
            this.IpJoinGame.TabIndex = 1;
            this.IpJoinGame.Text = "Join game using IP";
            this.IpJoinGame.UseVisualStyleBackColor = true;
            this.IpJoinGame.Click += new System.EventHandler(this.IpJoinGame_Click);
            // 
            // TBip
            // 
            this.TBip.Location = new System.Drawing.Point(9, 59);
            this.TBip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBip.Name = "TBip";
            this.TBip.Size = new System.Drawing.Size(134, 20);
            this.TBip.TabIndex = 2;
            this.TBip.Text = "127.0.0.1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 279);
            this.dataGridView1.TabIndex = 3;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.dataGridView1);
            this.MenuPanel.Controls.Add(this.BTNnewgame);
            this.MenuPanel.Controls.Add(this.TBip);
            this.MenuPanel.Controls.Add(this.IpJoinGame);
            this.MenuPanel.Location = new System.Drawing.Point(467, 265);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(612, 325);
            this.MenuPanel.TabIndex = 4;
            // 
            // PNLPlay
            // 
            this.PNLPlay.Controls.Add(this.label2);
            this.PNLPlay.Controls.Add(this.listView1);
            this.PNLPlay.Controls.Add(this.listBox2);
            this.PNLPlay.Controls.Add(this.label4);
            this.PNLPlay.Controls.Add(this.label1);
            this.PNLPlay.Controls.Add(this.pictureBox3);
            this.PNLPlay.Controls.Add(this.button2);
            this.PNLPlay.Controls.Add(this.button1);
            this.PNLPlay.Controls.Add(this.pictureBox1);
            this.PNLPlay.Location = new System.Drawing.Point(-4, -1);
            this.PNLPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PNLPlay.Name = "PNLPlay";
            this.PNLPlay.Size = new System.Drawing.Size(563, 402);
            this.PNLPlay.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "PlayerName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "You";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(400, 35);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 183);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 243);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 20;
            this.button2.Text = "Swap";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 243);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 19;
            this.button1.Text = "Stick";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 183);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(212, 243);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(340, 147);
            this.listBox2.TabIndex = 28;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(212, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(183, 183);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Players:";
            // 
            // WaitingPNL
            // 
            this.WaitingPNL.Controls.Add(this.label3);
            this.WaitingPNL.Controls.Add(this.WaitingPlayers);
            this.WaitingPNL.Controls.Add(this.BTNVote);
            this.WaitingPNL.Location = new System.Drawing.Point(0, 0);
            this.WaitingPNL.Name = "WaitingPNL";
            this.WaitingPNL.Size = new System.Drawing.Size(415, 293);
            this.WaitingPNL.TabIndex = 6;
            // 
            // BTNVote
            // 
            this.BTNVote.Location = new System.Drawing.Point(58, 155);
            this.BTNVote.Name = "BTNVote";
            this.BTNVote.Size = new System.Drawing.Size(75, 47);
            this.BTNVote.TabIndex = 7;
            this.BTNVote.Text = "Vote To\r\nStart\r\n";
            this.BTNVote.UseVisualStyleBackColor = true;
            this.BTNVote.Click += new System.EventHandler(this.BTNVote_Click);
            // 
            // WaitingPlayers
            // 
            this.WaitingPlayers.FullRowSelect = true;
            this.WaitingPlayers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.WaitingPlayers.Location = new System.Drawing.Point(208, 88);
            this.WaitingPlayers.Name = "WaitingPlayers";
            this.WaitingPlayers.Size = new System.Drawing.Size(183, 183);
            this.WaitingPlayers.TabIndex = 30;
            this.WaitingPlayers.UseCompatibleStateImageBehavior = false;
            this.WaitingPlayers.View = System.Windows.Forms.View.Details;
            this.WaitingPlayers.Columns.Add("", -2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Players:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 400);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.WaitingPNL);
            this.Controls.Add(this.PNLPlay);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.PNLPlay.ResumeLayout(false);
            this.PNLPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.WaitingPNL.ResumeLayout(false);
            this.WaitingPNL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNnewgame;
        private System.Windows.Forms.Button IpJoinGame;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Panel MenuPanel;
        public System.Windows.Forms.TextBox TBip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel PNLPlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNVote;
        public System.Windows.Forms.Panel WaitingPNL;
        public System.Windows.Forms.ListView WaitingPlayers;
    }
}

