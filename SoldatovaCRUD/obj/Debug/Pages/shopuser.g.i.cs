﻿#pragma checksum "..\..\..\Pages\shopuser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B387FD76B99AFD97C7E77C618EEA1F4410D7BDE262F839F40461CFBAD417D849"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SoldatovaCRUD.Pages;
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


namespace SoldatovaCRUD.Pages {
    
    
    /// <summary>
    /// shopuser
    /// </summary>
    public partial class shopuser : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\shopuser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVOrder;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Pages\shopuser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Orderview;
        
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
            System.Uri resourceLocater = new System.Uri("/SoldatovaCRUD;component/pages/shopuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\shopuser.xaml"
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
            this.LVOrder = ((System.Windows.Controls.ListView)(target));
            
            #line 19 "..\..\..\Pages\shopuser.xaml"
            this.LVOrder.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MyListView_MouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 22 "..\..\..\Pages\shopuser.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.orderButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Orderview = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\Pages\shopuser.xaml"
            this.Orderview.Click += new System.Windows.RoutedEventHandler(this.orderview);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
