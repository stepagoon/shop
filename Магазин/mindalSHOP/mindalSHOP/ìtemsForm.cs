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
    public partial class ìtemsForm : Form
    {
        public ìtemsForm()
        {
            InitializeComponent();
            dgvItems.DataSource = AppData.DB.Items.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menuForm menuForm = new menuForm();
            menuForm.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            cartForm cartForm = new cartForm();
            cartForm.Show();
            this.Hide();
    }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int
                    item_id = ((Items)dgvItems.Rows[e.RowIndex].DataBoundItem).ID;

                var
                    check = AppData.DB.Cart.Where(p => p.UserID == AppData.UserID && p.ItemID == item_id).FirstOrDefault();

                if (check == null)
                {

                    var
                        item = AppData.DB.Cart.Add(new Cart
                        {
                            UserID = AppData.UserID,
                            ItemID = item_id,
                            Count = 1
                        });

                    AppData.DB.SaveChanges();
                    MessageBox.Show("Товар добавлен в корзину!");
                }
                else
                    MessageBox.Show("Товар уже в корзине!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSerach_TextChanged(object sender, EventArgs e)
        {
            dgvItems.DataSource = AppData.DB.Items.Where(i => i.Name.Contains(tbSerach.Text)).ToList();
        }
    }
}
