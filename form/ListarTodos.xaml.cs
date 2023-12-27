using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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

namespace sistem.form
{
    /// <summary>
    /// Lógica de interacción para ListarTodos.xaml
    /// </summary>
    public partial class ListarTodos : Window
    {
        public ListarTodos()
        {
            InitializeComponent();
            dgTodos.ItemsSource = clases.EquipoCollection.EquipoList;
            dgTodos.CanUserAddRows = false;
        }
        private void Window_Activated(object sender, EventArgs e)
        {
            dgTodos.Items.Refresh();
        }
        private void btnEliminarRegistro_Click(object sender, RoutedEventArgs e)
        {
            int index = dgTodos.SelectedIndex;
            clases.EquipoCollection.EquipoList.RemoveAt(index);
            dgTodos.Items.Refresh();
        }

        private void btnActualizarRegistro_Click(object sender, RoutedEventArgs e)
        {
           var equipoSeleccionado = (clases.Equipo)dgTodos.SelectedItem;
           ActualizarEquipo actualizar = new(equipoSeleccionado);
           actualizar.ShowDialog();
            dgTodos.Items.Refresh();
        }

    }
}
