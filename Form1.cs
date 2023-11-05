namespace CS311_Project3_RLV
{
    public partial class Form1 : Form
    {
        double price = 0;
        double tax = 0.07;
        double subTotal = 0;
        double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void grpCrust_Enter(object sender, EventArgs e)
        {

        }//end grouptxt Crust

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summarize();
        }
        private void Summarize()
        {
            //Combo box, size, output
            String pSize = cboSizes.GetItemText(cboSizes.SelectedItem);
            rtfOrderSummary.SelectedText = "You have ordered a " + pSize + " pizza with ";
            

            //Radio button, crust, output
            if (rdoReg.Checked)
            {
                rtfOrderSummary.SelectedText += "regular crust and the following toppings: \n";
            }
            else if (rdoThin.Checked)
            {
                rtfOrderSummary.SelectedText += "thin crust and the following toppings: \n";
            }
            else if (rdoThick.Checked)
            {
                rtfOrderSummary.SelectedText += "thick crust and the following toppings: \n";
            }

            //Instantiating pizza size to combo box
            String pizzaSize = "";
            pizzaSize = cboSizes.Text;

            //Adding prices to pizza size
            if (pizzaSize == "Small")
            {
                price += 2.00;
            }

            if (pizzaSize == "Medium")
            {
                price += 5.00;
            }

            if (pizzaSize == "Large")
            {
                price += 10.00;
            }

            if (pizzaSize == "Xtra Large")
            {
                price += 15.00;
            }

            if (pizzaSize == "Ginormous")
            {
                price += 20.00;
            }

            //Check box, toppings, output and price

            rtfOrderSummary.SelectionBullet = true;

            if (ckbBananaPepper.Checked)
            {
                price += 1.00;
                rtfOrderSummary.SelectedText += "Banana Peppers\n";
            }

            if (ckbBlackO.Checked)
            {
                price += 1.00;
                rtfOrderSummary.SelectedText += "Black Olives\n";
            }

            if (ckbExtraCheese.Checked)
            {
                price += 1.00;
                rtfOrderSummary.SelectedText += "Extra Cheese\n";
            }

            if (ckbGreenO.Checked)
            {
                price += 1.00;
                rtfOrderSummary.SelectedText += "Green Olives\n";
            }

            if (ckbGreenPepp.Checked)
            {
                price += 1.00;
                rtfOrderSummary.SelectedText += "Green Peppers\n";
            }

            if (ckbJalepeno.Checked)
            {
                price += 1.00;
                rtfOrderSummary.SelectedText += "Jalepeno\n";
            }

            if (ckbMushroom.Checked)
            {
                price += 1.00;
                rtfOrderSummary.SelectedText += "Mushroom\n";
            }

            if (ckbOnion.Checked)
            {
                price += 1.00;
                rtfOrderSummary.SelectedText += "Onion\n";
            }

            if (ckbPepp.Checked)
            {
                price += 2.00;
                rtfOrderSummary.SelectedText += "Pepperoni\n";
            }

            if (ckbSausage.Checked)
            {
                price += 2.00;
                rtfOrderSummary.SelectedText += "Sausage\n";
            }

            if (ckbSItalianSausage.Checked)
            {
                price += 2.00;
                rtfOrderSummary.SelectedText += "Spicy Italian Sausage\n";
            }

            if (ckbCanadianB.Checked)
            {
                price += 2.00;
                rtfOrderSummary.SelectedText += "Canadian Bacon\n";
            }
            rtfOrderSummary.SelectionBullet = false;

            
            // Calculations for subTotal, Tax, price, and Total
            price += subTotal;
            tax *= price;
            total = price + tax;

            txtSubtotal.Text = price.ToString("C");
            txtTax.Text = tax.ToString("C");
            txtTotal.Text = total.ToString("C");


        }//end Summarize()

        private void rtfOrderSummary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
