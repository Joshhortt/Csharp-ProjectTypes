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
    public partial class PersonEntry : Form
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public PersonEntry()
        {
            InitializeComponent();

            AddressesList.DataSource = addresses;
            AddressesList.DisplayMember = nameof(AddressModel.AddressDisplayValue);  // changed to AddressDisplayValue
        }

		private void AddNewAddress_Click(object sender, EventArgs e)
		{
            // Open the Address Registration Form. Instantiate the new addres enry form
            AddressEntry entry = new AddressEntry();
            entry.Show();
		}
	}
}
