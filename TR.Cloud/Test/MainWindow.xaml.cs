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

namespace Test
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.textBlockTest.SetBinding(TextBlock.TextProperty, new Binding() { Path = new PropertyPath("Ip"), Source = deviceInfo });
            //this.textBlockTest1.SetBinding(TextBlock.TextProperty, new Binding() { Path = new PropertyPath("Satus.AlarmMassList"), Source = deviceInfo });
            Student student = new Student();
            //student.SetValue(Student.NameProperty, this.textBox1.Text);
            textBox2.Text = (string)student.GetValue(Student.NameProperty);
        }

        private int index = 0;

        private void iniBinding()
        {
            index++;
            //deviceInfo.SerialNo = "TR-2000DC-170";
            //deviceInfo.Ip = "192.168.1.1 " + index.ToString();
            //deviceInfo.Device.DeviceModel = "TR-2000DC" + index.ToString();
            //deviceInfo.Device.SoftWareVersion = "1.1.1701" + index.ToString();
            //deviceInfo.Device.MassVersion = "9.19.11.1" + index.ToString();

            //deviceInfo.Satus.Status = "正在检测" + index.ToString();
            //deviceInfo.Satus.IsAlarm = true;
            //deviceInfo.Satus.AlarmMassList = "TNT HMX" + index.ToString();
            //deviceInfo.Satus.User = "SurperUser";
        }

        private void buttonTest_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            student.SetValue(Student.NameProperty, this.textBox1.Text);
            textBox2.Text = (string)student.GetValue(Student.NameProperty);
        }
    }
}