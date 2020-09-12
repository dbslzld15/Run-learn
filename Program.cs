using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TeamProjectDemo
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.EnableVisualStyles();

            MenuForm menuForm = new MenuForm();
            MenuController _menuController = new MenuController(menuForm);
            Application.Run(menuForm);
           
        }
    }
}
