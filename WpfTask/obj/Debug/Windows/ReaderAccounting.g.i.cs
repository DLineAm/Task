﻿#pragma checksum "..\..\..\Windows\ReaderAccounting.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8204F5225491C48BDA823E240AB9D05171AEF90A9621CD4ACDE201E5E75E037C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfTask.Windows;


namespace WpfTask.Windows {
    
    
    /// <summary>
    /// ReaderAccounting
    /// </summary>
    public partial class ReaderAccounting : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Windows\ReaderAccounting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TitleLb;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Windows\ReaderAccounting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Windows\ReaderAccounting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBookBtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Windows\ReaderAccounting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleBookBtn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Windows\ReaderAccounting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstNameTB;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Windows\ReaderAccounting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameTB;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Windows\ReaderAccounting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MiddleNameTB;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Windows\ReaderAccounting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BooksTB;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfTask;component/windows/readeraccounting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ReaderAccounting.xaml"
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
            this.TitleLb = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ApplyBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Windows\ReaderAccounting.xaml"
            this.ApplyBtn.Click += new System.Windows.RoutedEventHandler(this.ApplyBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddBookBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Windows\ReaderAccounting.xaml"
            this.AddBookBtn.Click += new System.Windows.RoutedEventHandler(this.AddBookBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleBookBtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Windows\ReaderAccounting.xaml"
            this.DeleBookBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteBookBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FirstNameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.LastNameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.MiddleNameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.BooksTB = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

