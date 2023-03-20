using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeeperPRO.Forms
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        ATaran_KII_DemExEntities entities;
        List<Employees> listEmployees;
        public AuthorizationPage()
        {
            InitializeComponent();
            entities = new ATaran_KII_DemExEntities();
            listEmployees = entities.Employees.ToList();
            int code = Convert.ToInt32(tbCodeEmployee.Text);
            Employees employees = entities.Employees.FirstOrDefault(x=>x.Code_Employee== code); //для проверки есть ли значение в списке
            //есть еще where, который как select
            if (employees!=null)
            {
                employees.ID_Departament
            }
            else
            {

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
        }
    }
}
