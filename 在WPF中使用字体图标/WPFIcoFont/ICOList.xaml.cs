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
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;

namespace WPFIcoFont
{
    /// <summary>
    /// ICOList.xaml 的交互逻辑
    /// </summary>
    public partial class ICOList : Window
    {
        public List<ICO> ICON;
        public ICOList()
        {
            InitializeComponent();
            using (var sr = new StreamReader("Unicode.txt"))
            {
                this.ICON = new List<ICO>();
                while (!sr.EndOfStream)
                {
                    this.ICON.Add(new ICO{ name = sr.ReadLine() });
                }
            }
            ListB.ItemsSource = ICON;
        }
    }
    public class ICO
    {
        public string name { set; get; }
    }
    
    [ValueConversion(typeof(int), typeof(String))]
    public class ICOConverter : IValueConverter
    {
        /// <summary>
        /// 将Unicode编码转换为汉字字符串
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string str = System.Convert.ToString(value);
            string un = string.Empty;
            MatchCollection mc = Regex.Matches(str, @"\\u([\w]{2})([\w]{2})", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            byte[] bts = new byte[2];
            foreach (Match m in mc)
            {
                bts[0] = (byte)int.Parse(m.Groups[2].Value, NumberStyles.HexNumber);
                bts[1] = (byte)int.Parse(m.Groups[1].Value, NumberStyles.HexNumber);
                un += Encoding.Unicode.GetString(bts);
            }

            return un;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
