﻿#pragma checksum "..\..\..\..\form\ActualizarEquipo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CC34B4B505A4AF29E62702E520EEA619A317DC05"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using sistem.form;


namespace sistem.form {
    
    
    /// <summary>
    /// ActualizarEquipo
    /// </summary>
    public partial class ActualizarEquipo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\form\ActualizarEquipo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreEquipo;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\form\ActualizarEquipo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCantidadJugadores;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\form\ActualizarEquipo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreDT;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\form\ActualizarEquipo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTipoEquipo;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\form\ActualizarEquipo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCapitanEquipo;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\form\ActualizarEquipo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkTieneSUB21;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\form\ActualizarEquipo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregarEquipo;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/sistem;component/form/actualizarequipo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\form\ActualizarEquipo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtNombreEquipo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtCantidadJugadores = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\..\form\ActualizarEquipo.xaml"
            this.txtCantidadJugadores.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtNombreDT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtTipoEquipo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtCapitanEquipo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.checkTieneSUB21 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.btnAgregarEquipo = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\form\ActualizarEquipo.xaml"
            this.btnAgregarEquipo.Click += new System.Windows.RoutedEventHandler(this.btnActualizarEquipo_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

