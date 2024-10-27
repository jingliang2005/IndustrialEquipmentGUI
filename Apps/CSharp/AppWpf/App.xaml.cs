using System.Configuration;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows;

using WpfControlLibrary.Views;

namespace AppWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ViewMain viewMain = new ViewMain();
            viewMain.ShowDialog();
        }
    }

}
