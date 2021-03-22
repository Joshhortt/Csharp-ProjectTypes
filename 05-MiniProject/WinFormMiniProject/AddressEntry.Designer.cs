
namespace WinFormMiniProject
{
	partial class AddressEntry
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
			this.ARForm = new System.Windows.Forms.Label();
			this.AddressDashboardLabel = new System.Windows.Forms.Label();
			this.CityText = new System.Windows.Forms.TextBox();
			this.StreetAddressText = new System.Windows.Forms.TextBox();
			this.StreetAddressLabel = new System.Windows.Forms.Label();
			this.CityLabel = new System.Windows.Forms.Label();
			this.ZipCodeText = new System.Windows.Forms.TextBox();
			this.StateText = new System.Windows.Forms.TextBox();
			this.StateLabel = new System.Windows.Forms.Label();
			this.ZipCodeLabel = new System.Windows.Forms.Label();
			this.SaveAddressRecord = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ARForm
			// 
			this.ARForm.AutoSize = true;
			this.ARForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ARForm.Location = new System.Drawing.Point(44, 69);
			this.ARForm.Name = "ARForm";
			this.ARForm.Size = new System.Drawing.Size(258, 24);
			this.ARForm.TabIndex = 13;
			this.ARForm.Text = "Address Registration Form";
			this.ARForm.Click += new System.EventHandler(this.label2_Click);
			// 
			// AddressDashboardLabel
			// 
			this.AddressDashboardLabel.AutoSize = true;
			this.AddressDashboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddressDashboardLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.AddressDashboardLabel.Location = new System.Drawing.Point(308, 59);
			this.AddressDashboardLabel.Name = "AddressDashboardLabel";
			this.AddressDashboardLabel.Size = new System.Drawing.Size(175, 37);
			this.AddressDashboardLabel.TabIndex = 12;
			this.AddressDashboardLabel.Text = "Dashboard";
			// 
			// CityText
			// 
			this.CityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CityText.Location = new System.Drawing.Point(192, 163);
			this.CityText.Name = "CityText";
			this.CityText.Size = new System.Drawing.Size(280, 29);
			this.CityText.TabIndex = 11;
			// 
			// StreetAddressText
			// 
			this.StreetAddressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StreetAddressText.Location = new System.Drawing.Point(192, 117);
			this.StreetAddressText.Name = "StreetAddressText";
			this.StreetAddressText.Size = new System.Drawing.Size(280, 29);
			this.StreetAddressText.TabIndex = 10;
			// 
			// StreetAddressLabel
			// 
			this.StreetAddressLabel.AutoSize = true;
			this.StreetAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StreetAddressLabel.Location = new System.Drawing.Point(45, 122);
			this.StreetAddressLabel.Name = "StreetAddressLabel";
			this.StreetAddressLabel.Size = new System.Drawing.Size(133, 24);
			this.StreetAddressLabel.TabIndex = 8;
			this.StreetAddressLabel.Text = "Street Address";
			// 
			// CityLabel
			// 
			this.CityLabel.AutoSize = true;
			this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CityLabel.Location = new System.Drawing.Point(138, 166);
			this.CityLabel.Name = "CityLabel";
			this.CityLabel.Size = new System.Drawing.Size(40, 24);
			this.CityLabel.TabIndex = 9;
			this.CityLabel.Text = "City";
			// 
			// ZipCodeText
			// 
			this.ZipCodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ZipCodeText.Location = new System.Drawing.Point(192, 257);
			this.ZipCodeText.Name = "ZipCodeText";
			this.ZipCodeText.Size = new System.Drawing.Size(280, 29);
			this.ZipCodeText.TabIndex = 17;
			// 
			// StateText
			// 
			this.StateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StateText.Location = new System.Drawing.Point(192, 211);
			this.StateText.Name = "StateText";
			this.StateText.Size = new System.Drawing.Size(280, 29);
			this.StateText.TabIndex = 16;
			// 
			// StateLabel
			// 
			this.StateLabel.AutoSize = true;
			this.StateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StateLabel.Location = new System.Drawing.Point(127, 216);
			this.StateLabel.Name = "StateLabel";
			this.StateLabel.Size = new System.Drawing.Size(51, 24);
			this.StateLabel.TabIndex = 14;
			this.StateLabel.Text = "State";
			// 
			// ZipCodeLabel
			// 
			this.ZipCodeLabel.AutoSize = true;
			this.ZipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ZipCodeLabel.Location = new System.Drawing.Point(90, 262);
			this.ZipCodeLabel.Name = "ZipCodeLabel";
			this.ZipCodeLabel.Size = new System.Drawing.Size(88, 24);
			this.ZipCodeLabel.TabIndex = 15;
			this.ZipCodeLabel.Text = "Zip Code";
			// 
			// SaveAddressRecord
			// 
			this.SaveAddressRecord.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.SaveAddressRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveAddressRecord.Location = new System.Drawing.Point(297, 304);
			this.SaveAddressRecord.Name = "SaveAddressRecord";
			this.SaveAddressRecord.Size = new System.Drawing.Size(175, 44);
			this.SaveAddressRecord.TabIndex = 18;
			this.SaveAddressRecord.Text = "Save";
			this.SaveAddressRecord.UseVisualStyleBackColor = false;
			// 
			// AddressEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 535);
			this.Controls.Add(this.SaveAddressRecord);
			this.Controls.Add(this.ZipCodeText);
			this.Controls.Add(this.StateText);
			this.Controls.Add(this.StateLabel);
			this.Controls.Add(this.ZipCodeLabel);
			this.Controls.Add(this.ARForm);
			this.Controls.Add(this.AddressDashboardLabel);
			this.Controls.Add(this.CityText);
			this.Controls.Add(this.StreetAddressText);
			this.Controls.Add(this.StreetAddressLabel);
			this.Controls.Add(this.CityLabel);
			this.Name = "AddressEntry";
			this.Text = "AddressEntry";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ARForm;
		private System.Windows.Forms.Label AddressDashboardLabel;
		private System.Windows.Forms.TextBox CityText;
		private System.Windows.Forms.TextBox StreetAddressText;
		private System.Windows.Forms.Label StreetAddressLabel;
		private System.Windows.Forms.Label CityLabel;
		private System.Windows.Forms.TextBox ZipCodeText;
		private System.Windows.Forms.TextBox StateText;
		private System.Windows.Forms.Label StateLabel;
		private System.Windows.Forms.Label ZipCodeLabel;
		private System.Windows.Forms.Button SaveAddressRecord;
	}
}