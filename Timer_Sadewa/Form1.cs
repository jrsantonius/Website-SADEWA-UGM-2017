using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;



namespace Timer_Sadewa
{
    public partial class Form1 : Form
    {
        
        SoundPlayer stop_timer = new SoundPlayer(Timer_Sadewa.Properties.Resources.stop);
        SoundPlayer tick1 = new SoundPlayer(Timer_Sadewa.Properties.Resources.bell_ring_01);
        int timeleft;
        int minutes, seconds, miliseconds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
              
                if (int.Parse(minute.Text) <=0  && int.Parse(second.Text) <= 0)
                {
                    
                    minute.Text = "00";
                    second.Text = "00";
                    stop_timer.Stream.Position = 0;
                    using (System.Media.SoundPlayer sound = new SoundPlayer(stop_timer.Stream))
                    {
                        sound.Play();
                    }
                    timer2.Stop();
                    System.Windows.Forms.MessageBox.Show("Times Up");
                    stop_timer.Stream.Position = 0;
                    
                }
                else
                {                    
                    minutes = int.Parse(minute.Text);
                    seconds = int.Parse(second.Text);
                    //if (milisecond.Text == "00" && minutes <= 10)
                    //{
                        //tick_timer.Play();
                    //}
                    if (second.Text == "00")
                    {
                        minutes = minutes - 1;
                        if (minutes < 10)
                        {
                            minute.Text = "0" + minutes.ToString();
                        }
                        else
                        {
                            minute.Text = minutes.ToString();
                        }
                        second.Text="99";
                    }
                    else
                    {
                            seconds = seconds - 1;
                            if (seconds < 10)
                            {
                                second.Text = "0" + seconds.ToString();
                            }
                            else
                            {
                                second.Text = seconds.ToString();
                            }
                        }
                    }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            stop_timer.Stop();
        }

        private void start_2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                int secondses_2 = int.Parse(seconds_2.Text);
                int minuteses_2 = int.Parse(minutes_2.Text);
                int milisecondses_2 = int.Parse(milisecond_2.Text);
                secondses_2 += 1;
                if (secondses_2 >= 100)
                {
                    minuteses_2 += 1;
                    secondses_2 = 0;
                }

                if (minuteses_2 >= 60)
                {
                    milisecondses_2 += 1;
                    minuteses_2 = 0;
                }

                if (secondses_2 < 10 && secondses_2>=0)
                {
                    seconds_2.Text = "0" + secondses_2.ToString();
                }
                else if(secondses_2 >= 10)
                {
                    seconds_2.Text = secondses_2.ToString();
                }
                if (minuteses_2 < 10)
                {
                    minutes_2.Text = "0" + minuteses_2.ToString();
                }
                else if (minuteses_2 >= 10)
                {
                    minutes_2.Text = minuteses_2.ToString();
                }

                if (milisecondses_2 < 10)
                {
                    milisecond_2.Text = "0" + milisecondses_2.ToString();
                }
                else if (milisecondses_2 >= 10)
                {
                    milisecond_2.Text = milisecondses_2.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void default_interupt_Click(object sender, EventArgs e)
        {
            minute.Text = "30";
            timer2.Start();
        }

        
private void start_2_Click_1(object sender, EventArgs e)
        {
            timer3.Start();

        }

        private void stop_2_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
        }

        private void reset_2_Click(object sender, EventArgs e)
        {
            milisecond_2.Text = "00";
            minutes_2.Text = "00";
            seconds_2.Text = "00";
            timer3.Stop();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void play_rem_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Reset_Click_1(object sender, EventArgs e)
        {
            minute.Text = "00";
            second.Text = "00";
            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            try
            {

                int secondses_2 = int.Parse(seconds_2.Text);
                int minuteses_2 = int.Parse(minutes_2.Text);
                int milisecondses_2 = int.Parse(milisecond_2.Text);
                if (int.Parse(minutes_2.Text) >= 20 && int.Parse(seconds_2.Text) >= 0 && int.Parse(milisecond_2.Text) >= 5)
                {

                    minutes_2.Text = "20";
                    seconds_2.Text = "00";
                    stop_timer.Stream.Position = 0;
                    using (System.Media.SoundPlayer sound = new SoundPlayer(stop_timer.Stream))
                    {
                        sound.Play();
                    }
                    timer4.Stop();
                    System.Windows.Forms.MessageBox.Show("Times Up");
                    stop_timer.Stream.Position = 0;

                }
                else
                {
                    secondses_2 += 1;
                }
                if (secondses_2 >= 100)
                {
                    minuteses_2 += 1;
                    secondses_2 = 0;
                }

                if (minuteses_2 >= 60)
                {
                    milisecondses_2 += 1;
                    minuteses_2 = 0;
                }

                if (secondses_2 < 10 && secondses_2 >= 0)
                {
                    seconds_2.Text = "0" + secondses_2.ToString();
                }
                else if (secondses_2 >= 10)
                {
                    seconds_2.Text = secondses_2.ToString();
                }
                if (minuteses_2 < 10)
                {
                    minutes_2.Text = "0" + minuteses_2.ToString();
                }
                else if (minuteses_2 >= 10)
                {
                    minutes_2.Text = minuteses_2.ToString();
                }

                if (milisecondses_2 < 10)
                {
                    milisecond_2.Text = "0" + milisecondses_2.ToString();
                }
                else if (milisecondses_2 >= 10)
                {
                    milisecond_2.Text = milisecondses_2.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            try
            {

                int secondses_2 = int.Parse(seconds_2.Text);
                int minuteses_2 = int.Parse(minutes_2.Text);
                int milisecondses_2 = int.Parse(milisecond_2.Text);
                if (int.Parse(minutes_2.Text) >= 20 && int.Parse(seconds_2.Text) >= 0 && int.Parse(milisecond_2.Text) >= 7)
                {

                    minutes_2.Text = "20";
                    seconds_2.Text = "00";
                    stop_timer.Stream.Position = 0;
                    using (System.Media.SoundPlayer sound = new SoundPlayer(stop_timer.Stream))
                    {
                        sound.Play();
                    }
                    timer5.Stop();
                    System.Windows.Forms.MessageBox.Show("Times Up");
                    stop_timer.Stream.Position = 0;

                }
                else
                {

                    secondses_2 += 1;
                }
                if (secondses_2 >= 100)
                {
                    minuteses_2 += 1;
                    secondses_2 = 0;
                }

                if (minuteses_2 >= 60)
                {
                    milisecondses_2 += 1;
                    minuteses_2 = 0;
                }

                if (secondses_2 < 10 && secondses_2 >= 0)
                {
                    seconds_2.Text = "0" + secondses_2.ToString();
                }
                else if (secondses_2 >= 10)
                {
                    seconds_2.Text = secondses_2.ToString();
                }
                if (minuteses_2 < 10)
                {
                    minutes_2.Text = "0" + minuteses_2.ToString();
                }
                else if (minuteses_2 >= 10)
                {
                    minutes_2.Text = minuteses_2.ToString();
                }

                if (milisecondses_2 < 10)
                {
                    milisecond_2.Text = "0" + milisecondses_2.ToString();
                }
                else if (milisecondses_2 >= 10)
                {
                    milisecond_2.Text = milisecondses_2.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            try
            {

                int secondses_2 = int.Parse(seconds_2.Text);
                int minuteses_2 = int.Parse(minutes_2.Text);
                int milisecondses_2 = int.Parse(milisecond_2.Text);
                secondses_2 += 1;
                if (int.Parse(minutes_2.Text) >= 0 && int.Parse(seconds_2.Text) >= 0 && int.Parse(milisecond_2.Text) >= 2)
                {

                    minutes_2.Text = "20";
                    seconds_2.Text = "00";
                    stop_timer.Stream.Position = 0;
                    using (System.Media.SoundPlayer sound = new SoundPlayer(stop_timer.Stream))
                    {
                        sound.Play();
                    }
                    timer6.Stop();
                    System.Windows.Forms.MessageBox.Show("Times Up");
                    stop_timer.Stream.Position = 0;

                }
                if (secondses_2 >= 100)
                {
                    minuteses_2 += 1;
                    secondses_2 = 0;
                }

                if (minuteses_2 >= 60)
                {
                    milisecondses_2 += 1;
                    minuteses_2 = 0;
                }

                if (secondses_2 < 10 && secondses_2 >= 0)
                {
                    seconds_2.Text = "0" + secondses_2.ToString();
                }
                else if (secondses_2 >= 10)
                {
                    seconds_2.Text = secondses_2.ToString();
                }
                if (minuteses_2 < 10)
                {
                    minutes_2.Text = "0" + minuteses_2.ToString();
                }
                else if (minuteses_2 >= 10)
                {
                    minutes_2.Text = minuteses_2.ToString();
                }

                if (milisecondses_2 < 10)
                {
                    milisecond_2.Text = "0" + milisecondses_2.ToString();
                }
                else if (milisecondses_2 >= 10)
                {
                    milisecond_2.Text = milisecondses_2.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer6.Start();
        }

        private void stop_Click_1(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            
        }

        

        private void reset_Click(object sender, EventArgs e)
        {
            minute.Text = "00";
            second.Text = "00";
            timer2.Stop();
        }
    }
}
