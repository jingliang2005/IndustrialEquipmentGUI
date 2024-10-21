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
    public partial class PageMain : UserControl
    {

        #region MyRegion

        public FlowLayoutPanel FlowLayoutPanelNavigationBar;
        public GroupBox GroupBoxMain;
        public Panel PanelMain;

        #endregion

        public PageMain()
        {
            InitializeComponent();
            InitializeBaseLayout();
            CreatePage();
        }

        public virtual void InitializeBaseLayout()
        {
            this.FlowLayoutPanelNavigationBar = new FlowLayoutPanel();
            this.FlowLayoutPanelNavigationBar.Dock = DockStyle.Right;
            this.FlowLayoutPanelNavigationBar.BorderStyle = BorderStyle.FixedSingle;
            this.FlowLayoutPanelNavigationBar.FlowDirection = FlowDirection.BottomUp;
            this.FlowLayoutPanelNavigationBar.Width = 100;
            this.FlowLayoutPanelNavigationBar.Margin = new Padding(5, 5, 5, 5);

            this.PanelMain = new Panel();
            this.PanelMain.Dock = DockStyle.Fill;

            this.GroupBoxMain = new GroupBox();
            this.GroupBoxMain.Text = "Main";
            this.GroupBoxMain.Margin = new Padding(5, 5, 5, 5);
            this.GroupBoxMain.Dock = DockStyle.Fill;
            this.GroupBoxMain.FlatStyle = FlatStyle.Standard;
            this.GroupBoxMain.Controls.Add(this.PanelMain);

            this.Controls.Add(this.GroupBoxMain);
            this.Controls.Add(this.FlowLayoutPanelNavigationBar);

            Button butExit = CreateButton("Exit");
            butExit.Click += (sender, e) =>
            {
                if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    Application.Exit();
            };
            this.FlowLayoutPanelNavigationBar.Controls.Add(butExit);

        }

        public virtual void CreatePage()
        {
            PageConfiguration pageConfig = new PageConfiguration("Configuration");
            this.InsertPageAndButton(pageConfig);

            PageDebugging pageDebug = new PageDebugging("Debugging");
            this.InsertPageAndButton(pageDebug);

            PageFaultAlerts pageFault = new PageFaultAlerts("Fault Alerts");
            this.InsertPageAndButton(pageFault);

            PageDashboard   pageDashboard = new PageDashboard("Dashboard");
            this.InsertPageAndButton(pageDashboard);

            PageEquipments pageEquipments = new PageEquipments("Equipments");
            this.InsertPageAndButton(pageEquipments);

            this.HideAllPage();
            PageHome pageHome = new PageHome("Home");
            this.InsertPageAndButton(pageHome);
        }

        public Button CreateButton(string text)
        {
            Button button = new Button();
            button.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.Text = text;
            button.Margin = new System.Windows.Forms.Padding(10);
            return button;
        }

        public virtual void InsertPageAndButton(PageSubBase page)
        {
            page.Dock = DockStyle.Fill;
            this.PanelMain.Controls.Add(page);
            this.GroupBoxMain.Text = page.Text;

            Button but = CreateButton(page.Text);
            but.Click += (sender, e) =>
            {
                this.HideAllPage();
                this.GroupBoxMain.Text = page.Text;
                page.Visible = true;    
            };
            this.FlowLayoutPanelNavigationBar.Controls.Add(but);
        }

        public void HideAllPage()
        {
            foreach (Control control in this.PanelMain.Controls)
            {
                control.Hide();
            }
        }
        


    }
}
