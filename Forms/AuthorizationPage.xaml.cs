using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int code = -1;
            try
            {
                code = Convert.ToInt32(tbCodeEmployee.Text);
            }
            catch (Exception exc)
            {
                exc = new Exception("Проблема при преобразовании кода");
            }
            Employees employees = entities.Employees.FirstOrDefault(x => x.Code_Employee == code); //для проверки есть ли значение в списке
            //есть еще where, который как select
            if (employees != null)
            {
                Departament commonDepartament = entities.Departament.FirstOrDefault(x => x.Name_Departament == "Общий отдел");
                Departament securityDepartament = entities.Departament.FirstOrDefault(x => x.Name_Departament == "Охрана");
                if (employees.ID_Departament == commonDepartament.ID_Departament)
                {
                    
                }
                else if (employees.ID_Departament == securityDepartament.ID_Departament)
                {
                    MessageBox.Show("Охрана");
                }
                else
                {
                    MessageBox.Show("Для такого сотрудника доступа нет");
                }
            }
            else
            {
                MessageBox.Show("Неверный код");
            }
        }
    }
}
