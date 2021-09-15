using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FindTwoForm : Form
    {
        public FindTwoForm()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindOk_Click(object sender, EventArgs e)
        {
            if (Validator.isPresent(txtFindOrderItemId, "Order ID") && Validator.isInt(txtFindOrderItemId)
                && Validator.isPresent(txtFindOrderNo, "Order Number"))
            {
                try
                {
                    Order order = OrderDB.FindWithTwoInput(Convert.ToInt32(txtFindOrderItemId.Text), txtFindOrderNo.Text);
                    if (order != null)
                    {
                        txtFindCustId.Text = order.CustomerId.ToString();
                        txtFindOrderIDate.Text = order.OrderDate.ToString();
                        txtFindTotalAmount.Text = order.TotalAmount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input", "Find");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to get Data{ex.Message}", "Find");
                }
            }
        }

        private void btnFindClear_Click(object sender, EventArgs e)
        {
            txtFindCustId.Clear();
            txtFindOrderIDate.Clear();
            txtFindOrderItemId.Clear();
            txtFindOrderNo.Clear();
            txtFindTotalAmount.Clear();
        }

    }
}
