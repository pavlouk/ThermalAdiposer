using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ThermalAdiposer.ViewModels;
using ThermalAdiposer.Views;

namespace ThermalAdiposer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ThermalAdiposer.Views.ShellView window = new ShellView();
            MeasurmentViewModel VM = new MeasurmentViewModel();
            window.DataContext = VM;
            window.Show();
        }
    }
}
