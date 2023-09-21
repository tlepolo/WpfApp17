using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp17
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("ok");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NotifyBox notifyBox = new NotifyBox();
            Button button = sender as Button;
            double v = (this.WindowState == WindowState.Maximized ? 0 : this.Top) + this.ActualHeight - notifyBox.Height;
            double v2 = (this.Width - notifyBox.Width) / 2;
            notifyBox.Top = v;
            notifyBox.Left = this.Left + v2;
            notifyBox.Show();
        }
    }
}
