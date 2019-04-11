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
    public partial class LetterForm : Form
    {
        List<Address> OriginAddress;

        internal decimal FixedCost // Helper property
        {
            // Precondition:  None
            // Postcondition: The letter's fixed cost has been returned
            get
            {
                return decimal.Parse(fixedCostTextBox.Text);
            }

            // Precondition:  value >= 0
            // Postcondition: The letter's fixed cost has been set to the
            //                specified value
            set
            {
                if (value >= 0)
                    fixedCostTextBox.Text = value.ToString();
                else
                    throw new ArgumentOutOfRangeException("FixedCost", value,
                        "FixedCost must be >= 0");
            }
        }

        public LetterForm(List<Address> list)
        {
            InitializeComponent();

            OriginAddress = list;
        }

    private void okButton_Click(object sender, EventArgs e)
        {
            FixedCost = decimal.Parse(fixedCostTextBox.Text);
        }

        private void LetterForm_Load(object sender, EventArgs e)
        {
            string NL = Environment.NewLine;

            originAddressComboBox.Items.Add(string.Join($"{NL}-------------------------------------{NL}" +
                    $"", OriginAddress)); // Displays the list of addresses stored in the upv object);

            destinationAddressComboBox.Items.Add(string.Join($"{NL}-------------------------------------{NL}" +
                    $"", OriginAddress)); // Displays the list of addresses stored in the upv object);)
        }
    }
}
