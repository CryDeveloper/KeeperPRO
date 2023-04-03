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
    /// Логика взаимодействия для PageSecurityDepartment.xaml
    /// </summary>
    public partial class PageSecurityDepartment : Page
    {
        List<Applications> applications = new List<Applications>();
        public PageSecurityDepartment()
        {
            InitializeComponent();
            applications = BaseConnect.baseModel.Applications.Where(x => x.ID_Status == BaseConnect.baseModel.StatusApplication.FirstOrDefault(s => s.Name_Status == "Одобрена").ID_Status).ToList();
            ListApplication.ItemsSource = applications;
            InputDataDivisionInComboBox();
            cbVisits.SelectedIndex = 0;
            cbDivision.SelectedIndex = 0;
            cbDate.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            applications = BaseConnect.baseModel.Applications.ToList();
            if (sender == cbVisits)
            {
                if (cbDivision.SelectedIndex != 0)
                {
                    applications = applications.Where(x => x.ID_Division == cbDivision.SelectedIndex).ToList();
                }
                if (cbDate.SelectedIndex != 0)
                {
                    switch (cbDate.SelectedIndex)
                    {
                        case 1:
                            applications = applications.OrderBy(x => x.Start_Date).ToList();
                            break;
                        case 2:
                            applications = applications.OrderByDescending(x => x.Start_Date).ToList();
                            break;
                    }
                    
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
                if (cbDate.SelectedIndex != 0)
                {
                    switch (cbDate.SelectedIndex)
                    {
                        case 1:
                            applications = applications.OrderBy(x => x.Start_Date).ToList();
                            break;
                        case 2:
                            applications = applications.OrderByDescending(x => x.Start_Date).ToList();
                            break;
                    }

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
            else if (sender == cbDate)
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
                if (cbDate.SelectedIndex != 0)
                {
                    switch (cbDate.SelectedIndex)
                    {
                        case 1:
                            applications = applications.OrderBy(x => x.Start_Date).ToList();
                            break;
                        case 2:
                            applications = applications.OrderByDescending(x => x.Start_Date).ToList();
                            break;
                    }
                }
            }
            ListApplication.ItemsSource = applications;
        }
        private void ComboBox_SelectionChanged1()
        {
            applications = BaseConnect.baseModel.Applications.ToList();
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
            if (cbDate.SelectedIndex != 0)
            {
                switch (cbDate.SelectedIndex)
                {
                    case 1:
                        applications = applications.OrderBy(x => x.Start_Date).ToList();
                        break;
                    case 2:
                        applications = applications.OrderByDescending(x => x.Start_Date).ToList();
                        break;
                }
            }
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

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text != "" && textBox.Text != null)
            {
                applications = applications.Where(x => x.Visitors.FullnameVisitots.ToLower().Contains(textBox.Text.ToLower()) || x.Visitors.Pasport.Contains(textBox.Text)).ToList();
            }
            else 
            {
                ComboBox_SelectionChanged1();
            }
            ListApplication.ItemsSource = applications;
        }

        private void btnEntry_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
