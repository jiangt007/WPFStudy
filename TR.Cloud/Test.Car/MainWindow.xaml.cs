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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            iniCars();
        }

        private void iniCars()
        {
            List<Car> cars = new List<Car>() {
                new Car(){ AutoMaker="ix35" ,Name = "Ix35",Year="2018",TopSpeed="150"},
                new Car(){ AutoMaker="tusheng" ,Name = "途胜",Year="2018",TopSpeed="150"},
                new Car(){ AutoMaker="xiaoke" ,Name = "逍客",Year="2018",TopSpeed="150"},
                new Car(){ AutoMaker="xrv" ,Name = "XR-V",Year="2018",TopSpeed="150"}
            };
            foreach (Car car in cars)
            {
                CarListItemView carItem = new CarListItemView();
                carItem.Car = car;
                this.listBoxCars.Items.Add(carItem);
            }
        }

        private void listBoxCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarListItemView view = e.AddedItems[0] as CarListItemView;
            if (view != null)
            {
                this.detailView.Car = view.Car;
            }
        }
    }
}