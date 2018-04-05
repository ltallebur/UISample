using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diversified_Code_Challenge
{
    public partial class Form1 : Form
    {
        bool on = true;
        bool mute = true;
        string lamphours;
        int seconds = 60;
        int minutes = 00;
        int hours = 999;



        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            onOffBtn.Text = "OFF";// Switch is set to off initially
            onOffBtn.BackColor = Color.Red;
            volTrackBar.Enabled = false;
            muteBtn.Enabled = false;
            muteBtn.BackColor = Color.Red;
            vgaBtn1.Enabled = false;
            vgaBtn2.Enabled = false;
            videoBtn.Enabled = false;
            CompoBtn.Enabled = false;
            hdmiBtn1.Enabled = false;
            hdmiBtn2.Enabled = false;
            LanNetworkBtn.Enabled = false;

        }


        private void onOffBtn_Click(object sender, EventArgs e)
        {
            //This will switch the button on and off

            if (on)
            {
                //Button ON
                onOffBtn.Text = "ON";
                onOffBtn.BackColor = Color.Green;
                on = false;
                volTrackBar.Enabled = true;
                muteBtn.Enabled = true;
                muteBtn.BackColor = Color.Green;
                vgaBtn1.Enabled = true;
                vgaBtn2.Enabled = true;
                videoBtn.Enabled = true;
                CompoBtn.Enabled = true;
                hdmiBtn1.Enabled = true;
                hdmiBtn2.Enabled = true;
                LanNetworkBtn.Enabled = true;
                timer1.Start();

            }

            else
            {
                //Button OFF
                onOffBtn.Text = "OFF";
                onOffBtn.BackColor = Color.Red;
                on = true;
                volTrackBar.Enabled = false;
                muteBtn.Enabled = false;
                muteBtn.BackColor = Color.Red;
                timer1.Stop();
            }


        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //To exit the application

            this.Close();

            
        }

        private void volTrackBar_Scroll(object sender, EventArgs e)
        {
            volTrackBar.Minimum = 0;
            volTrackBar.Maximum = 50;
            volTrackBar.TickStyle = TickStyle.BottomRight;
            volTrackBar.TickFrequency = 1;
            volTxtLbl.Text = volTrackBar.Value.ToString();


        }

        private void muteBtn_Click(object sender, EventArgs e)
        {
            if (mute)
            {
                //MUTE Button ON

                muteBtn.Text = "MUTED";
                volTrackBar.Value = 0;
                mute = false;
                volTxtLbl.Text = volTrackBar.Value.ToString();
                volTrackBar.Enabled = false;
                muteBtn.BackColor = Color.Red;
            }

            else
            { //MUTE BUTTON OFF
                muteBtn.Enabled = true;
                muteBtn.Text = "MUTE";
                volTrackBar.Enabled = true;
                volTrackBar.Value.ToString();
                volTxtLbl.Text = volTrackBar.Value.ToString();
                mute = true;
                muteBtn.BackColor = Color.Green;
            }

        }

        private void vgaBtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (vgaBtn1.Checked == true)
            {
                vgaBtn1.BackColor = Color.Green;
                deviceName.Text = vgaBtn1.Text;
            }
            else
            {
              vgaBtn1.BackColor = Color.DarkGoldenrod;
            }
        }

        private void vgaBtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (vgaBtn2.Checked == true)
            {
                vgaBtn2.BackColor = Color.Green;
                deviceName.Text = vgaBtn2.Text;
            }
            else
            {
                vgaBtn2.BackColor = Color.DarkGoldenrod;
            }

        }

        private void videoBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (videoBtn.Checked == true)
            {
                videoBtn.BackColor = Color.Green;
                deviceName.Text = videoBtn.Text;
            }
            else
            {
                videoBtn.BackColor = Color.DarkGoldenrod ;
            }

        }

        private void CompoBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CompoBtn.Checked == true)
            {
                CompoBtn.BackColor = Color.Green;
                deviceName.Text = CompoBtn.Text;
            }
            else
            {
                CompoBtn.BackColor = Color.DarkGoldenrod;
            }
        }

        private void hdmiBtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (hdmiBtn1.Checked == true)
            {
                hdmiBtn1.BackColor = Color.Green;
                deviceName.Text = hdmiBtn1.Text;
            }
            else
            {
                hdmiBtn1.BackColor = Color.DarkGoldenrod;
            }
        }

        private void hdmiBtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (hdmiBtn2.Checked == true)
            {
                hdmiBtn2.BackColor = Color.Green;
                deviceName.Text = hdmiBtn2.Text;
            }
            else
            {
                hdmiBtn2.BackColor = Color.DarkGoldenrod;
            }
        }

        private void LanNetworkBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (LanNetworkBtn.Checked == true)
            {
                LanNetworkBtn.BackColor = Color.Green;
                deviceName.Text = LanNetworkBtn.Text;
            }
            else
            {
                LanNetworkBtn.BackColor = Color.DarkGoldenrod;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            //lamphours--;
            seconds--;
            if (seconds < 0)
            {
                minutes--;
                seconds = 59;
            }

            if (minutes < 0)
            {
                hours--;
                minutes = 59;
            }
            if (hours < 1)
                hours = 0;

            lamphours = ( "H " + hours + ":" + "M " + minutes + ":" + "S " + seconds);

            lampLifeTextBox.Text = lamphours.ToString();
        }
    }
}
