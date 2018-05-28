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

namespace Test.Car
{
    /// <summary>
    /// CarDetailView.xaml 的交互逻辑
    /// </summary>
    public partial class CarDetailView : UserControl
    {
        private Car car;

        public Car Car
        {
            get { return car; }
            set
            {
                car = value;
                this.textBlockName.Text = car.Name;
                this.textBlockYear.Text = car.Year;
                this.textBlockTopSpeed.Text = car.TopSpeed;
                this.textBlockAutomaker.Text = car.AutoMaker;
                string url = string.Format(@"/Resources/Logos/{0}.png", car.AutoMaker);
                this.imagePhoto.Source = new BitmapImage(new Uri(url, UriKind.Relative));
            }
        }

        public CarDetailView()
        {
            InitializeComponent();
        }
    }
}