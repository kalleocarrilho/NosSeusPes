﻿#pragma checksum "..\..\..\View\CadastrarModelo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D65ECAA23755DC626C35A0E932028BFE5E171DDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TrabalhoC.View;


namespace TrabalhoC.View {
    
    
    /// <summary>
    /// CadastrarModelo
    /// </summary>
    public partial class CadastrarModelo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\View\CadastrarModelo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNome;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\CadastrarModelo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMaterial;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\CadastrarModelo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCor;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\CadastrarModelo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkCadarco;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\CadastrarModelo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPreco;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\CadastrarModelo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCadastrar;
        
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
            System.Uri resourceLocater = new System.Uri("/TrabalhoC;component/view/cadastrarmodelo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\CadastrarModelo.xaml"
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
            this.txtNome = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtMaterial = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtCor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.chkCadarco = ((System.Windows.Controls.CheckBox)(target));
            
            #line 17 "..\..\..\View\CadastrarModelo.xaml"
            this.chkCadarco.Checked += new System.Windows.RoutedEventHandler(this.chkCadarco_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtPreco = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnCadastrar = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\View\CadastrarModelo.xaml"
            this.btnCadastrar.Click += new System.Windows.RoutedEventHandler(this.btnCadastrar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
