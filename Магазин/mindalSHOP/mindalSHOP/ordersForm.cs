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
    public partial class ordersForm : Form
    {
        public ordersForm()
        {
            InitializeComponent();
            dgvOrders.DataSource = AppData.DB.Orders.ToList();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menuForm menuForm = new menuForm();
            menuForm.Show();
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvOrders.Columns["Delete"].Index)
            {
                DialogResult
                    dialogResult = MessageBox.Show("Вы точно хотите удалить этот заказ?", "Подтверждение", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    AppData.DB.Orders.Remove((Orders)dgvOrders.Rows[e.RowIndex].DataBoundItem);
                    AppData.DB.SaveChanges();

                    MessageBox.Show("Удалено!");

                    dgvOrders.DataSource = AppData.DB.Orders.ToList();
                }
            }
            if (e.ColumnIndex == dgvOrders.Columns["Edit"].Index)
            {
                AppData.EditedID = ((Orders)dgvOrders.Rows[e.RowIndex].DataBoundItem).ID;

                editOrdersForm editOrdersForm = new editOrdersForm((Orders)dgvOrders.Rows[e.RowIndex].DataBoundItem);
                editOrdersForm.Show();
                this.Hide();
            }
            if (e.ColumnIndex == dgvOrders.Columns["Details"].Index)
            {
                ordersDetailsForm ordersDetails = new ordersDetailsForm(((Orders)dgvOrders.Rows[e.RowIndex].DataBoundItem));
                ordersDetails.Show();
                this.Hide();
            }
        }
    }
}
