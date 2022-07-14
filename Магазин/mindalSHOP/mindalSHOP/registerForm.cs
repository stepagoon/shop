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
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            autorisationForm autorisationForm = new autorisationForm();
            autorisationForm.Show();
            this.Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            if(tbFirstName.TextLength > 4 && tbSecondName.TextLength > 4 && tbNumber.TextLength > 10 && tbLoginReg.TextLength > 4 && tbPasswordReg.TextLength > 4)
            {
                
                var user = AppData.DB.Users.Add(new Users
                {
                    FirstName = tbFirstName.Text,
                    LastName = tbSecondName.Text,
                    PhoneNumber = tbNumber.Text,
                    Login = tbLoginReg.Text,
                    Password = tbPasswordReg.Text,
                    id = AppData.DB.Users.Max(x => x.id) + 1,
                    Role = 3

                });
                AppData.DB.SaveChanges();
                MessageBox.Show("Вы зарегистрировались!");

                this.Hide();
                autorisationForm autorisationForm = new autorisationForm();
                autorisationForm.Show();
            }
            else
            {
                MessageBox.Show("Данные введены некорректно");
            }
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char name = e.KeyChar;
            if ((name < 'А' || name > 'я') && name != '\b' && name != '.')
            {
                e.Handled = true;
            }
        }

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void tbSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char surrname = e.KeyChar;
            if ((surrname < 'А' || surrname > 'я') && surrname != '\b' && surrname != '.')
            {
                e.Handled = true;
            }
        }
    }
}
