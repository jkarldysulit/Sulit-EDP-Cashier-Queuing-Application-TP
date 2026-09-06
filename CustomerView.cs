using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Cashier_Queuing_Application_TP
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                lblView.Text = CashierClass.CashierQueue.Peek();
            }
            catch (InvalidOperationException)
            {
                lblView.Text = "P - _____"; //if queue is empty CustomerView value blank ______
            }
        }
    }
}

