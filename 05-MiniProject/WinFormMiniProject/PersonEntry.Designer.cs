namespace WinFormMiniProject
{
    partial class PersonEntry
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
			this.LastNameLabel = new System.Windows.Forms.Label();
			this.FirstNameText = new System.Windows.Forms.TextBox();
			this.AddressesListLabel = new System.Windows.Forms.Label();
			this.LastNameText = new System.Windows.Forms.TextBox();
			this.IsActive = new System.Windows.Forms.CheckBox();
			this.IsActiveLabel = new System.Windows.Forms.Label();
			this.AddressesList = new System.Windows.Forms.ListBox();
			this.AddNewAddress = new System.Windows.Forms.Button();
			this.SavePersonRecord = new System.Windows.Forms.Button();
			this.FirstNameLabel = new System.Windows.Forms.Label();
			this.PersonDashoardLabel = new System.Windows.Forms.Label();
			this.PRFprm = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LastNameLabel
			// 
			this.LastNameLabel.AutoSize = true;
			this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LastNameLabel.Location = new System.Drawing.Point(40, 131);
			this.LastNameLabel.Name = "LastNameLabel";
			this.LastNameLabel.Size = new System.Drawing.Size(99, 24);
			this.LastNameLabel.TabIndex = 0;
			this.LastNameLabel.Text = "Last Name";
			// 
			// FirstNameText
			// 
			this.FirstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FirstNameText.Location = new System.Drawing.Point(145, 85);
			this.FirstNameText.Name = "FirstNameText";
			this.FirstNameText.Size = new System.Drawing.Size(307, 29);
			this.FirstNameText.TabIndex = 1;
			// 
			// AddressesListLabel
			// 
			this.AddressesListLabel.AutoSize = true;
			this.AddressesListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddressesListLabel.Location = new System.Drawing.Point(40, 246);
			this.AddressesListLabel.Name = "AddressesListLabel";
			this.AddressesListLabel.Size = new System.Drawing.Size(165, 24);
			this.AddressesListLabel.TabIndex = 0;
			this.AddressesListLabel.Text = "Display Addresses";
			// 
			// LastNameText
			// 
			this.LastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LastNameText.Location = new System.Drawing.Point(145, 126);
			this.LastNameText.Name = "LastNameText";
			this.LastNameText.Size = new System.Drawing.Size(307, 29);
			this.LastNameText.TabIndex = 2;
			// 
			// IsActive
			// 
			this.IsActive.AutoSize = true;
			this.IsActive.Location = new System.Drawing.Point(190, 191);
			this.IsActive.Name = "IsActive";
			this.IsActive.Size = new System.Drawing.Size(15, 14);
			this.IsActive.TabIndex = 3;
			this.IsActive.UseVisualStyleBackColor = true;
			// 
			// IsActiveLabel
			// 
			this.IsActiveLabel.AutoSize = true;
			this.IsActiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IsActiveLabel.Location = new System.Drawing.Point(40, 187);
			this.IsActiveLabel.Name = "IsActiveLabel";
			this.IsActiveLabel.Size = new System.Drawing.Size(67, 24);
			this.IsActiveLabel.TabIndex = 0;
			this.IsActiveLabel.Text = "Active";
			// 
			// AddressesList
			// 
			this.AddressesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddressesList.FormattingEnabled = true;
			this.AddressesList.ItemHeight = 16;
			this.AddressesList.Location = new System.Drawing.Point(44, 273);
			this.AddressesList.Name = "AddressesList";
			this.AddressesList.Size = new System.Drawing.Size(408, 212);
			this.AddressesList.TabIndex = 3;
			this.AddressesList.TabStop = false;
			// 
			// AddNewAddress
			// 
			this.AddNewAddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.AddNewAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddNewAddress.Location = new System.Drawing.Point(378, 228);
			this.AddNewAddress.Name = "AddNewAddress";
			this.AddNewAddress.Size = new System.Drawing.Size(74, 39);
			this.AddNewAddress.TabIndex = 4;
			this.AddNewAddress.Text = "Add";
			this.AddNewAddress.UseVisualStyleBackColor = false;
			this.AddNewAddress.Click += new System.EventHandler(this.AddNewAddress_Click);
			// 
			// SavePersonRecord
			// 
			this.SavePersonRecord.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.SavePersonRecord.Location = new System.Drawing.Point(44, 491);
			this.SavePersonRecord.Name = "SavePersonRecord";
			this.SavePersonRecord.Size = new System.Drawing.Size(175, 44);
			this.SavePersonRecord.TabIndex = 5;
			this.SavePersonRecord.Text = "Save";
			this.SavePersonRecord.UseVisualStyleBackColor = false;
			// 
			// FirstNameLabel
			// 
			this.FirstNameLabel.AutoSize = true;
			this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FirstNameLabel.Location = new System.Drawing.Point(38, 90);
			this.FirstNameLabel.Name = "FirstNameLabel";
			this.FirstNameLabel.Size = new System.Drawing.Size(101, 24);
			this.FirstNameLabel.TabIndex = 0;
			this.FirstNameLabel.Text = "First Name";
			// 
			// PersonDashoardLabel
			// 
			this.PersonDashoardLabel.AutoSize = true;
			this.PersonDashoardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PersonDashoardLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.PersonDashoardLabel.Location = new System.Drawing.Point(290, 24);
			this.PersonDashoardLabel.Name = "PersonDashoardLabel";
			this.PersonDashoardLabel.Size = new System.Drawing.Size(175, 37);
			this.PersonDashoardLabel.TabIndex = 6;
			this.PersonDashoardLabel.Text = "Dashboard";
			// 
			// PRFprm
			// 
			this.PRFprm.AutoSize = true;
			this.PRFprm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PRFprm.Location = new System.Drawing.Point(37, 37);
			this.PRFprm.Name = "PRFprm";
			this.PRFprm.Size = new System.Drawing.Size(247, 24);
			this.PRFprm.TabIndex = 7;
			this.PRFprm.Text = "Person Registration Form";
			// 
			// PersonEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(510, 597);
			this.Controls.Add(this.PRFprm);
			this.Controls.Add(this.PersonDashoardLabel);
			this.Controls.Add(this.SavePersonRecord);
			this.Controls.Add(this.AddNewAddress);
			this.Controls.Add(this.AddressesList);
			this.Controls.Add(this.IsActive);
			this.Controls.Add(this.LastNameText);
			this.Controls.Add(this.IsActiveLabel);
			this.Controls.Add(this.AddressesListLabel);
			this.Controls.Add(this.FirstNameText);
			this.Controls.Add(this.FirstNameLabel);
			this.Controls.Add(this.LastNameLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(7);
			this.Name = "PersonEntry";
			this.Text = "Person Entry Form";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.Label AddressesListLabel;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.CheckBox IsActive;
        private System.Windows.Forms.Label IsActiveLabel;
        private System.Windows.Forms.ListBox AddressesList;
        private System.Windows.Forms.Button AddNewAddress;
        private System.Windows.Forms.Button SavePersonRecord;
        private System.Windows.Forms.Label FirstNameLabel;
		private System.Windows.Forms.Label PersonDashoardLabel;
		private System.Windows.Forms.Label PRFprm;
	}
}

