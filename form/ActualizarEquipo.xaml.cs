using sistem.form.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
    /// Lógica de interacción para ActualizarEquipo.xaml
    /// </summary>
    public partial class ActualizarEquipo : Window
    {
        clases.Equipo Equipo = new clases.Equipo();
        public ActualizarEquipo(clases.Equipo equipo)
        {
            InitializeComponent();
            Equipo = equipo;
            CargarDatosForm();
        }

        private void btnActualizarEquipo_Click(object sender, RoutedEventArgs e)
        {

            Equipo equipoTemporal = new();
            equipoTemporal.NombreEquipo = txtNombreEquipo.Text;
            equipoTemporal.CantidadJugadores = Convert.ToInt32(txtCantidadJugadores.Text);
            equipoTemporal.NombreDT = txtNombreDT.Text;
            equipoTemporal.TipoEquipo = txtTipoEquipo.Text;
            equipoTemporal.CapitanEquipo = txtCapitanEquipo.Text;
            equipoTemporal.TieneSub21 = checkTieneSUB21.IsChecked.Value ? true : false;
            
            // clases.Equipo equipo = new clases.Equipo(nombreEquipo, cantidadJugadores, nombreDT, tipoEquipo, capitanEquipo, tiene);
            int index = EquipoCollection.EquipoList.IndexOf(this.Equipo);
            EquipoCollection.EquipoList.RemoveAt(index);
            EquipoCollection.EquipoList.Insert(index, equipoTemporal);
            this.Close();
        }
        private void CargarDatosForm() 
        {
            txtCantidadJugadores.Text = this.Equipo.CantidadJugadores.ToString();
            txtCapitanEquipo.Text = this.Equipo.CapitanEquipo;
            txtNombreDT.Text = this.Equipo.NombreDT;
            txtNombreEquipo.Text = this.Equipo.NombreEquipo;
            checkTieneSUB21.IsChecked = (this.Equipo.TieneSub21) ? true : false;

        }
        private static Regex s_regex = new Regex("[^0-9]+");

        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }
    }
}
