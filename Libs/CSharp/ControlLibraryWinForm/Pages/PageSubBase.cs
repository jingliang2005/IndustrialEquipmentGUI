using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibraryWinForm.Pages
{
    public partial class PageSubBase : UserControl
    {

        public PageSubBase(string text)
        {
            InitializeComponent();
            this.Text = text;// this.GetType().Name;
            Label label = new Label();
            label.Text = this.Text; 
            label.AutoSize = false;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(label);
            this.BorderStyle = BorderStyle.FixedSingle;
            
        }
    }
}
