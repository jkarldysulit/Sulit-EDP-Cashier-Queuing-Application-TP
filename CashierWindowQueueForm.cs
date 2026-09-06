using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cashier_Queuing_Application_TP
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();

            timer1.Tick += new EventHandler(timer1_Tick); //every tick 1000ms will call timer1_Tick method
            timer1.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)//manual refresh of listBox
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            { // if may laman yung queue then click button next to dequeue
                CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
            catch (InvalidOperationException ex)// if nag next kahit walang laman yung Queue
            {
                MessageBox.Show("No number in queue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue); //auto refresh every 1 second
        }

        public void DisplayCashierQueue(IEnumerable CashierList)// foreach for Queue
        {
            listCashierQueue.Items.Clear();

            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());//inserting every number sa queue 1 by 1
            }
        }
    }
}
