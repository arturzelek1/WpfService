﻿#pragma checksum "..\..\..\..\Dialogs\ClientAddDialog - Copy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AC08F855E07338C0218966FDE48CBAACDB4E59EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ShopApp;
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


namespace ShopApp {
    
    
    /// <summary>
    /// ClientAddDialog
    /// </summary>
    public partial class ClientAddDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\Dialogs\ClientAddDialog - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox clientName;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Dialogs\ClientAddDialog - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox clientAdress;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Dialogs\ClientAddDialog - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox clientRabat;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Dialogs\ClientAddDialog - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Dialogs\ClientAddDialog - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ShopApp;V1.0.0.0;component/dialogs/clientadddialog%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Dialogs\ClientAddDialog - Copy.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.clientName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.clientAdress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.clientRabat = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\..\..\Dialogs\ClientAddDialog - Copy.xaml"
            this.clientRabat.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Validation);
            
            #line default
            #line hidden
            return;
            case 4:
            this.okButton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\Dialogs\ClientAddDialog - Copy.xaml"
            this.okButton.Click += new System.Windows.RoutedEventHandler(this.AddClient);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

