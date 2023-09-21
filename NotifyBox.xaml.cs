using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp17
{
    /// <summary>
    /// NotifyBox.xaml 的交互逻辑
    /// </summary>
    public partial class NotifyBox : Window
    {
        public string aLeft { get; set; }
        public string aTop { get; set; }
        public NotifyBox()
        {
            InitializeComponent();
            this.Loaded += NotifyBox_Loaded;
        }

        private void NotifyBox_Loaded(object sender, RoutedEventArgs e)
        {
            //Thread.Sleep(1000);
            double top = this.Top;
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = top;
            doubleAnimation.To = top - 40;
            doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.2));
            doubleAnimation.EasingFunction = new CubicEase() { EasingMode = EasingMode.EaseOut };
            doubleAnimation.Completed += Storyboard_Completed;
            this.BeginAnimation(Window.TopProperty, doubleAnimation);
            //BeginStoryboard(this.FindResource("OpenStoryBoard") as Storyboard);
        }

     

        private  void Storyboard_Completed(object sender, EventArgs e)
        {
            BeginStoryboard(this.FindResource("CloseStoryBoard") as Storyboard);
        }

        private void Storyboard_Completed_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
