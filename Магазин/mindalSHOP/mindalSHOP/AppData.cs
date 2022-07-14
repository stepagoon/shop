using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindalSHOP
{
    public static class AppData
    {
        public static kolesnikovEntities1
            DB = new kolesnikovEntities1();

        public static int
            UserID,
            UserRole,
            EditedID;
        public static string
            FullName,
            RoleName;
    }
}
