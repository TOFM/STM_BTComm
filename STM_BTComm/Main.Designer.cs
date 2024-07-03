namespace STM_BTComm
{
    partial class Main
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
            this.inComPortSelect = new System.Windows.Forms.ComboBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.sentBuffer = new System.Windows.Forms.RichTextBox();
            this.recievedBuffer = new System.Windows.Forms.RichTextBox();
            this.commandText = new System.Windows.Forms.TextBox();
            this.sendCommand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serialOut = new System.IO.Ports.SerialPort(this.components);
            this.refreshCOMList = new System.Windows.Forms.Button();
            this.serialIn = new System.IO.Ports.SerialPort(this.components);
            this.outComPortSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clrRecvBuffBtn = new System.Windows.Forms.Button();
            this.clrSentBuffBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.debugChBx = new System.Windows.Forms.CheckBox();
            this.normalTextChBx = new System.Windows.Forms.CheckBox();
            this.autoScrollRecBufChBx = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inComPortSelect
            // 
            this.inComPortSelect.FormattingEnabled = true;
            this.inComPortSelect.Location = new System.Drawing.Point(55, 25);
            this.inComPortSelect.Name = "inComPortSelect";
            this.inComPortSelect.Size = new System.Drawing.Size(75, 21);
            this.inComPortSelect.TabIndex = 0;
            this.inComPortSelect.SelectedIndexChanged += new System.EventHandler(this.ComPortSelect_SelectedIndexChanged);
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Location = new System.Drawing.Point(136, 25);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.BackColor = System.Drawing.Color.Beige;
            this.disconnectBtn.Enabled = false;
            this.disconnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectBtn.Location = new System.Drawing.Point(136, 66);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(75, 23);
            this.disconnectBtn.TabIndex = 2;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = false;
            this.disconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // sentBuffer
            // 
            this.sentBuffer.BackColor = System.Drawing.Color.White;
            this.sentBuffer.Enabled = false;
            this.sentBuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sentBuffer.Location = new System.Drawing.Point(10, 196);
            this.sentBuffer.Name = "sentBuffer";
            this.sentBuffer.ReadOnly = true;
            this.sentBuffer.Size = new System.Drawing.Size(385, 151);
            this.sentBuffer.TabIndex = 3;
            this.sentBuffer.Text = "";
            // 
            // recievedBuffer
            // 
            this.recievedBuffer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.recievedBuffer.BackColor = System.Drawing.Color.White;
            this.recievedBuffer.Enabled = false;
            this.recievedBuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recievedBuffer.Location = new System.Drawing.Point(11, 403);
            this.recievedBuffer.Name = "recievedBuffer";
            this.recievedBuffer.ReadOnly = true;
            this.recievedBuffer.Size = new System.Drawing.Size(384, 149);
            this.recievedBuffer.TabIndex = 4;
            this.recievedBuffer.Text = "";
            this.recievedBuffer.TextChanged += new System.EventHandler(this.recievedBuffer_TextChanged);
            // 
            // commandText
            // 
            this.commandText.BackColor = System.Drawing.Color.White;
            this.commandText.Enabled = false;
            this.commandText.Location = new System.Drawing.Point(10, 113);
            this.commandText.Name = "commandText";
            this.commandText.Size = new System.Drawing.Size(385, 20);
            this.commandText.TabIndex = 5;
            // 
            // sendCommand
            // 
            this.sendCommand.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sendCommand.Enabled = false;
            this.sendCommand.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.sendCommand.FlatAppearance.BorderSize = 0;
            this.sendCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendCommand.Location = new System.Drawing.Point(10, 139);
            this.sendCommand.Name = "sendCommand";
            this.sendCommand.Size = new System.Drawing.Size(385, 23);
            this.sendCommand.TabIndex = 6;
            this.sendCommand.Text = "Send";
            this.sendCommand.UseVisualStyleBackColor = false;
            this.sendCommand.Click += new System.EventHandler(this.SendCommand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input COM ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter coordinates (x,y/x1,y1/...)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sent messages buffer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Recieved messages buffer";
            // 
            // serialOut
            // 
            this.serialOut.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceivedHandler);
            // 
            // refreshCOMList
            // 
            this.refreshCOMList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.refreshCOMList.BackgroundImage = global::STM_BTComm.Properties.Resources.sync;
            this.refreshCOMList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshCOMList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshCOMList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshCOMList.Location = new System.Drawing.Point(10, 12);
            this.refreshCOMList.Name = "refreshCOMList";
            this.refreshCOMList.Padding = new System.Windows.Forms.Padding(1);
            this.refreshCOMList.Size = new System.Drawing.Size(39, 37);
            this.refreshCOMList.TabIndex = 11;
            this.refreshCOMList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshCOMList.UseVisualStyleBackColor = false;
            this.refreshCOMList.Click += new System.EventHandler(this.RefreshCOMList_Click);
            // 
            // outComPortSelect
            // 
            this.outComPortSelect.FormattingEnabled = true;
            this.outComPortSelect.Location = new System.Drawing.Point(55, 68);
            this.outComPortSelect.Name = "outComPortSelect";
            this.outComPortSelect.Size = new System.Drawing.Size(75, 21);
            this.outComPortSelect.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Output COM";
            // 
            // clrRecvBuffBtn
            // 
            this.clrRecvBuffBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.clrRecvBuffBtn.FlatAppearance.BorderSize = 0;
            this.clrRecvBuffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrRecvBuffBtn.Location = new System.Drawing.Point(10, 558);
            this.clrRecvBuffBtn.Name = "clrRecvBuffBtn";
            this.clrRecvBuffBtn.Size = new System.Drawing.Size(75, 23);
            this.clrRecvBuffBtn.TabIndex = 14;
            this.clrRecvBuffBtn.Text = "Clear";
            this.clrRecvBuffBtn.UseVisualStyleBackColor = false;
            this.clrRecvBuffBtn.Click += new System.EventHandler(this.ClrRecvBuffBtn_Click);
            // 
            // clrSentBuffBtn
            // 
            this.clrSentBuffBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.clrSentBuffBtn.FlatAppearance.BorderSize = 0;
            this.clrSentBuffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrSentBuffBtn.Location = new System.Drawing.Point(10, 353);
            this.clrSentBuffBtn.Name = "clrSentBuffBtn";
            this.clrSentBuffBtn.Size = new System.Drawing.Size(75, 23);
            this.clrSentBuffBtn.TabIndex = 15;
            this.clrSentBuffBtn.Text = "Clear";
            this.clrSentBuffBtn.UseVisualStyleBackColor = false;
            this.clrSentBuffBtn.Click += new System.EventHandler(this.ClrSentBuffBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.AccessibleDescription = "Help";
            this.helpBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.helpBtn.Cursor = System.Windows.Forms.Cursors.Help;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpBtn.Location = new System.Drawing.Point(378, 8);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(17, 22);
            this.helpBtn.TabIndex = 16;
            this.helpBtn.Text = "?";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(407, 24);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connStatusLabel
            // 
            this.connStatusLabel.Name = "connStatusLabel";
            this.connStatusLabel.Padding = new System.Windows.Forms.Padding(2);
            this.connStatusLabel.Size = new System.Drawing.Size(107, 19);
            this.connStatusLabel.Text = "Connection status";
            // 
            // debugChBx
            // 
            this.debugChBx.AutoSize = true;
            this.debugChBx.Location = new System.Drawing.Point(287, 12);
            this.debugChBx.Name = "debugChBx";
            this.debugChBx.Size = new System.Drawing.Size(58, 17);
            this.debugChBx.TabIndex = 18;
            this.debugChBx.Text = "Debug";
            this.debugChBx.UseVisualStyleBackColor = true;
            this.debugChBx.CheckedChanged += new System.EventHandler(this.debug_CheckedChanged);
            this.debugChBx.CheckStateChanged += new System.EventHandler(this.debug_CheckedChanged);
            // 
            // normalTextChBx
            // 
            this.normalTextChBx.AutoSize = true;
            this.normalTextChBx.Location = new System.Drawing.Point(287, 35);
            this.normalTextChBx.Name = "normalTextChBx";
            this.normalTextChBx.Size = new System.Drawing.Size(79, 17);
            this.normalTextChBx.TabIndex = 19;
            this.normalTextChBx.Text = "Normal text";
            this.normalTextChBx.UseVisualStyleBackColor = true;
            this.normalTextChBx.CheckedChanged += new System.EventHandler(this.normalStringChBx_CheckedChanged);
            // 
            // autoScrollRecBufChBx
            // 
            this.autoScrollRecBufChBx.AutoSize = true;
            this.autoScrollRecBufChBx.Location = new System.Drawing.Point(315, 558);
            this.autoScrollRecBufChBx.Name = "autoScrollRecBufChBx";
            this.autoScrollRecBufChBx.Size = new System.Drawing.Size(75, 17);
            this.autoScrollRecBufChBx.TabIndex = 20;
            this.autoScrollRecBufChBx.Text = "Auto scroll";
            this.autoScrollRecBufChBx.UseVisualStyleBackColor = true;
            this.autoScrollRecBufChBx.CheckedChanged += new System.EventHandler(this.autoScrollRecBufChBx_CheckedChanged);
            // 
            // Main
            // 
            this.AcceptButton = this.sendCommand;
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(407, 611);
            this.Controls.Add(this.autoScrollRecBufChBx);
            this.Controls.Add(this.normalTextChBx);
            this.Controls.Add(this.debugChBx);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.clrSentBuffBtn);
            this.Controls.Add(this.clrRecvBuffBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outComPortSelect);
            this.Controls.Add(this.refreshCOMList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendCommand);
            this.Controls.Add(this.commandText);
            this.Controls.Add(this.recievedBuffer);
            this.Controls.Add(this.sentBuffer);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.inComPortSelect);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Communiction with STM";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox inComPortSelect;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.RichTextBox sentBuffer;
        private System.Windows.Forms.RichTextBox recievedBuffer;
        private System.Windows.Forms.TextBox commandText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialOut;
        private System.Windows.Forms.Button refreshCOMList;
        private System.IO.Ports.SerialPort serialIn;
        private System.Windows.Forms.ComboBox outComPortSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clrRecvBuffBtn;
        private System.Windows.Forms.Button clrSentBuffBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button sendCommand;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connStatusLabel;
        private System.Windows.Forms.CheckBox debugChBx;
        private System.Windows.Forms.CheckBox normalTextChBx;
        private System.Windows.Forms.CheckBox autoScrollRecBufChBx;
    }
}

