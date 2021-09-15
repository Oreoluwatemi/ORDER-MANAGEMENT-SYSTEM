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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDisplayAllOrder_Click(object sender, EventArgs e)
        {
            AllOrdersForm orderForm = new AllOrdersForm();
            orderForm.Show();
        }

        private void btnAddModify_Click(object sender, EventArgs e)
        {
            AddModifyOrder addModifyOrder = new AddModifyOrder();
            addModifyOrder.Show();
        }

        private void btnFindOne_Click(object sender, EventArgs e)
        {
            FindOneForm findOneForm = new FindOneForm();
            findOneForm.Show();
        }

        private void btnFindTwo_Click(object sender, EventArgs e)
        {
            FindTwoForm findTwoForm = new FindTwoForm();
            findTwoForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm delete = new DeleteForm();
            delete.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
