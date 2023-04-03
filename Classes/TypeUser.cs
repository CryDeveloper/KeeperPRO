using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KeeperPRO
{
    public partial class TypeUser
    {

        public List<string> AlType
        {
            get 
            {
            List<KeeperPRO.TypeUser> alType = BaseConnect.baseModel.TypeUser.ToList();
                List<string> result = new List<string>();
                foreach (var item in alType)
                {
                    result.Add(item.TypeUser1);
                }
                return result;
            }
        }

    }
    public partial class Users
    {
        public int Name
        {
            get => (int)ID_TypeUser-1;
            set 
            {
                MessageBox.Show("Я зашел");
                //string s = value;
                //ID_TypeUser = BaseConnect.baseModel.TypeUser.FirstOrDefault(x => x.TypeUser1 == value).ID_TypeUser;
            }
        }

    }
}
