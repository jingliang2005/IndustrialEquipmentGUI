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
using System.Windows.Shapes;

namespace WpfControlLibrary.Views
{
    /// <summary>
    /// ViewMain.xaml 的交互逻辑
    /// </summary>
    public partial class ViewMain : Window
    {
        public ViewMain():base()
        {
            InitializeComponent();
            this.SetDefault();
        }

        public virtual void  SetDefault()
        {
            this.ShowInTaskbar = false;
            this.WindowState = WindowState.Maximized;
        }   
    }
}
