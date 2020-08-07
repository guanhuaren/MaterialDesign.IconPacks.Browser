using MaterialDesignDemo;
using MaterialDesignThemes.Wpf;
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

namespace MaterialDesign.IconPacks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Icons1.DataContext = new IconPackViewModel(MainSnackbar.MessageQueue);
                    //new[]
                    //{
                    //    DocumentationLink.DemoPageLink<IconPack>("Demo View"),
                    //    DocumentationLink.DemoPageLink<IconPackViewModel>("Demo View Model"),
                    //    DocumentationLink.ApiLink<PackIcon>()
                    //})
        }
    }
}
