﻿#pragma checksum "..\..\..\..\Dialogs\ProductAddDialog - Copy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5496FB19B9F108E80B8F649B2017C5D2ADACCC03"
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
    /// ProductAddDialog
    /// </summary>
    public partial class ProductAddDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\..\Dialogs\ProductAddDialog - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productName;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Dialogs\ProductAddDialog - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productDescription;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Dialogs\ProductAddDialog - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox productCategory;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Dialogs\ProductAddDialog - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productPrice;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Dialogs\ProductAddDialog - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Dialogs\ProductAddDialog - Copy.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ShopApp;V1.0.0.0;component/dialogs/productadddialog%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Dialogs\ProductAddDialog - Copy.xaml"
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
            this.productName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.productDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.productCategory = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.productPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\..\..\Dialogs\ProductAddDialog - Copy.xaml"
            this.productPrice.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Validation);
            
            #line default
            #line hidden
            return;
            case 5:
            this.okButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\Dialogs\ProductAddDialog - Copy.xaml"
            this.okButton.Click += new System.Windows.RoutedEventHandler(this.AddProduct);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

