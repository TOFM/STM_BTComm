using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace STM_BTComm
{
    public partial class Main : Form
    {
        private string[] ports = SerialPort.GetPortNames();
        private bool debugFlag = false;
        private bool normalTextFlag = false;

        private void RefreshComPortEnum()
        {
            ports = SerialPort.GetPortNames();

            inComPortSelect.Items.Clear();
            outComPortSelect.Items.Clear();

            for (int i = 0; i < ports.Length; i++)
            {
                inComPortSelect.Items.Add(ports[i]);
                outComPortSelect.Items.Add(ports[i]);
            }
        }
        public Main()
        {
            InitializeComponent();
            RefreshComPortEnum();

            autoScrollRecBufChBx.Checked = true;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComPortSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Do not use   
        }
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (outComPortSelect.SelectedItem != null && inComPortSelect.SelectedItem != null)
            {
                serialOut = new SerialPort(outComPortSelect.SelectedItem.ToString(), 9600);
                serialIn = new SerialPort(inComPortSelect.SelectedItem.ToString(), 9600);
                //serialOut.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                try
                {
                    serialOut.Open();
                    serialIn.Open();

                    connStatusLabel.BackColor = Color.Green;

                    inComPortSelect.Enabled = false;
                    outComPortSelect.Enabled = false;
                    refreshCOMList.Enabled = false;
                    connectBtn.Enabled = false;
                    disconnectBtn.Enabled = true;
                    commandText.Enabled = true;
                    sendCommand.Enabled = true;
                    sentBuffer.Enabled = true;
                    recievedBuffer.Enabled = true;

                    sentBuffer.Text = string.Empty;
                    recievedBuffer.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in connecting [" + ex.Message + "]");
                }
            }
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;
            string indata = port.ReadExisting();

            Invoke((MethodInvoker)delegate
            {
                recievedBuffer.Text += indata;
            });
        }
        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialOut.IsOpen || serialIn.IsOpen)
                {
                    serialOut.Close();
                    serialIn.Close();
                    //connectBtn.BackColor = Color.Red;
                    connStatusLabel.BackColor = Color.Red;
                }

                inComPortSelect.Enabled = true;
                outComPortSelect.Enabled = true;
                refreshCOMList.Enabled = true;
                connectBtn.Enabled = true;
                commandText.Enabled = false;
                sendCommand.Enabled = false;
                sentBuffer.Enabled = false;
                recievedBuffer.Enabled = false;

                recievedBuffer.Text = "Disconnected from " + inComPortSelect.Text;
                sentBuffer.Text = "Disconnected from " + outComPortSelect.Text;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error in disconnecting [" + ex.Message + "]");
            }
        }
        private void SendCommand_Click(object sender, EventArgs e)
        {
            string binaryMessage = "";
            char[] delimeters = { '-', '/' };
            string[] coords = commandText.Text.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            bool errFlag = false;

            if (!normalTextFlag)
            {
                foreach (string item in coords)
                {
                    try
                    {
                        if (item != string.Empty)
                        {
                            UInt16 form;
                            string bin;
                            string clearedItem;

                            if (item.EndsWith("ms"))
                            {
                                clearedItem = item.Remove(item.Length - 2, 2);
                                form = 0;
                            }
                            else if (item.EndsWith("s"))
                            {
                                clearedItem = item.Remove(item.Length - 1, 1);

                                form = 1;
                                form <<= 14;
                            }
                            else if (item.EndsWith("min"))
                            {
                                clearedItem = item.Remove(item.Length - 3, 3);

                                form = 10;
                                form <<= 14;
                            }
                            else if (item.EndsWith("h"))
                            {
                                clearedItem = item.Remove(item.Length - 1, 1);

                                form = 11;
                                form <<= 14;
                            }
                            else
                            {
                                bin = Convert.ToString(Convert.ToUInt16(Convert.ToDouble(item) * 100), 2); // Add checks for symbols and text and numbers bigger than Uint16
                                binaryMessage += bin.PadLeft(16, '0');
                                continue;
                            }

                            bin = Convert.ToString(Convert.ToUInt16(Convert.ToDouble(clearedItem) * 100) + form, 2);

                            binaryMessage += bin.PadLeft(16, '0');
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error in sending: [{ex.Message}]");
                        errFlag = true;
                        continue;
                    }
                }
            }
            else
            {
                binaryMessage = commandText.Text;
            }

            if (!errFlag)
            {
                sentBuffer.Text += String.Format("[{0}] {1} \n", DateTime.Now.ToString("HH:mm:ss"), binaryMessage);
                if (!normalTextFlag) binaryMessage += "f";

                if (!debugFlag)
                {
                    try
                    {
                        serialOut.Write(binaryMessage);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error in sending: [{ex.Message}]");
                    }
                }
            }
        }
        private void RefreshCOMList_Click(object sender, EventArgs e)
        {
            RefreshComPortEnum();
        }

        private void ClrSentBuffBtn_Click(object sender, EventArgs e)
        {
            sentBuffer.Text = string.Empty;
        }

        private void ClrRecvBuffBtn_Click(object sender, EventArgs e)
        {
            recievedBuffer.Text = string.Empty;
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelpPopUp helpPopUp = new HelpPopUp();
            helpPopUp.Show();
        }

        private void debug_CheckedChanged(object sender, EventArgs e)
        {
            if (debugChBx.Checked && !serialIn.IsOpen && !serialOut.IsOpen)
            {
                debugFlag = true;

                connectBtn.Enabled = false;
                disconnectBtn.Enabled = false;
                inComPortSelect.Enabled = false;
                outComPortSelect.Enabled = false;

                sendCommand.Enabled = true;
                sentBuffer.Enabled = true;
                commandText.Enabled = true;

            }
            else if ((debugChBx.Checked && serialIn.IsOpen) || serialOut.IsOpen)
            {
                debugChBx.Checked = false;

            }
            else if (!debugChBx.Checked)
            {
                debugFlag = false;

                connectBtn.Enabled = true;
                disconnectBtn.Enabled = true;
                inComPortSelect.Enabled = true;
                outComPortSelect.Enabled = true;

                sendCommand.Enabled = false;
                sentBuffer.Enabled = false;
                commandText.Enabled = false;
            }
        }

        private void normalStringChBx_CheckedChanged(object sender, EventArgs e)
        {
            if (normalTextChBx.Checked)
            {
                normalTextFlag = true;
            }
            else
            {
                normalTextFlag = false;
            }
        }
        private void autoScrollRecBufChBx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void recievedBuffer_TextChanged(object sender, EventArgs e)
        {
            if (autoScrollRecBufChBx.Checked)
            {
                recievedBuffer.SelectionStart = recievedBuffer.Text.Length;
                recievedBuffer.ScrollToCaret();
            }
        }
    }
}
