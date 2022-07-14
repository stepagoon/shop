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
    public partial class printForm : Form
    {
        public printForm(Orders order)
        {
            InitializeComponent();



            var currentItems = AppData.DB.OrdersParts.Where(i => i.UserID == order.UserID && order.ID == i.OrderID).ToList();
            var result = new StringBuilder();


            result.Append("<html>");
            result.Append("<meta charset='utf-8'/>");
            result.Append("<body>");

            result.Append("<p align='center'> <b>Отчет по деталям заказа</b> </p>");

            result.Append("<table width=100% margin-bottom='20px' border=1 bordercolor=#000 style='border-collapse:collapse;'>");

            result.Append("<tr>");
            result.Append("<td align=center><b>Номер вещи</b></td>");
            result.Append("<td align=center><b>Имя заказчика</b></td>");
            result.Append("<td align=center><b>Название товара</b></td>");
            result.Append("<td align=center><b>Количество</b></td>");
            result.Append("<td align=center><b>Время покупки</b></td>");
            result.Append("<td align=center><b>Стоимость одного товара</b></td>");
            result.Append("</tr>");


            foreach (var item in currentItems)
            {
                result.Append("<tr>");

                result.Append($"<td align=center>{item.ID}</td>");
                result.Append($"<td align=center>{item.NameUser}</td>");
                result.Append($"<td align=center>{item.NameItems}</td>");
                result.Append($"<td align=center>{item.Count}</td>");
                result.Append($"<td align=center>{item.DateTime}</td>");
                result.Append($"<td align=center>{item.Price}</td>");
                result.Append("</tr>");
            }
            result.Append("</table>");
            result.Append("<table width=100%>");
            result.Append("<p align='left'> <b>Реквизиты магазина:<br>ООО МИНДАЛЬ<br>ОГРН 1154632005043<br>ИНН 4632203806<br>КПП 463201001<br>ОКПО 21823645 </b> </p>");
            result.Append("</table>");
            result.Append("</body>");
            result.Append("</html>");

            printReport.DocumentText += result;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ordersForm ordersParts = new ordersForm();
            ordersParts.Show();
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printReport.Print();
        }
    }
}
