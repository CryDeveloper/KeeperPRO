using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeeperPRO
{
    public partial class Applications
    {
        public string NumberApplication => "Заявка № " + ID_Application;
        public string DiscountApplication
        {
            get
            {
                string x = "" + Start_Date;
                if (End_Date != null)
                {
                    x += " - " + End_Date;
                }
                return x;
            }
        }

    }
}
