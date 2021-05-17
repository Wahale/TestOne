using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TestOne.Services;
using TestOne.Models;
using TestOne;
using System.Windows;

namespace TestOne.ViewModel
{
    class ApplicationViewModel
    {
        private readonly string path = $"{Environment.CurrentDirectory}\\test.json";
        private BindingList<Person> _test;
        private FileSaveAndLoad fileSaveAndLoad;
        private MainWindow window;

        public ApplicationViewModel(MainWindow window)
        {
            this.window = window;
            
        }

        public void Load()
        {
            fileSaveAndLoad = new FileSaveAndLoad(path);
            try
            {
                _test = fileSaveAndLoad.loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                window.Close();
            }

            window.dateGrid1.ItemsSource = _test;
            _test.ListChanged += window._test_ListChanged;
        }

        public void Save(object sender,ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged || e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted)
            {
                try
                {
                    fileSaveAndLoad.SaveData((BindingList<Person>)sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    window.Close();
                }
            }
        }
    }
}
