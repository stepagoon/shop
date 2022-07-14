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
    public partial class editStorageForm : Form
    {
        public editStorageForm()
        {
            InitializeComponent();

            cbProviders.DataSource = AppData.DB.Providers.ToList();
            cbProviders.DisplayMember = "Name";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            storageForm adminForm = new storageForm();
            adminForm.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (numericCountEdit.Text != "" && numericPriceEdit.Text != "" && tbItemEdit.TextLength>4)
            {
                var
                    item = AppData.DB.Items.Where(p => p.ID == AppData.EditedID).Single();

                item.Name = tbItemEdit.Text.Trim();
                item.Count = (int)numericCountEdit.Value;
                item.Price = numericPriceEdit.Value;
                item.Providers = ((Providers)cbProviders.SelectedItem).id;

                AppData.DB.SaveChanges();
                MessageBox.Show("Товар отредактирован!");

                this.Hide();
                storageForm adminForm = new storageForm();
                adminForm.Show();

               
            }
            else
            {
                MessageBox.Show("Данные введены некорректно!");
            }
        }
    }
}
