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
using KeeperPRO.StaticClasses;

namespace KeeperPRO.Forms
{

    /// <summary>
    /// Логика взаимодействия для PageCommonDepartament.xaml
    /// </summary>
    public partial class PageCommonDepartament : Page
    {
        List<Applications> applications;
        public PageCommonDepartament()
        {
            InitializeComponent();
            applications = BaseConnect.baseModel.Applications.ToList();
            ListApplication.ItemsSource = applications;
            InputDataDivisionInComboBox();
            InputDataStatusApllicationInComboBox();
            cbVisits.SelectedIndex = 0;
            cbDivision.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            applications = BaseConnect.baseModel.Applications.ToList();
            if (sender == cbVisits)
            {
                if(cbDivision.SelectedIndex != 0)
                {
                    applications = applications.Where(x => x.ID_Division == cbDivision.SelectedIndex).ToList();
                }
                if(cbStatus.SelectedIndex != 0)
                {
                    applications = applications.Where(x => x.ID_Status == cbStatus.SelectedIndex).ToList();
                }
                if (cbVisits.SelectedIndex != 0)
                {
                    switch (cbVisits.SelectedIndex)
                    {
                        case 1:
                            applications = applications.Where(x => x.ID_Group == null).ToList();
                            break;
                        case 2:
                            applications = applications.Where(x => x.ID_Group != null).ToList();
                            break;
                    }
                }
            }
            else if (sender == cbDivision)
            {
                if (cbStatus.SelectedIndex != 0)
                {
                    applications = applications.Where(x => x.ID_Status == cbStatus.SelectedIndex).ToList();
                }
                if (cbVisits.SelectedIndex != 0)
                {
                    switch (cbVisits.SelectedIndex)
                    {
                        case 1:
                            applications = applications.Where(x => x.ID_Group == null).ToList();
                            break;
                        case 2:
                            applications = applications.Where(x => x.ID_Group != null).ToList();
                            break;
                    }
                }
                if (cbDivision.SelectedIndex != 0)
                {
                    applications = applications.Where(x => x.ID_Division == cbDivision.SelectedIndex).ToList();
                }
            }
            else if (sender == cbStatus)
            {

                if (cbDivision.SelectedIndex != 0)
                {
                    applications = applications.Where(x => x.ID_Division == cbDivision.SelectedIndex).ToList();
                }
                if (cbVisits.SelectedIndex != 0)
                {
                    switch (cbVisits.SelectedIndex)
                    {
                        case 1:
                            applications = applications.Where(x => x.ID_Group == null).ToList();
                            break;
                        case 2:
                            applications = applications.Where(x => x.ID_Group != null).ToList();
                            break;
                    }
                }
                if (cbStatus.SelectedIndex != 0)
                {
                    applications = applications.Where(x => x.ID_Status == cbStatus.SelectedIndex).ToList();
                }
            }
            ListApplication.ItemsSource = applications;
        }

        /// <summary>
        /// Метод для заполнения значений ComboBox с подразделениями
        /// </summary>
        private void InputDataDivisionInComboBox()
        {
            List<Division> divisions = BaseConnect.baseModel.Division.ToList();
            List<string> result = new List<string>();
            result.Add("По умолчанию");
            foreach (Division item in divisions)
            {
                result.Add(item.Name_Division);
            }
            cbDivision.ItemsSource = result;
        }
        /// <summary>
        /// Метод для заполнения ComboBox с типами заявок
        /// </summary>
        private void InputDataStatusApllicationInComboBox()
        {
            List<StatusApplication> statuses = BaseConnect.baseModel.StatusApplication.ToList();
            List<string> listNameStatus = new List<string>();
            listNameStatus.Add("По умолчанию");
            foreach (StatusApplication item in statuses)
            {
                listNameStatus.Add(item.Name_Status);
            }
            cbStatus.ItemsSource = listNameStatus;
        }
        /// <summary>
        /// Метод для перехода в модальное окно проверки заявки при нажатии на кнопку "Проверить заявку".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNestApplication_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Applications appl = applications.FirstOrDefault(x => x.ID_Application == (int)button.Tag);
            Test test = new Test(appl); 
            /*При открытии модального окна, само включается ожидание его закрытия. После закрытия - нужно обновить отоброжение листа*/
            test.ShowDialog();
            ListApplication.ItemsSource = BaseConnect.baseModel.Applications.ToList();
        }
    }
}
