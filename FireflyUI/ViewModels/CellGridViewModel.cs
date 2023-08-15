using System;
using System.Collections.Generic;
using System.Text;

using Prism.Mvvm;

namespace FireflyUI.ViewModels
{
    public class CellGridViewModel : BindableBase
    {
        private int _channel = 1;
        public int Channel
        {
            get { return _channel; }
            set { SetProperty(ref _channel, value); }
        }

        public CellGridViewModel()
        {

        }
    }

    public class ChannelStatusInfo
    {
        public ChannelStatusInfo()
        {

        }

        public string Channel { get; set; }
        public string NodeName { get; set; }
        public string TestName { get; set; }
        public string Unit { get; set; }
        public double Value { get; set; }
        public bool Check { get; set; }
        public double Lower { get; set; }
        public double Upper { get; set; }
        public bool Result { get; set; }

    }
}
