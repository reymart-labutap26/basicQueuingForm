using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            try
            {
                if (CashierClass.CashierQueue.Count == 0)
                {
                    MessageBox.Show("No student in the line");
                }
                else
                {
                    lblServing.Text = CashierClass.CashierQueue.Peek();
                    timerNowServing.Start();
                }
            }
            catch (ArgumentNullException ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        

        private int timer = 1;

        private void timerNowServing_Tick(object sender, EventArgs e)
        {
            if (timer <= 1)
            {
                timer++;
            }
            else
            {
                CashierClass.CashierQueue.Dequeue();
                timerNowServing.Stop();
                this.Close();
            }
        }
    }
}
