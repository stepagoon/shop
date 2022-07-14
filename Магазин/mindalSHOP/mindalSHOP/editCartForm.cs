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
    public partial class editCartForm : Form
    {
        int
            canUse = 0;

        public editCartForm()
        {
            InitializeComponent();

            cBItems.DisplayMember = "Name";
            cBItems.DataSource = AppData.DB.Items.ToList();

            canUse = ((Items)cBItems.SelectedItem).Count;

            labelCountScore.Text = "Доступно: " + canUse;
            numericCount.Maximum = canUse;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            cartForm cartForm1 = new cartForm();
            cartForm1.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var
                cart = AppData.DB.Cart.Where(p => p.ID == AppData.EditedID).Single();

            cart.ItemID = ((Items) cBItems.SelectedItem).ID;
            cart.Count = (int) numericCount.Value;

            AppData.DB.SaveChanges();

            Owner.Show();
            Hide();
        }

        private void cBItems_SelectionChangeCommitted(object sender, EventArgs e)
        {
            canUse = ((Items)cBItems.SelectedItem).Count;

            labelCountScore.Text = "Доступно: " + canUse;
            numericCount.Maximum = canUse;
        }
        private void numericCount_KeyUp(object sender, KeyEventArgs e)
        {
            canUse = ((Items)cBItems.SelectedItem).Count;

            labelCountScore.Text = "Доступно: " + (canUse-numericCount.Value);
            numericCount.Maximum = canUse;
        }
    }
}
