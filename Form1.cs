using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_System
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        double d_PriceShoes;
        double d_PriceJackets;
        double d_PriceGloves;
        double d_PriceBeanies;
        double d_PriceSweaters;
        double d_PriceScarfs;

        double d_QtyShoes;
        double d_QtyJackets;
        double d_QtyGloves;
        double d_QtyBeanies;
        double d_QtySweaters;
        double d_QtyScarfs;

        double d_UPShoes = 179.99;
        double d_UPJackets = 129.99;
        double d_UPGloves = 24.99;
        double d_UPBeanies = 19.99;
        double d_UPSweaters = 89.99;
        double d_UPScarfs = 16.99;

        double d_TotalAmt;

        double d_TotalAmt1;
        double d_TotalAmt2;
        double d_TotalAmt3;
        double d_TotalAmt4;
        double d_TotalAmt5;
        double d_TotalAmt6;

        private void getUPrice()
        {
            txtBox_UPShoes.Text = d_UPShoes.ToString("c");
            txtBox_UPJackets.Text = d_UPJackets.ToString("c");
            txtBox_UPGloves.Text = d_UPGloves.ToString("c");
            txtBox_UPBeanies.Text = d_UPBeanies.ToString("c");
            txtBox_UPSweaters.Text = d_UPSweaters.ToString("c");
            txtBox_UPScarfs.Text = d_UPScarfs.ToString("c");

        }

        
        private void m_GetData()
        {
            double.TryParse(txtBox_UPShoes.Text, out d_PriceShoes);
            double.TryParse(numUpDwn_QtyShoes.Value.ToString(), out d_QtyShoes);

            double.TryParse(txtBox_UPJackets.Text, out d_PriceJackets);
            double.TryParse(numUpDwn_QtyJackets.Value.ToString(), out d_QtyJackets);

            double.TryParse(txtBox_UPGloves.Text, out d_PriceGloves);
            double.TryParse(numUpDwn_QtyGloves.Value.ToString(), out d_QtyGloves);

            double.TryParse(txtBox_UPBeanies.Text, out d_PriceBeanies);
            double.TryParse(numUpDwn_QtyBeanies.Value.ToString(), out d_QtyBeanies);

            double.TryParse(txtBox_UPSweaters.Text, out d_PriceSweaters);
            double.TryParse(numUpDwn_QtySweaters.Value.ToString(), out d_QtySweaters);

            double.TryParse(txtBox_UPScarfs.Text, out d_PriceScarfs);
            double.TryParse(numUpDwn_QtyScarfs.Value.ToString(), out d_QtyScarfs);
        }
        
        private void ExpYr()
        {
            //method that create loops for expiry year

            int i_StartYear = DateTime.Now.Year;
            int i_ExpYr;

            for (i_ExpYr = i_StartYear; i_ExpYr <= i_StartYear + 10; i_ExpYr++)
            {
                comBox_ExpYr.Items.Add(i_ExpYr.ToString());
            }
        }

        private void ExpMonth()
        {
            //this method populates the month names in the combobox.

            comBox_ExpMonth.Items.Add("January");
            comBox_ExpMonth.Items.Add("February");
            comBox_ExpMonth.Items.Add("March");
            comBox_ExpMonth.Items.Add("April");
            comBox_ExpMonth.Items.Add("May");
            comBox_ExpMonth.Items.Add("June");
            comBox_ExpMonth.Items.Add("July");
            comBox_ExpMonth.Items.Add("August");
            comBox_ExpMonth.Items.Add("September");
            comBox_ExpMonth.Items.Add("October");
            comBox_ExpMonth.Items.Add("November");
            comBox_ExpMonth.Items.Add("December");
        }

        private void CardType()
        {
            //this method populates the card types in the combobox.

            comBox_CardType.Items.Add("Visa");
            comBox_CardType.Items.Add("MasterCard");
            comBox_CardType.Items.Add("Diners Club");
            comBox_CardType.Items.Add("American Express");
        }

        private void IssueBank()
        {
            //this method populates the issuing banks in the combobox.

            comBox_IssueBank.Items.Add("New Zealand");
            comBox_IssueBank.Items.Add("Overseas");
        }

        private void loadItems()
        {
            //this method loads the items on the designated boxes in the form.

            CardType();
            ExpYr();
            ExpMonth();
            IssueBank();
            getUPrice();
            
            grpBox_CrdtCardInfo.Enabled = false;

            numUpDwn_QtyJackets.Enabled = false;
            numUpDwn_QtyShoes.Enabled = false;
            numUpDwn_QtyGloves.Enabled = false;
            numUpDwn_QtyBeanies.Enabled = false;
            numUpDwn_QtySweaters.Enabled = false;
            numUpDwn_QtyScarfs.Enabled = false;

            txtBox_TotalAmt.Enabled = false;
        }

        private void getcalculation()
        {
            //this method calculates the product prices.

            m_GetData();

            if (chk_Shoes.Checked)
            {
                d_PriceShoes = d_UPShoes * d_QtyShoes;
            }

            if (chk_Jackets.Checked)
            {
                d_PriceJackets = d_UPJackets * d_QtyJackets;
            }

            if (chk_Gloves.Checked)
            {
                d_PriceGloves = d_UPGloves * d_QtyGloves;
            }

            if (chk_Beanies.Checked)
            {
                d_PriceBeanies = d_UPBeanies* d_QtyBeanies;
            }

            if (chk_Sweaters.Checked)
            {
                d_PriceSweaters = d_UPSweaters * d_QtySweaters;
            }

            if (chk_Scarfs.Checked)
            {
                d_PriceScarfs = d_UPScarfs * d_QtyScarfs;
            }

            d_TotalAmt = d_PriceShoes + d_PriceJackets + d_PriceGloves + d_PriceBeanies + d_PriceSweaters + d_PriceScarfs;

            d_TotalAmt1 = d_PriceShoes;
            d_TotalAmt2 = d_PriceJackets;
            d_TotalAmt3 = d_PriceGloves;
            d_TotalAmt4 = d_PriceBeanies;
            d_TotalAmt5 = d_PriceSweaters;
            d_TotalAmt6 = d_PriceScarfs;

            txtBox_TotalAmt.Text = d_TotalAmt.ToString("");
        }

        private void PurchaseSum()
        {
            //this method displays all the information on the message box for Show Summary button.

            StringBuilder s_ShowSum = new StringBuilder();

            s_ShowSum.Append("CUSTOMER DETAILS \n");

            if (txtBox_FName.TextLength > 0 && txtBox_LName.TextLength > 0)
            {
                s_ShowSum.Append("\n Customer's name\t\t: " + txtBox_FName.Text + "  " + txtBox_LName.Text + "\n");
            }

            if (txtBox_StrtAddress.TextLength > 0)
            {
                s_ShowSum.Append("\n Customer's Address \t\t:" + txtBox_StrtAddress.Text + ",");
            }

            if (txtBox_Suburb.TextLength > 0)
            {
                s_ShowSum.Append(" " + txtBox_Suburb.Text + "," + "\t\t\t\t");
            }

            if (txtBox_City.TextLength > 0)
            {
                s_ShowSum.Append(" " + txtBox_City.Text + ", " );
            }

            if (txtBox_Country.TextLength > 0)
            {
                s_ShowSum.Append(txtBox_Country.Text + "\n\n\n\n");
            }

            s_ShowSum.Append("PRODUCT(s) PURCHASED \n");

            if (chk_Shoes.Checked && d_QtyShoes > 0)
            {
                s_ShowSum.Append("\n Shoes \t\t: " + numUpDwn_QtyShoes.Value + "pair(s)" + "\t "+"@"+"  "+ d_UPShoes + "\t\t" +  d_TotalAmt1 + "\n");
            }

            if (chk_Jackets.Checked && d_QtyJackets > 0)
            {
                s_ShowSum.Append("\n Jackets \t\t: " + numUpDwn_QtyJackets.Value + "pc(s)" + "\t " + "@" + "  " + d_UPJackets + "\t\t" + d_TotalAmt2 + "\n");
            }

            if (chk_Gloves.Checked && d_QtyGloves > 0)
            {
                s_ShowSum.Append("\n Gloves \t\t: " + numUpDwn_QtyGloves.Value + "pair(s)" + "\t " + "@" + "  " + d_UPGloves + "\t\t" + d_TotalAmt3 + "\n");
            }

            if (chk_Beanies.Checked && d_QtyBeanies > 0)
            {
                s_ShowSum.Append("\n Beanies \t\t: " + numUpDwn_QtyBeanies.Value + "pc(s)" + "\t " + "@" + "  " + d_UPBeanies + "\t\t" + d_TotalAmt4 + "\n");
            }

            if (chk_Sweaters.Checked && d_QtySweaters > 0)
            {
                s_ShowSum.Append("\n Sweaters \t\t: " + numUpDwn_QtySweaters.Value + "pc(s)" + "\t " + "@" + "  " + d_UPSweaters + "\t\t" + d_TotalAmt5 + "\n");
            }

            if (chk_Scarfs.Checked && d_QtyScarfs > 0)
            {
                s_ShowSum.Append("\n Scarfs \t\t: " + numUpDwn_QtyScarfs.Value + "pc(s)" + "\t " + "@" + "  " + d_UPScarfs + "\t\t" + d_TotalAmt6 + "\n");
            }

            if (txtBox_TotalAmt.TextLength > 0)
            {
                s_ShowSum.Append("\n TOTAL PURCHASED : $ " + "\t\t\t"+ txtBox_TotalAmt.Text + "\n\n\n\n");
            }

            


            s_ShowSum.Append("PAYMENTS DETAILS\n ");

            

            if (rbtn_Cash.Checked)
            {
                s_ShowSum.Append("\n\n Payment Type\t:  Cash" + "\n");
            }

            if (rbtn_BnkTrnsfr.Checked)
            {
                s_ShowSum.Append("\n\n Payment Type\t:  Bank Transfer" + "\n");
            }

            if (rbtn_CrdtCard.Checked)
            {
                s_ShowSum.Append("\n\n Payment Type\t:  Credit Card"+ "\n");

                if (txtBox_NameOnCard.TextLength > 0)
                {
                    s_ShowSum.Append("\n Name on Card\t: " + txtBox_NameOnCard.Text + "\n");
                }

                if (comBox_CardType.SelectedText == "")
                {
                    s_ShowSum.Append("\n Card Type\t: " + comBox_CardType.Text + " " + "\n");
                }

                if (txtBox_CardNum.TextLength > 0)
                {
                    s_ShowSum.Append("\n Card Number\t: " + txtBox_CardNum.Text + "\n");
                }

                if (comBox_ExpMonth.SelectedText == "" && comBox_ExpYr.SelectedText == "") 
                {
                    s_ShowSum.Append("\n Expiry\t\t: " + comBox_ExpMonth.SelectedItem + " " + comBox_ExpYr.SelectedItem + "\n");
                }

                if (comBox_IssueBank.SelectedText == "")
                {
                    s_ShowSum.Append("\n Issuing Bank\t: " + comBox_IssueBank.SelectedItem + "\n");
                }

            }

            if (chk_Shoes.Checked == false && chk_Jackets.Checked == false && chk_Gloves.Checked == false &&
               chk_Beanies.Checked == false && chk_Sweaters.Checked == false && chk_Scarfs.Checked == false)
            {
                MessageBox.Show("Please select atleast one product!");
            }

            else
            {
                MessageBox.Show(s_ShowSum.ToString(), "PURCHASE DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        private Boolean Mandatorydetails()

        {
            //Mandatory customer details

            if (string.IsNullOrWhiteSpace(txtBox_FName.Text))
            {
                MessageBox.Show("Please Fill All Mandatory Fields!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBox_LName.Text))
             {
                MessageBox.Show("Please Fill All Mandatory Fields!");
                return false;
             }

            //Mandatory details when credit card payment is selected

            if (grpBox_CrdtCardInfo.Enabled == true)
            {
                if (string.IsNullOrWhiteSpace(txtBox_NameOnCard.Text))
                {
                    MessageBox.Show("Please Fill All Credit Card Details!");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(comBox_CardType.Text))
                {
                    MessageBox.Show("Please Fill All Credit Card Details!");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtBox_CardNum.Text))
                {
                    MessageBox.Show("Please Fill All Credit Card Details!");
                    return false;
                }
                if (txtBox_CardNum.TextLength != 16)
                {
                    MessageBox.Show("Please Enter a Valid 16-digit Card Number!");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(comBox_ExpMonth.Text))
                {
                    MessageBox.Show("Please Fill All Credit Card Details!");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(comBox_ExpYr.Text))
                {
                    MessageBox.Show("Please Fill All Credit Card Details!");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(comBox_IssueBank.Text))
                {
                    MessageBox.Show("Please Fill All Credit Card Details!");
                    return false;
                }


                else
                {
                    return true;
                }



                
            }

            //Minimum of atleast one product name and quantity selected.

            if (chk_Shoes.Checked == false && chk_Jackets.Checked == false && chk_Gloves.Checked == false && 
                chk_Beanies.Checked == false && chk_Sweaters.Checked == false && chk_Scarfs.Checked == false)
            {
                MessageBox.Show("Please select atleast one product!");
                return false;
            }
            

            //Mandatory to select payment type

            if (rbtn_CrdtCard.Checked == false && rbtn_Cash.Checked == false && rbtn_BnkTrnsfr.Checked == false)
            {
                MessageBox.Show("Please select payment type!");
                return false;
            }
            return true;
        }

        

        private void CreditInfoEnable()
        {
            //Credit card information enabler

            if (rbtn_CrdtCard.Checked)
            {
                grpBox_CrdtCardInfo.Enabled = true;
            }
            else
            {
                grpBox_CrdtCardInfo.Enabled = false;
            }
           
        }

        

        private void CardCashDisabled()
        {
            //Credit card condition

            if (d_TotalAmt >= 50)
            {
                rbtn_CrdtCard.Enabled = true;
            }
            else
            {
                rbtn_CrdtCard.Enabled = false;
            }

            if (d_TotalAmt > 1500)
            {
                rbtn_Cash.Enabled = false;
            }
            else
            {
                rbtn_Cash.Enabled = true;
            }
        }

        private void creditInfoReset()
        {
            //this method resets all the credit card information if the customer change its mind paying credit card.

            if (rbtn_Cash.Checked) 
            {
                txtBox_NameOnCard.ResetText();
                comBox_CardType.ResetText();
                txtBox_CardNum.ResetText();
                comBox_ExpMonth.ResetText();
                comBox_ExpYr.ResetText();
                comBox_IssueBank.ResetText();
            }

            if (rbtn_BnkTrnsfr.Checked)
            {
                txtBox_NameOnCard.ResetText();
                comBox_CardType.ResetText();
                txtBox_CardNum.ResetText();
                comBox_ExpMonth.ResetText();
                comBox_ExpYr.ResetText();
                comBox_IssueBank.ResetText();
            }
        }

        private void ResetBtn()
        {
            //this method set the application to start-up state.

            this.Controls.Clear();
            this.InitializeComponent();
            loadItems();
        }
       

        private void chk_Jackets_CheckedChanged(object sender, EventArgs e)
        {
            //this function sets the product quantity to 1 when a product is selected.

            if (chk_Jackets.Checked)
            {
                numUpDwn_QtyJackets.Enabled = true;
                numUpDwn_QtyJackets.Focus();
                numUpDwn_QtyJackets.Value = 1;
            }
            else
            {
                numUpDwn_QtyJackets.Enabled = false;
                numUpDwn_QtyJackets.Value = 0;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //this function sets the product quantity to 1 when a product is selected.

            if (chk_Shoes.Checked)
            {
                numUpDwn_QtyShoes.Enabled = true;
                numUpDwn_QtyShoes.Focus();
                numUpDwn_QtyShoes.Value = 1;
            }
            else
            {
                numUpDwn_QtyShoes.Enabled = false;
                numUpDwn_QtyShoes.Value = 0;
            }
        }

        private void chk_Gloves_CheckedChanged(object sender, EventArgs e)
        {
            //this function sets the product quantity to 1 when a product is selected.

            if (chk_Gloves.Checked)
            {
                numUpDwn_QtyGloves.Enabled = true;
                numUpDwn_QtyGloves.Focus();
                numUpDwn_QtyGloves.Value = 1;
            }
            else
            {
                numUpDwn_QtyGloves.Enabled = false;
                numUpDwn_QtyGloves.Value = 0;
            }
        }

        private void chk_Beanies_CheckedChanged(object sender, EventArgs e)
        {
            //this function sets the product quantity to 1 when a product is selected.

            if (chk_Beanies.Checked)
            {
                numUpDwn_QtyBeanies.Enabled = true;
                numUpDwn_QtyBeanies.Focus();
                numUpDwn_QtyBeanies.Value = 1;
            }
            else
            {
                numUpDwn_QtyBeanies.Enabled = false;
                numUpDwn_QtyBeanies.Value = 0;
            }
        }

        private void chk_Sweaters_CheckedChanged(object sender, EventArgs e)
        {
            //this function sets the product quantity to 1 when a product is selected.

            if (chk_Sweaters.Checked)
            {
                numUpDwn_QtySweaters.Enabled = true;
                numUpDwn_QtySweaters.Focus();
                numUpDwn_QtySweaters.Value = 1;
            }
            else
            {
                numUpDwn_QtySweaters.Enabled = false;
                numUpDwn_QtySweaters.Value = 0;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            //this function sets the product quantity to 1 when a product is selected.

            if (chk_Scarfs.Checked)
            {
                numUpDwn_QtyScarfs.Enabled = true;
                numUpDwn_QtyScarfs.Focus();
                numUpDwn_QtyScarfs.Value = 1;
            }

            else
            {
                numUpDwn_QtyScarfs.Enabled = false;
                numUpDwn_QtyScarfs.Value = 0;
            }

        }

        private void txtBox_TotalAmt_TextChanged(object sender, EventArgs e)
        {
            CardCashDisabled();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Mandatorydetails())
            {
                PurchaseSum();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)

        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ResetBtn();
            }
            else
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CreditInfoEnable();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            creditInfoReset();
        }

        private void rbtn_BnkTrnsfr_CheckedChanged(object sender, EventArgs e)
        {
            creditInfoReset();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numUpDwn_QtyShoes_ValueChanged(object sender, EventArgs e)
        {
            getcalculation();
        }

        private void numUpDwn_QtyJackets_ValueChanged(object sender, EventArgs e)
        {
            getcalculation();
        }

        private void numUpDwn_QtyGloves_ValueChanged(object sender, EventArgs e)
        {
            getcalculation();
        }

        private void numUpDwn_QtyBeanies_ValueChanged(object sender, EventArgs e)
        {
            getcalculation();
        }

        private void numUpDwn_QtySweaters_ValueChanged(object sender, EventArgs e)
        {
            getcalculation();
        }

        private void numUpDwn_QtyScarfs_ValueChanged(object sender, EventArgs e)
        {
            getcalculation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadItems();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblStreetAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblSuburb_Click(object sender, EventArgs e)
        {

        }

        private void grpPaymentType_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comBoxExpiryMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSuburb_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCountry_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void comBox_IssueBank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_UPShoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
       
  
    }
}
