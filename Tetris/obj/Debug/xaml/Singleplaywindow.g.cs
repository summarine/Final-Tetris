﻿#pragma checksum "..\..\..\xaml\Singleplaywindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8C63F1AE8CF24018322CC0141CE6FB89"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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


namespace Tetris {
    
    
    /// <summary>
    /// Singleplaywindow
    /// </summary>
    public partial class Singleplaywindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\..\xaml\Singleplaywindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Tetris.Singleplaywindow Window;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\xaml\Singleplaywindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\xaml\Singleplaywindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gameGrid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\xaml\Singleplaywindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PreviewImage;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\xaml\Singleplaywindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playbtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\xaml\Singleplaywindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PauseBtn;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\xaml\Singleplaywindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StopBtn;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\xaml\Singleplaywindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Scoring_Board;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\xaml\Singleplaywindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement myMediaElement;
        
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
            System.Uri resourceLocater = new System.Uri("/Tetris;component/xaml/singleplaywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\xaml\Singleplaywindow.xaml"
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
            this.Window = ((Tetris.Singleplaywindow)(target));
            
            #line 7 "..\..\..\xaml\Singleplaywindow.xaml"
            this.Window.KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.gameGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.PreviewImage = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.playbtn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\xaml\Singleplaywindow.xaml"
            this.playbtn.Click += new System.Windows.RoutedEventHandler(this.StartBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PauseBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\xaml\Singleplaywindow.xaml"
            this.PauseBtn.Click += new System.Windows.RoutedEventHandler(this.PauseBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.StopBtn = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\xaml\Singleplaywindow.xaml"
            this.StopBtn.Click += new System.Windows.RoutedEventHandler(this.StopBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Scoring_Board = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.myMediaElement = ((System.Windows.Controls.MediaElement)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
