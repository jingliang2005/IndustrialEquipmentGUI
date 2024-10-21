using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ControlLibraryWinForm.Pages;

namespace ControlLibraryWinForm.Forms
{
    public partial class WinFormBase : Form
    {
        public UserControl MainControl { get; set; }

        public WinFormBase(UserControl mainControl)
        {
            InitializeComponent();
            SetDefaultAppearance();
            AddMainControl(mainControl);
        }

        /// <summary>
        /// 设置默认外观。
        /// </summary>
        /// <param name="text"></param>
        public void SetDefaultAppearance()
        {
            this.Text = "WinForm App Demo";
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleMode = AutoScaleMode.Inherit;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.Font = new Font("宋体", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        }

        public virtual void AddMainControl(UserControl mainControl)
        {
            MainControl = mainControl;
            this.Controls.Add(MainControl);
            MainControl.Dock = DockStyle.Fill;
        }


    }
}
