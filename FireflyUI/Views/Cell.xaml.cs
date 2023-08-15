using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FireflyUI.Views
{
    /// <summary>
    /// Cell.xaml 的交互逻辑
    /// </summary>
    public partial class Cell : UserControl
    {
        public static DependencyProperty propChannel = DependencyProperty.Register("Channel", typeof(int), typeof(Cell), new PropertyMetadata(0));
        public int Channel
        {
            get { return (int)GetValue(propChannel); }
            set { SetValue(propChannel, value); }
        }

        public static DependencyProperty propNodeName = DependencyProperty.Register("NodeName", typeof(string), typeof(Cell), new PropertyMetadata(string.Empty));
        public string NodeName
        {
            get { return (string)GetValue(propNodeName); }
            set { SetValue(propNodeName, value); }
        }

        public static DependencyProperty propTestName = DependencyProperty.Register("TestName", typeof(string), typeof(Cell), new PropertyMetadata(string.Empty));
        public string TestName
        {
            get { return (string)GetValue(propTestName); }
            set { SetValue(propTestName, value); }
        }

        public static DependencyProperty propUnit = DependencyProperty.Register("Unit", typeof(string), typeof(Cell), new PropertyMetadata(string.Empty));
        public string Unit
        {
            get { return (string)GetValue(propUnit); }
            set { SetValue(propUnit, value); }
        }

        public static DependencyProperty propValue = DependencyProperty.Register("Value", typeof(double), typeof(Cell), new PropertyMetadata(null));
        public double Value
        {
            get { return (double)GetValue(propValue); }
            set { SetValue(propValue, value); }
        }

        public static DependencyProperty propLower = DependencyProperty.Register("Lower", typeof(double), typeof(Cell), new PropertyMetadata(null));
        public double Lower
        { 
            get { return (double)GetValue(propLower); } 
            set { SetValue(propLower, value); }
        }

        public static DependencyProperty propUpper = DependencyProperty.Register("Upper", typeof(double), typeof(Cell), new PropertyMetadata(null));
        public double Upper
        {
            get { return (double)GetValue(propUpper); }
            set { SetValue(propUpper, value); }
        }

        public static DependencyProperty propCheck = DependencyProperty.Register("Check", typeof(bool), typeof(Cell), new PropertyMetadata(null));
        public bool Check
        {
            get { return (bool)GetValue(propCheck); }
            set { SetValue(propCheck, value); }
        }

        public static DependencyProperty propBetween = DependencyProperty.Register("Between", typeof(bool), typeof(Cell), new PropertyMetadata(null));
        public bool Between
        {
            get { return (bool)GetValue(propBetween); }
            set { SetValue(propBetween, value); }
        }

        public Cell()
        {
            InitializeComponent();
            this.Loaded += _Loaded;
        }

        private void _Loaded(object sender, RoutedEventArgs e)
        {
            txtChannel.Text = Channel.ToString();
            txtNodeName.Text = NodeName;
            txtTestName.Text = TestName;
            txtUnit.Text = Unit.ToString();
            txtValue.Text = Value.ToString();

            txtReferNotBetween.Text = string.Empty;
            txtReferLower.Text = string.Empty;
            txtReferBetween.Text = string.Empty;
            txtReferUpper.Text = string.Empty;
            txtReferUnit.Text = string.Empty;

            if (Check)
            {
                txtReferNotBetween.Text = Between ? string.Empty : "!";
                txtReferLower.Text = Lower.ToString();
                txtReferBetween.Text = "~";
                txtReferUpper.Text = Upper.ToString();
                txtReferUnit.Text = Unit.ToString();
            }


        }
    }
}
