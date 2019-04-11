// Grading ID: C6485
// Program #: 2
// Due: October 23, 2017 11:59 P.M.
// Course: CIS200-01
// Description: GUI that will serve as a front end for an application similar to MyUPS

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
    public partial class Prog2Form : Form
    {
        public UserParcelView upv; //The UserParcelView

        // Precondition: None
        // Postcondition: The form's GUI is prepared for display.
        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView();

            //Test Data
            upv.AddAddress("John Smith", "123 Any St.", "Apt. 45",
                "Louisville", "KY", 40202); // Test Address 1
            upv.AddAddress("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            upv.AddAddress("Billy Walsh", "123 Hollywood Lane",
                "Pasadena", "CA", 10100); // Test Address 5
            upv.AddAddress("Vincent Chase", "456 Rich Road",
                "Los Angeles", "CA", 75432); // Test Address 6
            upv.AddAddress("Eric Murphy", "111 Short Street",
                "Benton", "KY", 42025); // Test Address 7
            upv.AddAddress("Ari Gold", "414 Fairview Street", "Apt. 12",
                "Paducah", "KY", 83325); // Test Address 8

            // Letter test objects
            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(1), 3.95M);
            upv.AddLetter(upv.AddressAt(2), upv.AddressAt(3), 4.25M);

            // Ground Package test objects
            upv.AddGroundPackage(upv.AddressAt(4), upv.AddressAt(5), 14, 10, 5, 12.5);
            upv.AddGroundPackage(upv.AddressAt(6), upv.AddressAt(7), 20, 7, 4, 20);


            // Next Day Air Package test objects
            upv.AddNextDayAirPackage(upv.AddressAt(0), upv.AddressAt(2), 25, 15, 15,
                85, 7.50M);
            upv.AddNextDayAirPackage(upv.AddressAt(2), upv.AddressAt(4), 11, 22, 9,
                70, 7.38M);
            upv.AddNextDayAirPackage(upv.AddressAt(1), upv.AddressAt(6), 10.5, 20, 11,
                75, 7.38M);


            // Two Day Air Package test objects
            upv.AddTwoDayAirPackage(upv.AddressAt(6), upv.AddressAt(3), 46.5, 39.5, 28.0,
                80.5, TwoDayAirPackage.Delivery.Saver);
            upv.AddTwoDayAirPackage(upv.AddressAt(7), upv.AddressAt(5), 46.5, 39.5, 28.0,
                80.5, TwoDayAirPackage.Delivery.Early);
            upv.AddTwoDayAirPackage(upv.AddressAt(1), upv.AddressAt(0), 46.5, 39.5, 28.0,
                80.5, TwoDayAirPackage.Delivery.Saver);
        }

        //Click event for the List Addresses menu option
        private void listAddressesMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // NewLine shortcut

            outputTextBox.Text = "Addresses:" + $"{NL}{NL}" + 
            string.Join($"{NL}-------------------------------------{NL}" +
                    $"",upv.AddressList); // Displays the list of addresses stored in the upv object

        }

        // Click event for the List Parcels menu option
        private void listParcelsMenuItem_Click(object sender, EventArgs e)
        { 

            string NL = Environment.NewLine; // NewLine shortcut

            outputTextBox.Text = "Parcels:" + $"{NL}{NL}" +
            string.Join($"{NL}-------------------------------------{NL}" +
                    $"", upv.ParcelList); // Displays the list of parcels stored in the upv object
        }

        // Click event for the About  menu option
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // NewLine shortcut

            MessageBox.Show($"Grading ID: C6485 {NL} Program #: 2 {NL} " +
                $"Due: October 23, 2017 11:59 P.M. {NL} " +
                $"Course: CIS200-01 {NL} Description: GUI that will serve as a front end " +
                $"for an application similar to MyUPS"); // Provides message box that will display all 
                                                         // relevant info about the program
        }
        // Click event for the Exit menu option
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the Application
        }

        //Click event for the Add Address menu option
        protected void addressMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm(); // Creates a new instance of the AddressForm
            DialogResult result; // Holds result of dialog box
            result = addressForm.ShowDialog(); // Sets result = what was input

            // Holds the various information entered on AddressForm
            string addressName;
            string address1;
            string address2;
            string city;
            string state;
            int zip;

            if (result == DialogResult.OK) // If the user clicks ok on address form, info is entered and stored in upv
            {
                addressName = addressForm.AddressName;
                address1 = addressForm.Address1;
                address2 = addressForm.Address2;
                city = addressForm.City;
                state = addressForm.State;
                zip = addressForm.Zip;

                upv.AddAddress(addressName, address1, address2, city, state, zip);
            }
        }

        // Click event for the Add Letter menu option
        private void letterMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm = new LetterForm(upv.AddressList); // Creates a new instance of the LetterForm
            DialogResult result; // Holds result of dialog box
            result = letterForm.ShowDialog(); // Sets result = what was input

            // Holds the various information entered on AddressForm
            string originAddress;
            string destinationAddress;
            decimal fixedCost;

            if (result == DialogResult.OK) // If the user clicks ok on address form, info is entered and stored in upv
            {
               // originAddress = letterForm.OriginAddress;
                //destinationAddress = letterForm.DestinationAddress;
                fixedCost = letterForm.FixedCost;

                //upv.AddLetter(originAddress, destinationAddress, fixedCost);
            }
        }
    }
}
