using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeeperPRO
{
    public partial class Visitors
    {
        public string FullnameVisitots => Firstname + " " + Surname + " " + Patronymic;
        public string Pasport => Seria.ToString() + Number.ToString();
    }
}
