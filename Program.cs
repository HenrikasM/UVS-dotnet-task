using System;
using System.Windows.Forms;

namespace uvsWinFormTask
{
    static class Program
    {
        /// <summary>
        /// @Author: Henrikas M
        /// @Version: v1
        /// @Description:
        /// UVS .NET Task
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
