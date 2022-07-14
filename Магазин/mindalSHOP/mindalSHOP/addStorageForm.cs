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
    public partial class addStorageForm : Form
    {
        public addStorageForm()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (numericCount.Text != "" && numericPrice.Text != "" && tbItem.TextLength>4)
            {
                var good = AppData.DB.Items.Add(new Items
                {
                    Name = tbItem.Text,
                    Count = int.Parse(numericCount.Text),
                    DateTime = dateTimePicker1.Value.Date,
                    Price = (decimal)double.Parse(numericPrice.Text),
                    Providers = ((Providers)cbProviders.SelectedItem).id,
                    ID = AppData.DB.Items.Max(x => x.ID) + 1,
                });

                AppData.DB.SaveChanges();
                MessageBox.Show("Товар добавлен!");

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
