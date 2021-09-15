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
    public partial class FindOneForm : Form
    {
        public FindOneForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindOk_Click(object sender, EventArgs e)
        {
            if (Validator.isPresent(txtOrderIId, "Order ID") && Validator.isInt(txtOrderIId))
            {
                try
                {
                    Order order = OrderDB.FindWithOneInput(Convert.ToInt32(txtOrderIId.Text));

                    if (order != null) {
                        txtOrderDate.Text = order.OrderDate.ToString();
                        txtCustId.Text = order.CustomerId.ToString();
                        txtTotalPrice.Text = order.TotalAmount.ToString();
                        txtOrderNo.Text = order.OrderNumber;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input", "Find");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to get Data: {ex.Message}", "Find");
                }
            }
        }

        private void btnFindClear_Click(object sender, EventArgs e)
        {
            txtOrderIId.Clear();
            txtOrderDate.Clear();
            txtCustId.Clear();
            txtOrderNo.Clear();
            txtTotalPrice.Clear();
        }

    }
}
