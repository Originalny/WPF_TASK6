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
using WPF_TASK6.ViewModels;

namespace WPF_TASK6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _vm;
        public MainWindow()
        {
            InitializeComponent();
            _vm = new MainViewModel();
            DataContext = _vm;
        }

        private MainViewModel VM => (MainViewModel)DataContext;

        private void Add_Click(object sender, RoutedEventArgs e) => VM.AddUser();
        private void Add_Remove(object sender, RoutedEventArgs e) => VM.RemoveSelectedUser();
    }
}