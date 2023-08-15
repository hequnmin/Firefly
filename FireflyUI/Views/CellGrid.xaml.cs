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
using System.Linq;

namespace FireflyUI.Views
{
    /// <summary>
    /// CellGrid.xaml 的交互逻辑
    /// </summary>
    public partial class CellGrid : UserControl
    {
        public CellGrid()
        {
            InitializeComponent();

            _Initialize();

            this.Loaded += _Loaded;
        }

        private void _Initialize()
        {
            StackPanel stackPanel00 = new StackPanel()
            {
                Name = "stackPanel00"
            };
            StackPanel stackPanel01 = new StackPanel()
            {
                Name = "stackPanel01"
            };

            Cell cell00 = new Cell()
            {
                Name = "cell00",
                Channel = 1,
                NodeName = "Test Node Name ...",
                TestName = "Test Item Name ...",
                Value = 12345.67,
                Unit = "mV",
                Check = true,
                Between = true,
                Lower = 0,
                Upper = 98765.43
            };

            Cell cell01 = new Cell()
            {
                Name = "cell01",
                Channel = 2,
                NodeName = "Test Node Name ...",
                TestName = "Test Item Name ...",
                Value = 34567.89,
                Unit = "mV",
                Check = true,
                Between = true,
                Lower = 0,
                Upper = 98765.43
            };

            gridCells.Children.Add(stackPanel00);
            gridCells.Children.Add(stackPanel01);
            Grid.SetRow(stackPanel00, 0);
            Grid.SetRow(stackPanel01, 0);
            Grid.SetColumn(stackPanel00, 0);
            Grid.SetColumn(stackPanel01, 1);

            stackPanel00.Children.Add(cell00);
            stackPanel01.Children.Add(cell01);

        }

        private void _Loaded(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
