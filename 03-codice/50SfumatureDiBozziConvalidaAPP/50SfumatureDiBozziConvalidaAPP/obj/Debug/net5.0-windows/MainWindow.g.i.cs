// Updated by XamlIntelliSenseFileGenerator 21/04/2022 13:27:39
#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0E79C7FC968631012DC5AECB174457F7E856FF92"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
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
using _50SfumatureDiBozziConvalidaAPP;


namespace _50SfumatureDiBozziConvalidaAPP
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 14 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;

#line default
#line hidden


#line 20 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock label2;

#line default
#line hidden


#line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCercaFile;

#line default
#line hidden


#line 30 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCalcolaSHA;

#line default
#line hidden


#line 39 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVerificaPGP;

#line default
#line hidden


#line 69 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image foto1;

#line default
#line hidden


#line 70 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image foto2;

#line default
#line hidden


#line 74 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image foto3;

#line default
#line hidden


#line 75 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image foto4;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/50SfumatureDiBozziConvalidaAPP;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.label1 = ((System.Windows.Controls.Label)(target));
                    return;
                case 2:
                    this.label2 = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 3:
                    this.btnCercaFile = ((System.Windows.Controls.Button)(target));

#line 21 "..\..\..\MainWindow.xaml"
                    this.btnCercaFile.Click += new System.Windows.RoutedEventHandler(this.btnCercaFile_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.btnCalcolaSHA = ((System.Windows.Controls.Button)(target));

#line 30 "..\..\..\MainWindow.xaml"
                    this.btnCalcolaSHA.Click += new System.Windows.RoutedEventHandler(this.btnCalcolaSHA_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.btnVerificaPGP = ((System.Windows.Controls.Button)(target));

#line 39 "..\..\..\MainWindow.xaml"
                    this.btnVerificaPGP.Click += new System.Windows.RoutedEventHandler(this.btnVerificaPGP_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.foto1 = ((System.Windows.Controls.Image)(target));
                    return;
                case 7:
                    this.foto2 = ((System.Windows.Controls.Image)(target));
                    return;
                case 8:
                    this.foto3 = ((System.Windows.Controls.Image)(target));
                    return;
                case 9:
                    this.foto4 = ((System.Windows.Controls.Image)(target));
                    return;
                case 10:
                    this.lblx = ((System.Windows.Controls.Label)(target));
                    return;
                case 11:
                    this.xxx = ((System.Windows.Controls.Grid)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button btnMostra;
        internal System.Windows.Controls.Button btnNascondi;
        internal System.Windows.Controls.Label lblx1;
        internal System.Windows.Controls.Label lblx2;
        internal System.Windows.Controls.Label lblx3;
        internal System.Windows.Controls.Label lblx4;
        internal System.Windows.Controls.Label lblx5;
        internal System.Windows.Controls.Label lblx6;
    }
}

