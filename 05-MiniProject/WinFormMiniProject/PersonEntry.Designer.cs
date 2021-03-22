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
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.firstNameText = new System.Windows.Forms.TextBox();
			this.addressesListLabel = new System.Windows.Forms.Label();
			this.lastNameText = new System.Windows.Forms.TextBox();
			this.isActive = new System.Windows.Forms.CheckBox();
			this.isActiveLabel = new System.Windows.Forms.Label();
			this.addressesList = new System.Windows.Forms.ListBox();
			this.addNewAddress = new System.Windows.Forms.Button();
			this.saveRecord = new System.Windows.Forms.Button();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastNameLabel.Location = new System.Drawing.Point(40, 131);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(99, 24);
			this.lastNameLabel.TabIndex = 0;
			this.lastNameLabel.Text = "Last Name";
			// 
			// firstNameText
			// 
			this.firstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstNameText.Location = new System.Drawing.Point(185, 85);
			this.firstNameText.Name = "firstNameText";
			this.firstNameText.Size = new System.Drawing.Size(267, 29);
			this.firstNameText.TabIndex = 1;
			// 
			// addressesListLabel
			// 
			this.addressesListLabel.AutoSize = true;
			this.addressesListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addressesListLabel.Location = new System.Drawing.Point(40, 246);
			this.addressesListLabel.Name = "addressesListLabel";
			this.addressesListLabel.Size = new System.Drawing.Size(165, 24);
			this.addressesListLabel.TabIndex = 0;
			this.addressesListLabel.Text = "Display Addresses";
			// 
			// lastNameText
			// 
			this.lastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastNameText.Location = new System.Drawing.Point(185, 126);
			this.lastNameText.Name = "lastNameText";
			this.lastNameText.Size = new System.Drawing.Size(267, 29);
			this.lastNameText.TabIndex = 2;
			// 
			// isActive
			// 
			this.isActive.AutoSize = true;
			this.isActive.Location = new System.Drawing.Point(190, 191);
			this.isActive.Name = "isActive";
			this.isActive.Size = new System.Drawing.Size(15, 14);
			this.isActive.TabIndex = 3;
			this.isActive.UseVisualStyleBackColor = true;
			// 
			// isActiveLabel
			// 
			this.isActiveLabel.AutoSize = true;
			this.isActiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.isActiveLabel.Location = new System.Drawing.Point(40, 187);
			this.isActiveLabel.Name = "isActiveLabel";
			this.isActiveLabel.Size = new System.Drawing.Size(67, 24);
			this.isActiveLabel.TabIndex = 0;
			this.isActiveLabel.Text = "Active";
			// 
			// addressesList
			// 
			this.addressesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addressesList.FormattingEnabled = true;
			this.addressesList.ItemHeight = 16;
			this.addressesList.Location = new System.Drawing.Point(44, 273);
			this.addressesList.Name = "addressesList";
			this.addressesList.Size = new System.Drawing.Size(408, 212);
			this.addressesList.TabIndex = 3;
			this.addressesList.TabStop = false;
			// 
			// addNewAddress
			// 
			this.addNewAddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.addNewAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNewAddress.Location = new System.Drawing.Point(378, 228);
			this.addNewAddress.Name = "addNewAddress";
			this.addNewAddress.Size = new System.Drawing.Size(74, 39);
			this.addNewAddress.TabIndex = 4;
			this.addNewAddress.Text = "Add";
			this.addNewAddress.UseVisualStyleBackColor = false;
			// 
			// saveRecord
			// 
			this.saveRecord.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.saveRecord.Location = new System.Drawing.Point(44, 491);
			this.saveRecord.Name = "saveRecord";
			this.saveRecord.Size = new System.Drawing.Size(175, 44);
			this.saveRecord.TabIndex = 5;
			this.saveRecord.Text = "Save";
			this.saveRecord.UseVisualStyleBackColor = false;
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstNameLabel.Location = new System.Drawing.Point(38, 90);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(101, 24);
			this.firstNameLabel.TabIndex = 0;
			this.firstNameLabel.Text = "First Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(293, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 37);
			this.label1.TabIndex = 6;
			this.label1.Text = "Dahboard";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(37, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "Registration Form";
			// 
			// PersonEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(510, 597);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.saveRecord);
			this.Controls.Add(this.addNewAddress);
			this.Controls.Add(this.addressesList);
			this.Controls.Add(this.isActive);
			this.Controls.Add(this.lastNameText);
			this.Controls.Add(this.isActiveLabel);
			this.Controls.Add(this.addressesListLabel);
			this.Controls.Add(this.firstNameText);
			this.Controls.Add(this.firstNameLabel);
			this.Controls.Add(this.lastNameLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(7);
			this.Name = "PersonEntry";
			this.Text = "Person Entry Form";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label addressesListLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.CheckBox isActive;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.ListBox addressesList;
        private System.Windows.Forms.Button addNewAddress;
        private System.Windows.Forms.Button saveRecord;
        private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

