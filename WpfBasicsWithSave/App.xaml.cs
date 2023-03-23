using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBasicsWithSave
{

    // Error handling done automaticly global by wpf I think. I did not undertand all this -
    // I think its something about WPF kinda handles the errors to make the user able to keep using the app when an error ocurs -
    // It also provides information about the specific error when it calls the method i defined below

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show($"Uhandled exeptions from project: {e.Exception.Message} {Environment.NewLine} {e.Exception.Source}");
            e.Handled = true;
        }
    }
}
