﻿#pragma checksum "..\..\..\Vistas\InicioView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D8E243E2B33C77C8CBACBB73DF5D8935DEEE4B6E056D06F7D070394DF1794AFD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Presentacion.Vistas;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Presentacion.Vistas {
    
    
    /// <summary>
    /// InicioView
    /// </summary>
    public partial class InicioView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Vistas\InicioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_descripcion;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Vistas\InicioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Imagen;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Vistas\InicioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_titulo;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Vistas\InicioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Derecha_tbn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Vistas\InicioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Izquierda_tbn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Presentacion;component/vistas/inicioview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vistas\InicioView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.label_descripcion = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Imagen = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.label_titulo = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Derecha_tbn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Vistas\InicioView.xaml"
            this.Derecha_tbn.Click += new System.Windows.RoutedEventHandler(this.Derecha_tbn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Izquierda_tbn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Vistas\InicioView.xaml"
            this.Izquierda_tbn.Click += new System.Windows.RoutedEventHandler(this.Izquierda_tbn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

