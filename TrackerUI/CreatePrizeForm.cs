using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);
                
                foreach(IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
            }
            else
            {
                MessageBox.Show("This form has invalid information.");
            }

        }

        private bool ValidateForm()
        {
            int aux = 0;
            bool output = true;
            if (!int.TryParse(placeNumberValue.Text, out aux))
            {
                output = false;

            } else if (aux < 1)
            {
                output = false;

            } else if (placeNameValue.Text.Length > 50 || placeNameValue.Text.Length <= 0)
            {
                output = false;

            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if(prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }
                 
            if(prizeAmount <= 0 && prizePercentage <=0)
            {
                output = false;
            }

            if(prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
            return output;
        }

        private void prizeAmountLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
