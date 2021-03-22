using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageWall
{
    public partial class Dashboard : Form
    {
        //new Instance that supports data binding
        BindingList<string> messages = new BindingList<string>();

        public Dashboard()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            messageListBox.DataSource = messages;
        }

        private void AddMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(messageText.Text))  // if it is null or whitespace ...
            {   // MessageBox pops up if user does does not write anything inside Message textbox.
                MessageBox.Show("Please enter a message before trying to add it to the list.",
                    // when message pops up it shows a Ok Button and a Error red Icon
                    "Blank Message Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                messages.Add(messageText.Text);
                messageText.Text = "";
            }
            // cursor back to place, so that user can imediatly add more messages
            messageText.Focus();
        }
    }
}
