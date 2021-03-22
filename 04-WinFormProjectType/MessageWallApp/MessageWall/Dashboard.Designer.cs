namespace MessageWall
{
    partial class Dashboard
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
			this.messageLabel = new System.Windows.Forms.Label();
			this.messageText = new System.Windows.Forms.TextBox();
			this.messageListBox = new System.Windows.Forms.ListBox();
			this.messageListBoxLabel = new System.Windows.Forms.Label();
			this.addMessage = new System.Windows.Forms.Button();
			this.dashboardLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// messageLabel
			// 
			this.messageLabel.AutoSize = true;
			this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.messageLabel.Location = new System.Drawing.Point(68, 103);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(100, 25);
			this.messageLabel.TabIndex = 0;
			this.messageLabel.Text = "Message";
			// 
			// messageText
			// 
			this.messageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.messageText.Location = new System.Drawing.Point(174, 97);
			this.messageText.Name = "messageText";
			this.messageText.Size = new System.Drawing.Size(349, 31);
			this.messageText.TabIndex = 1;
			// 
			// messageListBox
			// 
			this.messageListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.messageListBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.messageListBox.FormattingEnabled = true;
			this.messageListBox.ItemHeight = 20;
			this.messageListBox.Location = new System.Drawing.Point(73, 181);
			this.messageListBox.Name = "messageListBox";
			this.messageListBox.Size = new System.Drawing.Size(537, 264);
			this.messageListBox.TabIndex = 3;
			this.messageListBox.TabStop = false;
			// 
			// messageListBoxLabel
			// 
			this.messageListBoxLabel.AutoSize = true;
			this.messageListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.messageListBoxLabel.Location = new System.Drawing.Point(68, 149);
			this.messageListBoxLabel.Name = "messageListBoxLabel";
			this.messageListBoxLabel.Size = new System.Drawing.Size(179, 25);
			this.messageListBoxLabel.TabIndex = 0;
			this.messageListBoxLabel.Text = "Added Messages";
			// 
			// addMessage
			// 
			this.addMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addMessage.Location = new System.Drawing.Point(541, 93);
			this.addMessage.Name = "addMessage";
			this.addMessage.Size = new System.Drawing.Size(69, 35);
			this.addMessage.TabIndex = 2;
			this.addMessage.Text = "Add";
			this.addMessage.UseVisualStyleBackColor = true;
			this.addMessage.Click += new System.EventHandler(this.AddMessage_Click);
			// 
			// dashboardLabel
			// 
			this.dashboardLabel.AutoSize = true;
			this.dashboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dashboardLabel.ForeColor = System.Drawing.SystemColors.Highlight;
			this.dashboardLabel.Location = new System.Drawing.Point(271, 24);
			this.dashboardLabel.Name = "dashboardLabel";
			this.dashboardLabel.Size = new System.Drawing.Size(175, 37);
			this.dashboardLabel.TabIndex = 4;
			this.dashboardLabel.Text = "Dashboard";
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(689, 476);
			this.Controls.Add(this.dashboardLabel);
			this.Controls.Add(this.addMessage);
			this.Controls.Add(this.messageListBox);
			this.Controls.Add(this.messageText);
			this.Controls.Add(this.messageListBoxLabel);
			this.Controls.Add(this.messageLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(7);
			this.Name = "Dashboard";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.Label messageListBoxLabel;
        private System.Windows.Forms.Button addMessage;
		private System.Windows.Forms.Label dashboardLabel;
	}
}

