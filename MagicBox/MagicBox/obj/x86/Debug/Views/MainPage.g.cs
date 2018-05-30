﻿#pragma checksum "C:\Users\zhangziquan\source\repos\MagicBox\MagicBox\MagicBox\Views\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "11C162B6ACB58A1F81907AA7D908E14F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagicBox.Views
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj26_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::MagicBox.Models.Model dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj26;
            private global::Windows.UI.Xaml.Controls.Image obj27;
            private global::Windows.UI.Xaml.Controls.TextBlock obj28;
            private global::Windows.UI.Xaml.Controls.TextBlock obj29;

            private MainPage_obj26_BindingsTracking bindingsTracking;

            public MainPage_obj26_Bindings()
            {
                this.bindingsTracking = new MainPage_obj26_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 26: // Views\MainPage.xaml line 68
                        this.obj26 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.UserControl)target);
                        break;
                    case 27: // Views\MainPage.xaml line 75
                        this.obj27 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 28: // Views\MainPage.xaml line 83
                        this.obj28 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 29: // Views\MainPage.xaml line 84
                        this.obj29 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj26.Target as global::Windows.UI.Xaml.Controls.UserControl).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::MagicBox.Models.Model) item, 1 << phase);
            }

            public void Recycle()
            {
                this.bindingsTracking.ReleaseAllListeners();
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::MagicBox.Models.Model)newDataRoot;
                    return true;
                }
                return false;
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MagicBox.Models.Model obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_photoUri(obj.photoUri, phase);
                        this.Update_musicName(obj.musicName, phase);
                        this.Update_date(obj.date, phase);
                    }
                }
            }
            private void Update_photoUri(global::System.Uri obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\MainPage.xaml line 75
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj27, (global::Windows.UI.Xaml.Media.ImageSource)this.LookupConverter("UriToImage").Convert(obj, typeof(global::Windows.UI.Xaml.Media.ImageSource), null, null), null);
                }
            }
            private void Update_musicName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\MainPage.xaml line 83
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj28, obj, null);
                }
            }
            private void Update_date(global::System.DateTimeOffset obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\MainPage.xaml line 84
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj29, (global::System.String)this.LookupConverter("DateToString").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MainPage_obj26_BindingsTracking
            {
                private global::System.WeakReference<MainPage_obj26_Bindings> weakRefToBindingObj; 

                public MainPage_obj26_BindingsTracking(MainPage_obj26_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MainPage_obj26_Bindings>(obj);
                }

                public MainPage_obj26_Bindings TryGetBindingObject()
                {
                    MainPage_obj26_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj26_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::MagicBox.Models.Model obj = sender as global::MagicBox.Models.Model;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_photoUri(obj.photoUri, DATA_CHANGED);
                                bindings.Update_musicName(obj.musicName, DATA_CHANGED);
                                bindings.Update_date(obj.date, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "photoUri":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_photoUri(obj.photoUri, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "musicName":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_musicName(obj.musicName, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "date":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_date(obj.date, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::MagicBox.Models.Model obj)
                {
                    MainPage_obj26_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::MagicBox.Views.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj22;

            public MainPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 22: // Views\MainPage.xaml line 65
                        this.obj22 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::MagicBox.Views.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MagicBox.Views.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::MagicBox.ViewModels.MainViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_AllItems(obj.AllItems, phase);
                    }
                }
            }
            private void Update_ViewModel_AllItems(global::System.Collections.ObjectModel.ObservableCollection<global::MagicBox.Models.Model> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\MainPage.xaml line 65
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj22, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\MainPage.xaml line 18
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\MainPage.xaml line 25
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 4: // Views\MainPage.xaml line 26
                {
                    this.VisualStateMin0 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5: // Views\MainPage.xaml line 35
                {
                    this.VisualStateMin800 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6: // Views\MainPage.xaml line 51
                {
                    this.leftView = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7: // Views\MainPage.xaml line 102
                {
                    this.InlineViewGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 8: // Views\MainPage.xaml line 169
                {
                    this.musicNameTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Views\MainPage.xaml line 170
                {
                    this.mediaElement = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 10: // Views\MainPage.xaml line 171
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element10 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element10).Click += this.SelectClick;
                }
                break;
            case 11: // Views\MainPage.xaml line 172
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element11 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element11).Click += this.DeleteClick;
                }
                break;
            case 12: // Views\MainPage.xaml line 166
                {
                    this.coverImage = (global::Windows.UI.Xaml.Media.ImageBrush)(target);
                }
                break;
            case 13: // Views\MainPage.xaml line 152
                {
                    this.diaryTextBoxDetail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14: // Views\MainPage.xaml line 112
                {
                    this.photoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 15: // Views\MainPage.xaml line 147
                {
                    this.moodTextBlockDetail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // Views\MainPage.xaml line 148
                {
                    this.feedbackTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Views\MainPage.xaml line 149
                {
                    this.dateDatePickerDetail = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 18: // Views\MainPage.xaml line 114
                {
                    this.photoImageDetail = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 19: // Views\MainPage.xaml line 128
                {
                    global::Windows.UI.Xaml.Controls.Button element19 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element19).Click += this.PhotoClick;
                }
                break;
            case 20: // Views\MainPage.xaml line 131
                {
                    global::Windows.UI.Xaml.Controls.Button element20 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element20).Click += this.takePhotoClick;
                }
                break;
            case 21: // Views\MainPage.xaml line 64
                {
                    this.list = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 22: // Views\MainPage.xaml line 65
                {
                    this.listView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.listView).ItemClick += this.ListViewItemClick;
                }
                break;
            case 23: // Views\MainPage.xaml line 91
                {
                    this.add = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 24: // Views\MainPage.xaml line 96
                {
                    this.createButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.createButton).Click += this.CreateClick;
                }
                break;
            case 25: // Views\MainPage.xaml line 97
                {
                    this.cancelButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancelButton).Click += this.CancelClick;
                }
                break;
            case 30: // Views\MainPage.xaml line 61
                {
                    this.searchTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 31: // Views\MainPage.xaml line 62
                {
                    this.searchButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.searchButton).Click += this.SearchClick;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\MainPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 26: // Views\MainPage.xaml line 68
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element26 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    MainPage_obj26_Bindings bindings = new MainPage_obj26_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element26.DataContext);
                    bindings.SetConverterLookupRoot(this);
                    element26.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element26, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element26, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
