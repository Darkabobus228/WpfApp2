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
    /// Логика взаимодействия для WinAddItemInventory.xaml
    /// </summary>
    public partial class WinAddItemInventory : Window
    {
        public Inventory NewInventory { get; } = new Inventory();
        public WinAddItemInventory()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(BoxDescription.Text) && !string.IsNullOrWhiteSpace(BoxDiscount.Text) &&
                    !string.IsNullOrWhiteSpace(BoxPrise.Text) && !string.IsNullOrWhiteSpace(BoxSize.Text) &&
                    !string.IsNullOrWhiteSpace(BoxType.Text))
            {
                NewInventory.Description = BoxDescription.Text;
                NewInventory.Discount = Convert.ToInt32(BoxDiscount.Text);
                NewInventory.Prise = Convert.ToInt32(BoxPrise.Text);
                NewInventory.Size = Convert.ToInt32(BoxSize.Text);
                NewInventory.Type = BoxType.Text;
                NewInventory.IsAvailable = BoxIsAvailable.IsChecked.Value;

                DialogResult = true;
                return;
            }
            else
            {
                MessageBox.Show("Не Всё поле");
            }


        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            return;
        }

    }
}
