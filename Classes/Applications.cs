using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KeeperPRO
{
    public partial class Applications
    {
        public string NumberApplication => "Заявка № " + ID_Application.ToString();
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
            set 
            {    
                   Start_Date = Convert.ToDateTime(value);
            }
        }
        public string FIO
        {
            get
            {
                return Visitors.FullnameVisitots;//
            }
        }

        public List<Visitors> visitorsGroup
        {
            get
            {
                if(ID_Group == null)
                {
                    return null;
                }
                List<Visits> visits = BaseConnect.baseModel.Visits.Where(x => x.ID_Group == ID_Group).ToList();
                List<Visitors> visitors = new List<Visitors>();
                foreach (Visits item in visits)
                {
                    visitors.Add(BaseConnect.baseModel.Visitors.FirstOrDefault(x => x.ID_Visitor == item.ID_Visitor));
                }
                return visitors.ToList();
            }
        }
    }
}
