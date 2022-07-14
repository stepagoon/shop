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
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();

            labelWelcome.Text = "Привет, " + AppData.FullName + "!\nВаш уровень доступа: "+ AppData.RoleName;

            switch (AppData.UserRole)
            {
                case 1:
                    {
                        btnOrders.Visible = true;
                        btnStorage.Visible = true;
                        btnProdviders.Visible = true;
                    }
                    break;
                case 2:
                    {
                        btnOrders.Visible = true;
                    }
                    break;
                default:
                    {
                        btnOrders.Visible = false;
                        btnStorage.Visible = false;
                    }
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            autorisationForm autorisationForm = new autorisationForm();
            autorisationForm.Show();
            this.Hide();
        }
        private void btnCart_Click(object sender, EventArgs e)
        {
            cartForm cartForm = new cartForm();
            cartForm.Show();
            this.Hide();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            ordersForm orders1 = new ordersForm();
            orders1.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            storageForm adminForm = new storageForm();
            adminForm.Show();
            this.Hide();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            ìtemsForm goodsForm = new ìtemsForm();
            goodsForm.Show();
            this.Hide();
        }

        private void btnProdviders_Click(object sender, EventArgs e)
        {
            providersForm providersForm = new providersForm();
            providersForm.Show();
            this.Hide();
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            storageForm storageForm = new storageForm();
            storageForm.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ordersForm ordersForm = new ordersForm();
            ordersForm.Show();
            this.Hide();
        }
    }
}
