using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMiniProject
{
    public partial class PersonEntry : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public PersonEntry()
        {
            InitializeComponent();

            AddressesList.DataSource = addresses;
            AddressesList.DisplayMember = nameof(AddressModel.AddressDisplayValue);  
        }

		private void AddNewAddress_Click(object sender, EventArgs e)
		{
            AddressModel newAddress = new AddressModel();

            AddressEntry entry = new AddressEntry();

            entry.Show();
		}

		public void SaveAddress(AddressModel address)
		{
			addresses.Add(address);
		}
	}
}
