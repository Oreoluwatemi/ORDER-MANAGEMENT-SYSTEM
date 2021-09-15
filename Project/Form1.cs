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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int startTime;
        private void Timer_Tick(object sender, EventArgs e)
        {
            startTime += 2;
            progressBar1.Value = startTime;
            if (progressBar1.Value == 50)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Main mainWindow = new Main();
                this.Hide();
                mainWindow.Show();
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
