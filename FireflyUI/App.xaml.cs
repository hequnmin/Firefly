using HandyControl.Data;
using HandyControl.Themes;
using HandyControl.Tools;
using FireflyUI.Views;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Windows;

namespace FireflyUI
{
    public partial class App
    {
        public static Global Global = new Global();

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Container.Resolve<IRegionManager>().RegisterViewWithRegion("ContentRegion", typeof(Overview));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Dashboard>();
            containerRegistry.RegisterForNavigation<Designer>();
            containerRegistry.RegisterForNavigation<Cell>();
            containerRegistry.RegisterForNavigation<CellGrid>();
        }

        internal void UpdateSkin(SkinType skin)
        {
            SharedResourceDictionary.SharedDictionaries.Clear();
            Resources.MergedDictionaries.Add(ResourceHelper.GetSkin(skin));
            Resources.MergedDictionaries.Add(new ResourceDictionary
            {
                Source = new Uri("pack://application:,,,/HandyControl;component/Themes/Theme.xaml")
            });
            Current.MainWindow?.OnApplyTemplate();
        }
    }
}
