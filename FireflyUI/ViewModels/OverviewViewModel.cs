﻿using Prism.Mvvm;
using System.Reflection;

namespace FireflyUI.ViewModels
{
    public class OverviewViewModel : BindableBase
    {
        private string _about;
        public string About
        {
            get { return _about; }
            set { SetProperty(ref _about, value); }
        }

        public OverviewViewModel()
        {
            About = Assembly.GetExecutingAssembly().GetName().Name + " " + Assembly.GetExecutingAssembly().GetName().Version;
        }
    }
}
