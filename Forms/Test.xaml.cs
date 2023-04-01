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
using System.Windows.Shapes;

namespace KeeperPRO.Forms
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        Applications appl;
       
        public Test(Applications appl)
        {
            InitializeComponent();
            this.appl = appl;
            DataContext = appl;
            cbStatus.ItemsSource = BaseConnect.baseModel.StatusApplication.ToList();
            cbStatus.DisplayMemberPath = "Name_Status";
            cbStatus.SelectedValuePath = "ID_Status";
            CheckPersonInBlackList();
            //cbStatus.SelectedValue = appl.StatusApplication.Name_Status;
            //  MessageBox.Show(appl.FIO);
        }

        private void CheckPersonInBlackList()
        {
            BlackList inBlackListFromApplication = BaseConnect.baseModel.BlackList.FirstOrDefault(x => x.ID_Visitor == appl.ID_Visitors);
            if(inBlackListFromApplication != null)
            {
                dpDateVisit.IsEnabled = false;
                appl.ID_Status = 3;
                cbStatus.IsEnabled = false;
                MessageBox.Show("Посетитель в черном списке!");
                return;
            }
            MessageBox.Show("Посетителя нет в черном списке.");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //BaseConnect.baseModel.SaveChanges();

        }
    }
}
