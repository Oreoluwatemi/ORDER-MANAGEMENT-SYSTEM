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
    public partial class AllOrdersForm : Form
    {
        public AllOrdersForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllOrdersForm_Load(object sender, EventArgs e)
        {
            this.DisplayAllOrders();
        }

        private void DisplayAllOrders()
        {
            SqlConnection conn = ManagementDataDB.GetConnection();
            conn.Open();
            string list = "select * from [Order]";
            SqlDataAdapter dataadapter = new SqlDataAdapter(list, conn);
            var bindingSource = new System.Windows.Forms.BindingSource();
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Display");
            bindingSource.DataSource = ds.Tables[0];
            dgvDisplayOrder.DataSource = bindingSource;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.DisplayAllOrders();
        }
    }
}
