﻿#pragma checksum "..\..\..\Windows\AddProdWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "84FEC13EAD0450E9831DC4AE2E74CFD81FAA0EF7A50FBD05AE6D249F7A2F281D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Bakery_Sanin_Cheprasov;
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


namespace Bakery_Sanin_Cheprasov {
    
    
    /// <summary>
    /// AddProdWindow
    /// </summary>
    public partial class AddProdWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Windows\AddProdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Windows\AddProdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgProduct;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\AddProdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnChooseImage;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Windows\AddProdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbNameProduct;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Windows\AddProdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbDisc;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Windows\AddProdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbCost;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Windows\AddProdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CMBTypeProduct;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Windows\AddProdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox check;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Windows\AddProdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddEdit;
        
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
            System.Uri resourceLocater = new System.Uri("/Bakery_Sanin_Cheprasov;component/windows/addprodwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AddProdWindow.xaml"
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
            this.tb1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.ImgProduct = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.BtnChooseImage = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Windows\AddProdWindow.xaml"
            this.BtnChooseImage.Click += new System.Windows.RoutedEventHandler(this.BtnChooseImage_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TbNameProduct = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TbDisc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TbCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.CMBTypeProduct = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.check = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            this.BtnAddEdit = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\..\Windows\AddProdWindow.xaml"
            this.BtnAddEdit.Click += new System.Windows.RoutedEventHandler(this.BtnAddEdit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

