using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            session4.ItemsSource = BaseConnect.baseModel.Users.ToList();
            //List<KeeperPRO.TypeUser> alType = BaseConnect.baseModel.TypeUser.ToList();
            //List<string> result = new List<string>();
            //foreach (var item in alType)
            //{
            //    result.Add(item.TypeUser1);
            //}
            //  typeUserCombo.ItemsSource = result;
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var b = BaseConnect.baseModel.Users.ToList();
            BaseConnect.baseModel.SaveChanges();
            MessageBox.Show("Одобрили");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int id = (int)comboBox.Tag;
            Users users = BaseConnect.baseModel.Users.FirstOrDefault(x=>x.ID == id);
            users.ID_TypeUser = comboBox.SelectedIndex+1;
           // MessageBox.Show(comboBox.SelectedItem.ToString());
        }
    }
}
