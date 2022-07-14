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
    public partial class providersForm : Form
    {
        public providersForm()
        {
            InitializeComponent();
            dtgProvisers.DataSource = AppData.DB.Providers.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menuForm menuForm = new menuForm();
            menuForm.Show();
            this.Hide();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addProvidersForm addProvidersForm = new addProvidersForm();
            addProvidersForm.Show();
            this.Hide();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dtgProvisers.DataSource = AppData.DB.Providers.Where(i => i.Name.Contains(tbSearch.Text)).ToList();
        }

        private void dtgProvisers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgProvisers.Columns["Delete"].Index)
            {
                DialogResult
                    dialogResult = MessageBox.Show("Вы точно хотите удалить это из заказа?", "Подтверждение", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    AppData.DB.Providers.Remove((Providers)dtgProvisers.Rows[e.RowIndex].DataBoundItem);
                    AppData.DB.SaveChanges();

                    MessageBox.Show("Удалено!");

                    dtgProvisers.DataSource = AppData.DB.Providers.ToList();
                }
            }
            if (e.ColumnIndex == dtgProvisers.Columns["Edit"].Index)
            {
                AppData.EditedID = ((Providers)dtgProvisers.Rows[e.RowIndex].DataBoundItem).id;

                editProvidersForm
                    editProviders = new editProvidersForm();

                editProviders.Show();
                this.Hide();
            }
        }
    }
    }

