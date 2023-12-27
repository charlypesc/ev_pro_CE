using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Lógica de interacción para AgregarEquipo.xaml
    /// </summary>
    public partial class AgregarEquipo : Window
    {
        public AgregarEquipo()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender,RoutedEventArgs e)
        {
            string nombreEquipo = txtNombreEquipo.Text;
            int cantidadJugadores = Convert.ToInt32(txtCantidadJugadores.Text);
            string nombreDT = txtNombreDT.Text;
            string tipoEquipo = txtTipoEquipo.Text;
            string capitanEquipo = txtCapitanEquipo.Text;
            bool tiene = checkTieneSUB21.IsChecked.Value ? true : false;

            clases.Equipo equipo = new clases.Equipo(nombreEquipo, cantidadJugadores, nombreDT, tipoEquipo, capitanEquipo, tiene);

            clases.EquipoCollection.EquipoList.Add(equipo);
            this.Close();
        }
        private static Regex s_regex = new Regex("[^0-9]+");

        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }
    }
}
