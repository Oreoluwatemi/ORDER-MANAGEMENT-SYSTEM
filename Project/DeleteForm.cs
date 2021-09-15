using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void btnDelClear_Click(object sender, EventArgs e)
        {
            txtOrder.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelOk_Click(object sender, EventArgs e)
        {
            if (Validator.isPresent(txtOrder, "Order ID") && Validator.isInt(txtOrder))
            {
                try
                {
                    OrderDB.DeleteOrder(Convert.ToInt32(txtOrder.Text));
                    MessageBox.Show("Order Deleted", "Delete Order");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to delete order with id : {Convert.ToInt32(txtOrder.Text)}.", "Delete");
                }
            }
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
