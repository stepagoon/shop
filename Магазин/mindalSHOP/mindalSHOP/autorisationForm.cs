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
    public partial class autorisationForm : Form
    {

        public autorisationForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_Register_MouseClick(object sender, MouseEventArgs e)
        {
            registerForm registerForm = new registerForm();
            registerForm.Show();
            this.Hide();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var
                user = AppData.DB.Users.Where(p => p.Login == tbLogin.Text.Trim() && p.Password == mtbPassword.Text.Trim()).FirstOrDefault();

            if (user != null)
            {
                AppData.UserID = user.id;
                AppData.UserRole = (int) user.Role;
                AppData.FullName = user.FullName;
                AppData.RoleName = user.RoleName;
                
                menuForm menuForm = new menuForm();
                menuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
