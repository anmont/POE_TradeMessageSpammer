namespace POE_TradeChatSpammer
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtFChannel = new System.Windows.Forms.TextBox();
            this.txtTChannel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChanDel = new System.Windows.Forms.TextBox();
            this.txtSpamCnt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtFinChannel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(35, 31);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(480, 20);
            this.txtMessage.TabIndex = 2;
            // 
            // txtFChannel
            // 
            this.txtFChannel.Location = new System.Drawing.Point(35, 79);
            this.txtFChannel.Name = "txtFChannel";
            this.txtFChannel.Size = new System.Drawing.Size(69, 20);
            this.txtFChannel.TabIndex = 3;
            this.txtFChannel.Text = "1";
            // 
            // txtTChannel
            // 
            this.txtTChannel.Location = new System.Drawing.Point(110, 79);
            this.txtTChannel.Name = "txtTChannel";
            this.txtTChannel.Size = new System.Drawing.Size(62, 20);
            this.txtTChannel.TabIndex = 4;
            this.txtTChannel.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Message to Spam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "From Channel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "To Channel";
            // 
            // txtChanDel
            // 
            this.txtChanDel.Location = new System.Drawing.Point(35, 127);
            this.txtChanDel.Name = "txtChanDel";
            this.txtChanDel.Size = new System.Drawing.Size(73, 20);
            this.txtChanDel.TabIndex = 8;
            this.txtChanDel.Text = "3000";
            // 
            // txtSpamCnt
            // 
            this.txtSpamCnt.Location = new System.Drawing.Point(117, 127);
            this.txtSpamCnt.Name = "txtSpamCnt";
            this.txtSpamCnt.Size = new System.Drawing.Size(55, 20);
            this.txtSpamCnt.TabIndex = 9;
            this.txtSpamCnt.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Use appendage \"$WTS 25c for 1ex\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Channel Delay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Times to spam Channel";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(466, 125);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtTimer
            // 
            this.txtTimer.Location = new System.Drawing.Point(466, 93);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(75, 20);
            this.txtTimer.TabIndex = 13;
            this.txtTimer.Text = "300000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Repeat After";
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtFinChannel
            // 
            this.txtFinChannel.Location = new System.Drawing.Point(402, 93);
            this.txtFinChannel.Name = "txtFinChannel";
            this.txtFinChannel.Size = new System.Drawing.Size(47, 20);
            this.txtFinChannel.TabIndex = 15;
            this.txtFinChannel.Text = "24";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Goto channel when done";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 158);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFinChannel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSpamCnt);
            this.Controls.Add(this.txtChanDel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTChannel);
            this.Controls.Add(this.txtFChannel);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "POE Trade Spammer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtFChannel;
        private System.Windows.Forms.TextBox txtTChannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChanDel;
        private System.Windows.Forms.TextBox txtSpamCnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtFinChannel;
        private System.Windows.Forms.Label label8;
    }
}

