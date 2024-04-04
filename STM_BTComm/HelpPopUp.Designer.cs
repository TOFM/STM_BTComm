namespace STM_BTComm
{
    partial class HelpPopUp
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
            this.okConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okConfirmButton
            // 
            this.okConfirmButton.Location = new System.Drawing.Point(132, 297);
            this.okConfirmButton.Name = "okConfirmButton";
            this.okConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.okConfirmButton.TabIndex = 0;
            this.okConfirmButton.Text = "OK";
            this.okConfirmButton.UseVisualStyleBackColor = true;
            this.okConfirmButton.Click += new System.EventHandler(this.okConfirmButton_Click);
            // 
            // HelpPopUp
            // 
            this.AcceptButton = this.okConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 332);
            this.ControlBox = false;
            this.Controls.Add(this.okConfirmButton);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpPopUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okConfirmButton;
    }
}