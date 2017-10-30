namespace Timer_Sadewa
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
            System.Windows.Forms.Timer timer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.stop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.milisecond_2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.seconds_2 = new System.Windows.Forms.TextBox();
            this.minutes_2 = new System.Windows.Forms.TextBox();
            this.stop_2 = new System.Windows.Forms.Button();
            this.reset_2 = new System.Windows.Forms.Button();
            this.start_2 = new System.Windows.Forms.Button();
            this.default_interupt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.play_rem = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stop.Location = new System.Drawing.Point(426, 501);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(71, 23);
            this.stop.TabIndex = 13;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(151, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(570, 65);
            this.label4.TabIndex = 14;
            this.label4.Text = "SADEWA UGM 2017";
            // 
            // minute
            // 
            this.minute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.minute.Font = new System.Drawing.Font("Digital-7 Mono", 71.99999F);
            this.minute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.minute.Location = new System.Drawing.Point(289, 371);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(114, 102);
            this.minute.TabIndex = 17;
            this.minute.Text = "00";
            // 
            // second
            // 
            this.second.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.second.Font = new System.Drawing.Font("Digital-7 Mono", 71.99999F);
            this.second.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.second.Location = new System.Drawing.Point(540, 371);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(113, 102);
            this.second.TabIndex = 20;
            this.second.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Digital-7 Mono", 71.99999F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(428, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 96);
            this.label1.TabIndex = 23;
            this.label1.Text = ":";
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(736, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 89);
            this.button1.TabIndex = 28;
            this.button1.Text = "Stop Sound";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Digital-7 Mono", 71.99999F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(319, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 96);
            this.label3.TabIndex = 44;
            this.label3.Text = ":";
            // 
            // milisecond_2
            // 
            this.milisecond_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.milisecond_2.Font = new System.Drawing.Font("Digital-7 Mono", 71.99999F);
            this.milisecond_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.milisecond_2.Location = new System.Drawing.Point(193, 158);
            this.milisecond_2.Name = "milisecond_2";
            this.milisecond_2.Size = new System.Drawing.Size(110, 102);
            this.milisecond_2.TabIndex = 43;
            this.milisecond_2.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Digital-7 Mono", 71.99999F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.label5.Location = new System.Drawing.Point(550, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 96);
            this.label5.TabIndex = 42;
            this.label5.Text = ":";
            // 
            // seconds_2
            // 
            this.seconds_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.seconds_2.Font = new System.Drawing.Font("Digital-7 Mono", 71.99999F);
            this.seconds_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.seconds_2.Location = new System.Drawing.Point(638, 158);
            this.seconds_2.Name = "seconds_2";
            this.seconds_2.Size = new System.Drawing.Size(112, 102);
            this.seconds_2.TabIndex = 41;
            this.seconds_2.Text = "00";
            // 
            // minutes_2
            // 
            this.minutes_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.minutes_2.Font = new System.Drawing.Font("Digital-7 Mono", 71.99999F);
            this.minutes_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.minutes_2.Location = new System.Drawing.Point(425, 158);
            this.minutes_2.Name = "minutes_2";
            this.minutes_2.Size = new System.Drawing.Size(119, 102);
            this.minutes_2.TabIndex = 40;
            this.minutes_2.Text = "00";
            // 
            // stop_2
            // 
            this.stop_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.stop_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stop_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stop_2.Location = new System.Drawing.Point(426, 278);
            this.stop_2.Name = "stop_2";
            this.stop_2.Size = new System.Drawing.Size(71, 23);
            this.stop_2.TabIndex = 39;
            this.stop_2.Text = "Stop";
            this.stop_2.UseVisualStyleBackColor = false;
            this.stop_2.Click += new System.EventHandler(this.stop_2_Click);
            // 
            // reset_2
            // 
            this.reset_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.reset_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reset_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reset_2.Location = new System.Drawing.Point(292, 278);
            this.reset_2.Name = "reset_2";
            this.reset_2.Size = new System.Drawing.Size(71, 23);
            this.reset_2.TabIndex = 38;
            this.reset_2.Text = "Reset";
            this.reset_2.UseVisualStyleBackColor = false;
            this.reset_2.Click += new System.EventHandler(this.reset_2_Click);
            // 
            // start_2
            // 
            this.start_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.start_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.start_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start_2.Location = new System.Drawing.Point(563, 278);
            this.start_2.Name = "start_2";
            this.start_2.Size = new System.Drawing.Size(71, 23);
            this.start_2.TabIndex = 37;
            this.start_2.Text = "Start";
            this.start_2.UseVisualStyleBackColor = false;
            this.start_2.Click += new System.EventHandler(this.start_2_Click_1);
            // 
            // default_interupt
            // 
            this.default_interupt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.default_interupt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.default_interupt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.default_interupt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.default_interupt.Location = new System.Drawing.Point(562, 501);
            this.default_interupt.Name = "default_interupt";
            this.default_interupt.Size = new System.Drawing.Size(83, 22);
            this.default_interupt.TabIndex = 45;
            this.default_interupt.Text = "Auto-Play";
            this.default_interupt.UseVisualStyleBackColor = false;
            this.default_interupt.Click += new System.EventHandler(this.default_interupt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(353, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 43);
            this.label2.TabIndex = 46;
            this.label2.Text = "Waktu untuk Interupsi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.label6.Location = new System.Drawing.Point(364, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 43);
            this.label6.TabIndex = 47;
            this.label6.Text = "Waktu Untuk Debat";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // play_rem
            // 
            this.play_rem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.play_rem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.play_rem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_rem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.play_rem.Location = new System.Drawing.Point(132, 377);
            this.play_rem.Name = "play_rem";
            this.play_rem.Size = new System.Drawing.Size(83, 83);
            this.play_rem.TabIndex = 49;
            this.play_rem.Text = "Play Remaining Time";
            this.play_rem.UseVisualStyleBackColor = false;
            this.play_rem.Click += new System.EventHandler(this.play_rem_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reset.Location = new System.Drawing.Point(292, 502);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(71, 23);
            this.Reset.TabIndex = 50;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.pictureBox3.Image = global::Timer_Sadewa.Properties.Resources.ugm;
            this.pictureBox3.Location = new System.Drawing.Point(44, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 81);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Timer_Sadewa.Properties.Resources.Image1;
            this.pictureBox2.Location = new System.Drawing.Point(37, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 125);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Timer_Sadewa.Properties.Resources.imageedit_2_5134508743;
            this.pictureBox1.Location = new System.Drawing.Point(727, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 109);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(776, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Start - 5 Minutes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(776, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 23);
            this.button3.TabIndex = 52;
            this.button3.Text = "Start - 7 ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(776, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 23);
            this.button4.TabIndex = 53;
            this.button4.Text = "Start - 2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer4
            // 
            this.timer4.Interval = 10;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 10;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 10;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(925, 548);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.play_rem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.default_interupt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.milisecond_2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seconds_2);
            this.Controls.Add(this.minutes_2);
            this.Controls.Add(this.stop_2);
            this.Controls.Add(this.reset_2);
            this.Controls.Add(this.start_2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.second);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer Sadewa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox minute;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox milisecond_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox seconds_2;
        private System.Windows.Forms.TextBox minutes_2;
        private System.Windows.Forms.Button stop_2;
        private System.Windows.Forms.Button reset_2;
        private System.Windows.Forms.Button start_2;
        private System.Windows.Forms.Button default_interupt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button play_rem;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}

