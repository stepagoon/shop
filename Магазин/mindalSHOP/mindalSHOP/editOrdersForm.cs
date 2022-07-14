using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mindalSHOP
{
    public partial class editOrdersForm : Form
    {
        public editOrdersForm(Orders orders = null)
        {
            InitializeComponent();

            if (orders != null)
            {
                ordersChanged = orders;
                checkBReady.Checked = orders.IsAccepted;
            } 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ordersForm ordersForm = new ordersForm();
            ordersForm.Show();
            this.Hide();
        }
        Orders ordersChanged;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ordersChanged!=null)
            {
                ordersChanged.IsAccepted = checkBReady.Checked;
                AppData.DB.SaveChanges();
                ordersForm ordersForm = new ordersForm();
                ordersForm.Show();
                this.Hide();
            }
            
        }
    }
}
