﻿#pragma checksum "..\..\mainView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0BF504B719D4D5668E8B498647388F5B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.0
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


namespace tetrisWPF {
    
    
    /// <summary>
    /// mainView
    /// </summary>
    public partial class mainView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\mainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\mainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid generalSpace;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\mainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Background;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\mainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid optionSpace;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\mainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox score;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\mainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label previewLabel;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\mainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid previewSpace;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\mainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button optionsButton;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\mainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitButton;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\mainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border gameBorder;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\mainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gameSpace;
        
        #line default
        #line hidden
        
        
        #line 225 "..\..\mainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Line verticalLine;
        
        #line default
        #line hidden
        
        
        #line 231 "..\..\mainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border generalBorder;
        
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
            System.Uri resourceLocater = new System.Uri("/tetrisWPF;component/mainview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\mainView.xaml"
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
            
            #line 5 "..\..\mainView.xaml"
            ((tetrisWPF.mainView)(target)).Initialized += new System.EventHandler(this.mainView_Initialized);
            
            #line default
            #line hidden
            
            #line 5 "..\..\mainView.xaml"
            ((tetrisWPF.mainView)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.view_KeyDown);
            
            #line default
            #line hidden
            
            #line 5 "..\..\mainView.xaml"
            ((tetrisWPF.mainView)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.main_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 5 "..\..\mainView.xaml"
            ((tetrisWPF.mainView)(target)).KeyUp += new System.Windows.Input.KeyEventHandler(this.Window_KeyUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.generalSpace = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.Background = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.optionSpace = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.score = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.previewLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.previewSpace = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.optionsButton = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\mainView.xaml"
            this.optionsButton.Click += new System.Windows.RoutedEventHandler(this.optionsButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.exitButton = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\mainView.xaml"
            this.exitButton.Click += new System.Windows.RoutedEventHandler(this.exitButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.gameBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 12:
            this.gameSpace = ((System.Windows.Controls.Grid)(target));
            return;
            case 13:
            this.verticalLine = ((System.Windows.Shapes.Line)(target));
            return;
            case 14:
            this.generalBorder = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

