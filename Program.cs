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
        /// Req:
        /// 1)User can select the amount of threads (2-15 threads)
        /// 2)System must generate random strings(5-10 lenght) in random intervals(0.5sec-2sec)
        /// 3)System must print out last 20 string in ListView(Thread id; Thread string)
        /// 4)System must save all the data in a mdb file with table Threads(id: autonum; ThreadId varchar; Time date; Data varchar)
        /// 5)System must have "stop" button, that stops all the threads
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
