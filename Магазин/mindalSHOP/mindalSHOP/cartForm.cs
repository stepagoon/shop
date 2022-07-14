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
    public partial class cartForm : Form
    {
        public cartForm()
        {
            InitializeComponent();

            dgvCart.DataSource = AppData.DB.Cart.Where(p => p.UserID == AppData.UserID).ToList();
          
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menuForm menuForm = new menuForm();
            menuForm.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var id = 0;
            if (AppData.DB.Orders.ToList().Count>0)
            {
                id = AppData.DB.Orders.Max(x => x.ID) + 1;
            }

            var good = AppData.DB.Orders.Add(new Orders
            {
                IsAccepted = false,
                DateTime = DateTime.Now,
                UserID = AppData.UserID,
                ID = id,
            });
            foreach (var i in AppData.DB.Cart.Where(i=>i.UserID==AppData.UserID).ToList())
            {
                var idP = 0;
                if (AppData.DB.OrdersParts.ToList().Count > 0)
                {
                    idP = AppData.DB.OrdersParts.Max(x => x.ID) + 1;
                }
                var odersdetails = AppData.DB.OrdersParts.Add(new OrdersParts
                {
                    ItemID = i.ItemID,
                    Count = i.Count,
                    OrderID = good.ID,
                    UserID = AppData.UserID,
                    ID = idP,
                });
            }
            MessageBox.Show("Добавлено");
            AppData.DB.SaveChanges();

            menuForm menuForm = new menuForm();
            menuForm.Show();
            this.Hide();
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCart.Columns["Delete"].Index)
            {
                DialogResult
                    dialogResult = MessageBox.Show("Вы точно хотите удалить это из заказа?", "Подтверждение", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    AppData.DB.Cart.Remove((Cart)dgvCart.Rows[e.RowIndex].DataBoundItem);
                    AppData.DB.SaveChanges();

                    MessageBox.Show("Удалено!");

                    dgvCart.DataSource = AppData.DB.Cart.Where(p => p.UserID == AppData.UserID).ToList(); ;
                }
            }
            if (e.ColumnIndex == dgvCart.Columns["Edit"].Index)
            {
                AppData.EditedID = ((Cart)dgvCart.Rows[e.RowIndex].DataBoundItem).ID;

                editCartForm
                    editCartForm = new editCartForm();

                editCartForm.Owner = this;

                editCartForm.Show();
                this.Hide();
            }
        }
    }
}
