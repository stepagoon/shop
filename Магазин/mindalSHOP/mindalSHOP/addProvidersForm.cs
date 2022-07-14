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
    public partial class addProvidersForm : Form
    {
        public addProvidersForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            providersForm providersForm = new providersForm();
            providersForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.TextLength>4 && tbAdress.TextLength>4 && tbPhone.TextLength>10)
            {
                var good = AppData.DB.Providers.Add(new Providers
                {
                    Name = tbName.Text,
                    Address = tbAdress.Text,
                    Phone = tbPhone.Text,
                    id = AppData.DB.Providers.Max(x => x.id) + 1,
                });


                AppData.DB.SaveChanges();
                MessageBox.Show("Поставщик добавлен!");

                this.Hide();
                providersForm providersForm = new providersForm();
                providersForm.Show();
            }
            else
            {
                MessageBox.Show("Данные введены некорректно!");
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number) && number !=8)
            {
                e.Handled = true;
            }
        }
    }
}
