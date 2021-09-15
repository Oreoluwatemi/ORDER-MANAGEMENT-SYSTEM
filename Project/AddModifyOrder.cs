using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddModifyOrder : Form
    {
        public AddModifyOrder()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Order od = GetOrder();
            if (od != null)
            {
                try
                {
                    OrderDB.AddOrder(od);
                    MessageBox.Show("Order Added", "Add Order");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to Add order: {ex.Message}", "Add");
                }
            }

        }
        Order order = new Order();
        private Order GetOrder()
        {
            if (Validator.isPresent(txtOrderId, "Order ID") && Validator.isPresent(txtCustId, "Customer ID")
                && Validator.isPresent(txtTotalAmount, "Total Amount ID")
                && Validator.isPresent(txtOrderNo, "Order Number")
                && Validator.isInt(txtOrderId) && Validator.isInt(txtCustId)
                && Validator.isDecimal(txtTotalAmount))
            {
                order.OrderId = Convert.ToInt32(txtOrderId.Text);
                order.CustomerId = Convert.ToInt32(txtCustId.Text);
                order.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                order.OrderNumber = txtOrderNo.Text;

                return order;
            }
            return null;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Order od = GetOrder();
            if (od != null)
            {
                try
                {
                    OrderDB.ModifyOrder(od);
                    MessageBox.Show("Order Modified", "Modify Order");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to Add order, {ex.Message}", "Modify");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustId.Clear();
            txtOrderId.Clear();
            txtOrderNo.Clear();
            txtTotalAmount.Clear();
        }

        private void AddModifyOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
