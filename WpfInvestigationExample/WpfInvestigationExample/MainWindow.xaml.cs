using System.ComponentModel;
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

namespace WpfInvestigationExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string nombre;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Nombre
        {
            get { return nombre; } 
            set { nombre = value;
                OnPropertyChanged("Nombre");
            } 
        }
        public MainWindow()
        {
            InitializeComponent();
            Nombre = "Guillermo";
            DataContext = this;

        }

        private void OnPropertyChanged(string propertyName)
        {

            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Nombre = "Hola " +  this.nombre;
        }
    }
}