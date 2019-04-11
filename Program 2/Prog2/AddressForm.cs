using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class AddressForm : Form
    {
        public const int MIN_ZIP = 0;     // Minimum ZipCode value
        public const int MAX_ZIP = 99999; // Maximum ZipCode value

        internal String AddressName
        {
            // Precondition:  None
            // Postcondition: The address' name has been returned
            get
            {
                return nameTextBox.Text;
            }

            // Precondition:  value must not be empty
            // Postcondition: The address' name has been set to the
            //                specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("Name",
                        value, "Name must not be empty"); // Throws exception if empty or whitespace
                else
                    nameTextBox.Text = value.Trim();
            }
        }

        internal String Address1
        {
            // Precondition:  None
            // Postcondition: The address' first address line has been returned
            get
            {
                return address1TextBox.Text;
            }

            // Precondition:  value must not be empty
            // Postcondition: The address' first address line has been set to
            //                the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("Address1",
                        value, "Address1 must not be empty"); // Throws exception if empty or whitespace
                else
                    address1TextBox.Text = value.Trim();
            }
        }

        internal String Address2
        {
            // Precondition:  None
            // Postcondition: The address' second address line has been returned
            get
            {
                return address2TextBox.Text;
            }

            // Precondition:  None
            // Postcondition: The address' second address line has been set to
            //                the specified value
            set
            {
                address2TextBox.Text = value.Trim();
            }
        }

        internal String City
        {
            // Precondition:  None
            // Postcondition: The address' city has been returned
            get
            {
                return cityTextBox.Text;
            }

            // Precondition:  value must not be empty
            // Postcondition: The address' city has been set to the
            //                specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("City",
                        value, "City must not be empty"); // Throws exception if empty or whitespace
                else
                    cityTextBox.Text = value.Trim();
            }
        }

        internal String State
        {
            // Precondition:  None
            // Postcondition: The address' state has been returned
            get
            {
                return stateComboBox.Text;
            }

            // Precondition:  value must not be empty
            // Postcondition: The address' state has been set to the
            //                specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("State",
                        value, "State must not be empty"); // Throws exception if space is empty or whitespace
                else
                    stateComboBox.Text = value.Trim();
            }
        }

        internal int Zip
        {
            // Precondition:  None
            // Postcondition: The address' zip code has been returned
            get
            {
                return int.Parse(zipTextBox.Text);
            }

            // Precondition:  MIN_ZIP <= value <= MAX_ZIP
            // Postcondition: The address' zip code has been set to the
            //                specified value
            set
            {
                if ((value >= MIN_ZIP) && (value <= MAX_ZIP))
                    zipTextBox.Text = value.ToString(); // Zip value must be within given range 
                else
                    throw new ArgumentOutOfRangeException("Zip", value,
                        "Zip must be U.S. 5 digit zip code"); // Throws exception if not in range
            }
        }

        public AddressForm()
        {
            InitializeComponent();
        }

        // Click event for OK button that will assign input values to properties if deemed to be ok
        private void okButton_Click(object sender, EventArgs e)
        {
            AddressName = nameTextBox.Text;
            Address1 = address1TextBox.Text;
            Address2 = address2TextBox.Text;
            City = cityTextBox.Text;
            State = stateComboBox.Text;
            Zip = int.Parse(zipTextBox.Text);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close(); // Closes the Form
        }
    }
}
