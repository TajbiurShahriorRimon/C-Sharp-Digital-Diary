using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DiaryForm());
            try
            {
                Application.Run(new HomePage());
            } catch(Exception ex)
            {
                MessageBox.Show("Error First: " + ex);
            }
            //Application.Run(new HomePage());
        }
    }
}
