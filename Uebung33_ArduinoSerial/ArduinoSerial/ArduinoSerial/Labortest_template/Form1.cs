using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;

namespace SerialPortDemo
{
    public partial class Form1 : Form
    {

        delegate void ShowDataCallback(string recieved);
        String InputData = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cboxPort.Items.AddRange(ports);
            cboxPort.SelectedItem = 0;
            cboxPort.SelectedText = "COM1";
            btnClose.Enabled = false;
            serialPort1.Encoding = Encoding.GetEncoding(28591);
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            InputData = serialPort1.ReadExisting();
            //serialPort1.DiscardOutBuffer();
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new ShowDataCallback(ShowData), new object[] { InputData });
            }
        }

        private void ShowData(string recieved)
        {
            // ..your Program here...
            txtRecieve.Text = recieved;
            progressBar1.Value = Convert.ToInt32(recieved)/4;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = false;
            btnClose.Enabled = true;
            try
            {
                serialPort1.PortName = cboxPort.Text;
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Port kann nicht geöffnet werden!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    btnOpen.Enabled = true;
                    btnClose.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler beim Port schließen!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                String textBoxText = "";
                textBoxText = textBoxEnter.Text;
                textBoxEnter.Text = "";
                serialPort1.Write(textBoxText);

                labelStatus.ForeColor = System.Drawing.Color.Green;
                labelStatus.Text = "Correctly sent. Text: " + textBoxText;
            }
            else
            {
                labelStatus.ForeColor = System.Drawing.Color.Red;
                labelStatus.Text = "Port closed.";
            }
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEnter_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
