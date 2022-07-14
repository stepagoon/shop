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
    public partial class storageForm : Form
    {
        public storageForm()
        {
            InitializeComponent();
            dgvStorage.DataSource = AppData.DB.Items.ToList();

            var listOfTypes = AppData.DB.Providers.ToList();
            listOfTypes.Insert(0, new Providers { Name = "Все типы" });
            cbSearch.DataSource = listOfTypes;
            cbSearch.DisplayMember = "Name";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menuForm menuForm = new menuForm();
            menuForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addStorageForm addGoodsForm = new addStorageForm();
            addGoodsForm.Show();
            this.Hide();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStorage.DataSource = AppData.DB.Items.Where(i => i.Name.Contains(tbSearch.Text)).ToList();
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex == 0)
            {
                dgvStorage.DataSource = AppData.DB.Items.ToList();
            }
            else
            {
                var ID = (cbSearch.SelectedItem as Providers).id;
                dgvStorage.DataSource = AppData.DB.Items.Where(i => i.Providers == ID).ToList();
            }
        }

        private void dgvStorage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvStorage.Columns["Delete"].Index)
            {
                DialogResult
                    dialogResult = MessageBox.Show("Вы точно хотите удалить этот товар?", "Подтверждение", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    AppData.DB.Items.Remove((Items)dgvStorage.Rows[e.RowIndex].DataBoundItem);
                    AppData.DB.SaveChanges();

                    MessageBox.Show("Удалено!");

                    dgvStorage.DataSource = AppData.DB.Items.ToList();
                }
            }
            if (e.ColumnIndex == dgvStorage.Columns["Edit"].Index)
            {
                AppData.EditedID = ((Items)dgvStorage.Rows[e.RowIndex].DataBoundItem).ID;

                editStorageForm editStorageForm = new editStorageForm();
                editStorageForm.Show();
                this.Hide();
            }
        }
    }
}
