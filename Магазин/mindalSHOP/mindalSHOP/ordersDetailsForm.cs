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
    public partial class ordersDetailsForm : Form
    {
        public Orders orderGive;
        public ordersDetailsForm(Orders order)
        {
            InitializeComponent();
            dgvOrderDetails.DataSource = AppData.DB.OrdersParts.Where(i => i.UserID == order.UserID&&order.ID==i.OrderID).ToList();

            var orderPrint = AppData.DB.OrdersParts.Where(i => i.UserID == order.UserID && order.ID == i.OrderID).ToList();
            orderGive = order;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ordersForm ordersForm = new ordersForm();
            ordersForm.Show();
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printForm print = new printForm(orderGive);
            print.Show();
            this.Hide();
        }
    }
}
