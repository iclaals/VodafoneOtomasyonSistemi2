﻿#pragma checksum "..\..\Hat1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C2A18D127831AB4B535C597F19AD1F2984756B85EB774419929400866001D09D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using GörselProgramlamaFinal;
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


namespace GörselProgramlamaFinal {
    
    
    /// <summary>
    /// Hat
    /// </summary>
    public partial class Hat : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\Hat1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHome;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\Hat1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAd;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\Hat1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSoyad;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\Hat1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtKimlik;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Hat1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSehir;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\Hat1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ID;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\Hat1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtId;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\Hat1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgHat;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\Hat1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEkle;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\Hat1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSil;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\Hat1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuncelle;
        
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
            System.Uri resourceLocater = new System.Uri("/GörselProgramlamaFinal;component/hat1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Hat1.xaml"
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
            this.btnHome = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Hat1.xaml"
            this.btnHome.Click += new System.Windows.RoutedEventHandler(this.btnHome_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtAd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtSoyad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtKimlik = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtSehir = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ID = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.txtId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.dgHat = ((System.Windows.Controls.DataGrid)(target));
            
            #line 95 "..\..\Hat1.xaml"
            this.dgHat.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgHat_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnEkle = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\Hat1.xaml"
            this.btnEkle.Click += new System.Windows.RoutedEventHandler(this.btnEkle_Click_1);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnSil = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\Hat1.xaml"
            this.btnSil.Click += new System.Windows.RoutedEventHandler(this.btnSil_Click_1);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnGuncelle = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\Hat1.xaml"
            this.btnGuncelle.Click += new System.Windows.RoutedEventHandler(this.btnGuncelle_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

