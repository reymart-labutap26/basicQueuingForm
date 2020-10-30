using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class CashierWindowQueueForm : Form
    {
        
        public CashierWindowQueueForm()
        {

            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
            timer1.Start();
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach(object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
 
            DisplayCashierQueue(CashierClass.CashierQueue);
            CustomerView nowServing = new CustomerView();
            nowServing.Show();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
