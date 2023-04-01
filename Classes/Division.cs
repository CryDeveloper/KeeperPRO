using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeeperPRO
{
    public partial class Division
    {
        public List<string> ListNameDivision {
            get
            {
                List<Division> divisions = BaseConnect.baseModel.Division.ToList();
                List<string> result = new List<string>();
                foreach (Division item in divisions)
                {
                    result.Add(item.Name_Division);
                }
                return result.ToList();
            }
         }
    }
}
