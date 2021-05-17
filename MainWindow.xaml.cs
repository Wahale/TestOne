using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using TestOne.Models;
using TestOne.Services;
using TestOne.ViewModel;

namespace TestOne
{
    
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationViewModel app;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel(this);
            app = (ApplicationViewModel)DataContext;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            app.Load();
        }

        public void _test_ListChanged(object sender, ListChangedEventArgs e)
        {
            app.Save(sender,e);
        }
    }
}
