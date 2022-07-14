using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindalSHOP
{
    public partial class Users
    {
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string RoleName
        {
            get
            {
                return Roles.Role;
            }
        }
       
    }
    public partial class Cart
    {
        public string ItemName
        {
            get
            {
                return Items.Name;
            }
        }
        public string UserName
        {
            get
            {
                return Users.FullName;
            }
        }
    }
    public partial class Orders
    {
        public string UserName
        {
            get
            {
                return Users.FullName;
            }
        }
    }
}
