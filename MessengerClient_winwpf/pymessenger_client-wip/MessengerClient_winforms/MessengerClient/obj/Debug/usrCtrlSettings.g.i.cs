﻿#pragma checksum "..\..\usrCtrlSettings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D4C7EB0BD8EA30C467E6FDFD84EEBCD256EDA8FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MessengerClient;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
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


namespace MessengerClient {
    
    
    /// <summary>
    /// usrCtrlSettings
    /// </summary>
    public partial class usrCtrlSettings : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 7 "..\..\usrCtrlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MessengerClient.usrCtrlSettings userControl;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\usrCtrlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnApply;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\usrCtrlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\usrCtrlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOk;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\usrCtrlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDefaults;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\usrCtrlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink lnkAbout;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\usrCtrlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAddress;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\usrCtrlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPort;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\usrCtrlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.NumericUpDown numUpDownPort;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\usrCtrlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkboxEncryption;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\usrCtrlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkboxSpellCheck;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\usrCtrlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.PropertyGrid propertyGrdMySettings;
        
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
            System.Uri resourceLocater = new System.Uri("/MessengerClient;component/usrctrlsettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\usrCtrlSettings.xaml"
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
            this.userControl = ((MessengerClient.usrCtrlSettings)(target));
            
            #line 9 "..\..\usrCtrlSettings.xaml"
            this.userControl.Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 17 "..\..\usrCtrlSettings.xaml"
            ((System.Windows.Media.Animation.Storyboard)(target)).Completed += new System.EventHandler(this.Storyboard_Completed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnApply = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\usrCtrlSettings.xaml"
            this.btnApply.Click += new System.Windows.RoutedEventHandler(this.btnApply_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\usrCtrlSettings.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnOk = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\usrCtrlSettings.xaml"
            this.btnOk.Click += new System.Windows.RoutedEventHandler(this.btnApply_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDefaults = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\usrCtrlSettings.xaml"
            this.btnDefaults.Click += new System.Windows.RoutedEventHandler(this.btnDefaults_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lnkAbout = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 40 "..\..\usrCtrlSettings.xaml"
            this.lnkAbout.Click += new System.Windows.RoutedEventHandler(this.lnkAbout_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtAddress = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\usrCtrlSettings.xaml"
            this.txtAddress.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtAddress_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtPort = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.numUpDownPort = ((System.Windows.Forms.NumericUpDown)(target));
            
            #line 56 "..\..\usrCtrlSettings.xaml"
            this.numUpDownPort.ValueChanged += new System.EventHandler(this.numUpDownPort_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.chkboxEncryption = ((System.Windows.Controls.CheckBox)(target));
            
            #line 59 "..\..\usrCtrlSettings.xaml"
            this.chkboxEncryption.Click += new System.Windows.RoutedEventHandler(this.chkboxEncryption_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.chkboxSpellCheck = ((System.Windows.Controls.CheckBox)(target));
            
            #line 69 "..\..\usrCtrlSettings.xaml"
            this.chkboxSpellCheck.Click += new System.Windows.RoutedEventHandler(this.chkboxSpellCheck_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.propertyGrdMySettings = ((System.Windows.Forms.PropertyGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 2:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseWheelEvent;
            
            #line 12 "..\..\usrCtrlSettings.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseWheelEventHandler(this.ScrollViewer_PreviewMouseWheel);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

