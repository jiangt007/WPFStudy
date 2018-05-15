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

namespace WM.TR.RMS
{
    /// <summary>
    /// Interaction logic for Cards.xaml
    /// </summary>
    public partial class Cards : UserControl
    {
        public Cards()
        {
            InitializeComponent();
        }

        private void Flipper_OnIsFlippedChanged(object sender, RoutedPropertyChangedEventArgs<bool> e)
        {
            System.Diagnostics.Debug.WriteLine("Card is flipped = " + e.NewValue);
        }

        public void AddCard()
        {
            //mainPanel.ad
        }

        //private void AddProgramControl(BoxItem element)
        //{
        //    //WrapPanel lastElement = elementList[elementList.Count - 1];
        //    //if (lastElement.Children.Count == 24)
        //    //{
        //    //    lastElement.Children.Remove(addPanel);
        //    //    lastElement.Children.Add(element);
        //    //    ItemTool itemTool = new ItemTool();
        //    //    itemTool.Height = GetPageHieght();
        //    //    itemTool.Width = GetPageWidth();
        //    //    itemTool.wpPancels.Children.Clear();
        //    //    itemTool.wpPancels.Children.Add(addPanel);
        //    //    AddPage(itemTool);
        //    //}
        //    //else
        //    //{
        //    //    lastElement.Children.Insert(lastElement.Children.Count - 1, element);
        //    //}
        //}
    }
}