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
    public partial class editProvidersForm : Form
    {
        public editProvidersForm()
        {
            InitializeComponent();

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            providersForm providersForm = new providersForm();
            providersForm.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbNameEdit.TextLength > 4 && tbAdressEdit.TextLength > 4 && tbPhoneEdit.TextLength > 11)
            {
                var
                    providers = AppData.DB.Providers.Where(p => p.id == AppData.EditedID).Single();

                providers.Name = tbNameEdit.Text.Trim();
                providers.Address = tbAdressEdit.Text.Trim();
                providers.Phone = tbPhoneEdit.Text.Trim();

                AppData.DB.SaveChanges();
                MessageBox.Show("Поставщик отредактирован!");

                this.Hide();
                providersForm providersForm = new providersForm();
                providersForm.Show();


            }
            else
            {
                MessageBox.Show("Данные введены некорректно!");
            }
        }

        private void tbPhoneEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
