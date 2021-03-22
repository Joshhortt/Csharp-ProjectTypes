
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
			this.cityText = new System.Windows.Forms.TextBox();
			this.streetAddressText = new System.Windows.Forms.TextBox();
			this.StreetAddressLabel = new System.Windows.Forms.Label();
			this.CityLabel = new System.Windows.Forms.Label();
			this.zipCodeText = new System.Windows.Forms.TextBox();
			this.stateText = new System.Windows.Forms.TextBox();
			this.StateLabel = new System.Windows.Forms.Label();
			this.ZipCodeLabel = new System.Windows.Forms.Label();
			this.SaveAddressRecord = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ARForm
			// 
			this.ARForm.AutoSize = true;
			this.ARForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ARForm.Location = new System.Drawing.Point(44, 69);
			this.ARForm.Name = "ARForm";
			this.ARForm.Size = new System.Drawing.Size(160, 25);
			this.ARForm.TabIndex = 13;
			this.ARForm.Text = "Address Entry";
			// 
			// AddressDashboardLabel
			// 
			this.AddressDashboardLabel.AutoSize = true;
			this.AddressDashboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddressDashboardLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.AddressDashboardLabel.Location = new System.Drawing.Point(379, 59);
			this.AddressDashboardLabel.Name = "AddressDashboardLabel";
			this.AddressDashboardLabel.Size = new System.Drawing.Size(93, 37);
			this.AddressDashboardLabel.TabIndex = 12;
			this.AddressDashboardLabel.Text = "Form";
			// 
			// cityText
			// 
			this.cityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cityText.Location = new System.Drawing.Point(192, 163);
			this.cityText.Name = "cityText";
			this.cityText.Size = new System.Drawing.Size(280, 29);
			this.cityText.TabIndex = 11;
			// 
			// streetAddressText
			// 
			this.streetAddressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.streetAddressText.Location = new System.Drawing.Point(192, 117);
			this.streetAddressText.Name = "streetAddressText";
			this.streetAddressText.Size = new System.Drawing.Size(280, 29);
			this.streetAddressText.TabIndex = 10;
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
			// zipCodeText
			// 
			this.zipCodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.zipCodeText.Location = new System.Drawing.Point(192, 257);
			this.zipCodeText.Name = "zipCodeText";
			this.zipCodeText.Size = new System.Drawing.Size(280, 29);
			this.zipCodeText.TabIndex = 17;
			// 
			// stateText
			// 
			this.stateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stateText.Location = new System.Drawing.Point(192, 211);
			this.stateText.Name = "stateText";
			this.stateText.Size = new System.Drawing.Size(280, 29);
			this.stateText.TabIndex = 16;
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
			this.SaveAddressRecord.Click += new System.EventHandler(this.SaveAddressRecord_Click);
			// 
			// AddressEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 535);
			this.Controls.Add(this.SaveAddressRecord);
			this.Controls.Add(this.zipCodeText);
			this.Controls.Add(this.stateText);
			this.Controls.Add(this.StateLabel);
			this.Controls.Add(this.ZipCodeLabel);
			this.Controls.Add(this.ARForm);
			this.Controls.Add(this.AddressDashboardLabel);
			this.Controls.Add(this.cityText);
			this.Controls.Add(this.streetAddressText);
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
		private System.Windows.Forms.TextBox cityText;
		private System.Windows.Forms.TextBox streetAddressText;
		private System.Windows.Forms.Label StreetAddressLabel;
		private System.Windows.Forms.Label CityLabel;
		private System.Windows.Forms.TextBox zipCodeText;
		private System.Windows.Forms.TextBox stateText;
		private System.Windows.Forms.Label StateLabel;
		private System.Windows.Forms.Label ZipCodeLabel;
		private System.Windows.Forms.Button SaveAddressRecord;
	}
}