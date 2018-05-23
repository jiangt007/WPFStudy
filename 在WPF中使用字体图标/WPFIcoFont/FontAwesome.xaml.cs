using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WPFIcoFont
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FontAwesome : Window
    {
        public FontAwesome()
        {
            InitializeComponent();
            //图标和对应的Unicode编码
            txtbFont.Text = "\uf022";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new ICOList().Show();
        }
    }
}
