﻿#pragma checksum "..\..\doublepeople.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F9059CE8F4D1A1F3D6220B440B0B9160"
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
    /// doublepeople
    /// </summary>
    public partial class doublepeople : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\doublepeople.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid myGrid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\doublepeople.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid aiGrid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\doublepeople.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Startbtn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\doublepeople.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pausebtn;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\doublepeople.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Stopbtn;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\doublepeople.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PreviewImage;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\doublepeople.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PreviewImage1;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\doublepeople.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PlayerScoreLabel;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\doublepeople.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AIScoreLabel;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\doublepeople.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mySoundPlayer;
        
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
            System.Uri resourceLocater = new System.Uri("/Tetris;component/doublepeople.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\doublepeople.xaml"
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
            
            #line 6 "..\..\doublepeople.xaml"
            ((Tetris.doublepeople)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.myGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.aiGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.Startbtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\doublepeople.xaml"
            this.Startbtn.Click += new System.Windows.RoutedEventHandler(this.StartButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Pausebtn = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\doublepeople.xaml"
            this.Pausebtn.Click += new System.Windows.RoutedEventHandler(this.PauseBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Stopbtn = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\doublepeople.xaml"
            this.Stopbtn.Click += new System.Windows.RoutedEventHandler(this.StopButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PreviewImage = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.PreviewImage1 = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.PlayerScoreLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.AIScoreLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.mySoundPlayer = ((System.Windows.Controls.MediaElement)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

