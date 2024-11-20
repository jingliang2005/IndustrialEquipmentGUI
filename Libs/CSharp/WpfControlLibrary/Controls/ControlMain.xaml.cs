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

using CoreSCADA.Core;

namespace WpfControlLibrary.Controls
{
    /// <summary>
    /// ControlMain.xaml 的交互逻辑
    /// </summary>
    public partial class ControlMain : UserControl
    {
        public ControlMain()
        {
            InitializeComponent();
            //Task.Run(() =>
            //{
                Core = new CoreSCADA.Core.CoreSCADA();
                Core.Start();
            //});
        }

        public CoreBase.Core.CoreBase Core { get; set; }

        #region Button Click Event
        private void butHome_Click(object sender, RoutedEventArgs e)
        {
            this.HideAllSubControl();
            this.ControlHome.Visibility = Visibility.Visible;
        }

        private void butEquipment_Click(object sender, RoutedEventArgs e)
        {
            this.HideAllSubControl();
            this.ControlEquipments.Visibility = Visibility.Visible;

        }

        private void butDashboard_Click(object sender, RoutedEventArgs e)
        {
            this.HideAllSubControl();
            this.ControlDashboard.Visibility = Visibility.Visible;

        }

        private void butFaultAlert_Click(object sender, RoutedEventArgs e)
        {
            this.HideAllSubControl();
            this.ControlFaultAlerts.Visibility = Visibility.Visible;

        }

        private void butDebug_Click(object sender, RoutedEventArgs e)
        {
            this.HideAllSubControl();
            this.ControlDebug.Visibility = Visibility.Visible;

        }

        private void btnConfig_Click(object sender, RoutedEventArgs e)
        {
            this.HideAllSubControl();
            this.ControlConfig.Visibility = Visibility.Visible;

        }

        private void butExit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButton.OKCancel)
                == MessageBoxResult.OK)
            {
                Application.Current.Shutdown();
            }
        }

        public void HideAllSubControl()
        {
            foreach (var item in this.Views.Children)
            {
                if (item is Control)
                {
                    (item as Control).Visibility = Visibility.Collapsed;
                }
            }
        }
        #endregion

    }
}
