using ADO.NET._1._Overview;
using ADO.NET._2._SqlConnection_連接水管;
using ADO.NET._3._Connected_連線環境;
using ADO.NET._4._DisConnected_離線環境_DataSet;
using ADO.NET.MyHomeWork;
using Demo;
using Starter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new   FrmDisconnected_離線環境_Solution());
        }
    }
}
