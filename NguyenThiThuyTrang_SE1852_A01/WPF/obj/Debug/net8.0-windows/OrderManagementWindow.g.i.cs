﻿#pragma checksum "..\..\..\OrderManagementWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "393B30EE2319642091044A73A75076D099ED2689"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Presentation;
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


namespace Presentation {
    
    
    /// <summary>
    /// OrderManagementWindow
    /// </summary>
    public partial class OrderManagementWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\OrderManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgOrders;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\OrderManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgOrderDetails;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\OrderManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCustomer;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\OrderManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbEmployee;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\OrderManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpOrderDate;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\OrderManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbProduct;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\OrderManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQuantity;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\OrderManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUnitPrice;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\OrderManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDiscount;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\OrderManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddOrder;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NguyenThiThuyTrangWPF;V1.0.0.0;component/ordermanagementwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\OrderManagementWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 21 "..\..\..\OrderManagementWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuExit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dgOrders = ((System.Windows.Controls.DataGrid)(target));
            
            #line 24 "..\..\..\OrderManagementWindow.xaml"
            this.dgOrders.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgOrders_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dgOrderDetails = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.cbCustomer = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.cbEmployee = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.dpOrderDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.cbProduct = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.txtQuantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtUnitPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txtDiscount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.btnAddOrder = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\OrderManagementWindow.xaml"
            this.btnAddOrder.Click += new System.Windows.RoutedEventHandler(this.btnAddOrder_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

