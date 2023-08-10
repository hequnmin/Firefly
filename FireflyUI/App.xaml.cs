using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using HandyControl.Data;
using HandyControl.Themes;
using HandyControl.Tools;

using Prism;
using Prism.Ioc;
using Prism.Regions;

namespace FireflyUI
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App 
    {

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
