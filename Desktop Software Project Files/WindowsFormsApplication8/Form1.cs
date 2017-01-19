using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        //Declare variables for servos
        int servo1 = 0;
        int servo2 = 0;
        int servo3 = 0;
        int servo4 = 0;
        int servo5 = 0;
        private void rotationTrackBar_Scroll(object sender, EventArgs e)//On Rotation Track Bar Update
        {
            servo1 = rotationTrackBar.Value;
            
        }

        private void extensionTrackBar_Scroll(object sender, EventArgs e) //On Extension Track Bar Update
        {
            servo2 = extensionTrackBar.Value;
            
        }

        private void elevationTrackBar_Scroll(object sender, EventArgs e)//On Elevation Track Bar Update
        {
            servo3 = elevationTrackBar.Value;
           
        }

        private void gripperTrackBar_Scroll(object sender, EventArgs e)//On Gripper Track Bar Update
        {
            servo4 = gripperTrackBar.Value;
            
        }

        private void auxTrackBar_Scroll(object sender, EventArgs e)//On Aux Track Bar Update
        {
            servo5 = auxTrackBar.Value;
            
        }

        private void connectButton_Click(object sender, EventArgs e)//On serial button connect/discconect
        {
            if (serialTimer.Enabled) //If Timer is already enable disable it
            {
                serialTimer.Enabled = false;
                disconnect(); //Set labels and status to off
            }
            else //Otherwise turn timer on it on
            {
                serialTimer.Enabled = true;
            }
        }
            public void sendSerial() //Send Serial Values to Arduino and update labels
        {
            String s1 = String.Format("{0:D3}", servo1);
            String s2 = String.Format("{0:D3}", servo2);
            String s3 = String.Format("{0:D3}", servo3);
            String s4 = String.Format("{0:D3}", servo4);
            String s5 = String.Format("{0:D3}", servo5);
            if (arduinoSerialPort.IsOpen)
            {
                arduinoSerialPort.Write(s1+s2+s3+s4+s5);
                
            }
            rotationLabel.Text = "Rotation: " + s1;
            extensionLabel.Text = "Extension: " + s2;
            elevationLabel.Text = "Elevation: " + s3;
            gripperLabel.Text = "Gripper: " + s4;
            auxLabel.Text = "Aux: " + s5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Get Baud Rate from text box
            int baud = int.Parse(baudRateTextBox.Text.ToString());
            //Set Baud Rate in Serial Connector
            arduinoSerialPort.BaudRate = baud;
            //Set COM port - Eventually this should be an option on the form
            arduinoSerialPort.PortName = "COM3";
            //Attempt to open port, send message, and close port
            try
            {
                //Open port
                arduinoSerialPort.Open();
                //Set status text at bottom of form
                connectionStatusLabel.Text = "Connected";
                //Set button text
                connectButton.Text = "Disconnect";
                //Send the message to the arduino
                sendSerial();
                //Close the port
                arduinoSerialPort.Close();
            }
            catch //Catch connection error
            {
                //Report connection error to user via message box
                
                //MessageBox.Show("Connection Unsuccesful:   [" + e.ToString() + "]", "Serial Connection Error");
                
                //Set labels on form to match status
                disconnect();
                //Disable timer
                serialTimer.Enabled = false;

            }
            
        }

        private void disconnect()
        {
            
            connectButton.Text = "Connect";
            connectionStatusLabel.Text = "Dissconnected";
        }

        
    }
    }

