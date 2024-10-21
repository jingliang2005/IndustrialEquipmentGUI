using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using ControlLibraryWinForm.Forms;
using ControlLibraryWinForm.Pages;

namespace AppWinForm
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PageMain pageMain = new PageMain();
            Application.Run(new WinFormBase(pageMain));
        }
    }
}
