using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2.Data;
using WpfApp2.Model;
using WpfApp2.view;

namespace WpfApp2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public ApplicationContext context;
    public MainWindow()
    {
        InitializeComponent();
        context = new ApplicationContext();
        ListViewInventory.ItemsSource = context.Inventories.Local.ToObservableCollection();
    }
    
    private void Button_newInv_click(object sender, RoutedEventArgs e)
    {
        WinAddItemInventory addItemInventory = new WinAddItemInventory();

        addItemInventory.ShowDialog();
        if(addItemInventory.DialogResult == true)
        {
            context.Inventories.Add(addItemInventory.NewInventory);
            context.SaveChanges();
        }

    }

    private void Button_addComp_Click(object sender, RoutedEventArgs e)
    {
        Comp comp = new Comp(context.Companies.ToList());
        comp.ShowDialog();
        if(comp.DialogResult == true)
        {
            ((Inventory)ListViewInventory.SelectedItem).Company = comp.selectedCompany;
            context.SaveChanges();
        }
    }
}