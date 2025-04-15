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
using WpfApp2.Model;

namespace WpfApp2.view
{
    /// <summary>
    /// Логика взаимодействия для Comp.xaml
    /// </summary>
    public partial class Comp : Window
    {
        public Company selectedCompany;
        public Comp(List<Company> companies)
        {
            InitializeComponent();
            ComboBox_Companis.ItemsSource = companies;
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBox_Companis.SelectedItem != null)
            {
                selectedCompany = (Company)ComboBox_Companis.SelectedItem;
                DialogResult = true;
                return;
            }
            else
            {
                MessageBox.Show("Добавление компании");
            }
        }

        private void Button_Cansel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            return;
        }
    }
}
