using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindalSHOP
{
    public partial class OrdersParts
    {
        public string NameItems
        {
            get
            {
                return Items.Name;
            }
        }
        public string NameUser
        {
            get
            {
                return Orders.UserName;
            }
        }
        public string DateTime
        {
            get
            {
                return Convert.ToString(Orders.DateTime);
            }
        }
        public string Price
        {
            get
            {
                return Convert.ToString(Items.Price);
            }
        }
    }
}
