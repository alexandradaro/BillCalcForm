using System;
using System.Windows.Forms;

namespace BillCalcForm
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var bill = decimal.Parse(tbBill.Text);
                var tip = decimal.Parse(tbTipPercent.Text);
                var amount = BillCalc(bill, tip);
                
                tbamount.Text = amount.ToString();
            }
            catch (Exception ex)
            {
                tbamount.Text = "Something is not right";
               
            }
        }
        public decimal BillCalc( decimal bills, decimal tip)
        {
            var amount = ((tip/100 * bills) + bills);
            return amount;
        }
    }
}
