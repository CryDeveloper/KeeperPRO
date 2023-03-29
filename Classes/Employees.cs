using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeeperPRO
{
    public partial class Employees
    {
        public string FullnameEmploye => Surname + " " + Firstname + " " + Patronymic;
    }
}
