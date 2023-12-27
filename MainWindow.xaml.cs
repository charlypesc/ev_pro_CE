using sistem.form;
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

namespace sistem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //dgVistaPrincipal.ItemsSource = form.clases.EquipoCollection.EquipoList;
            //dgVistaPrincipal.CanUserAddRows = false;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void AbrirAgregar(object sender, RoutedEventArgs e) 
        {
           AgregarEquipo agregarEquipo = new AgregarEquipo();
            agregarEquipo.ShowDialog();
        }
        private void AbrirListar(object sender, RoutedEventArgs e) 
        {
            ListarTodos listarTodos = new ListarTodos();
            listarTodos.ShowDialog();
        }
        private void Window_Activated(object sender, EventArgs e)
        {
           //dgVistaPrincipal.Items.Refresh();
        }
    }
}