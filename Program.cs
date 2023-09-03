// Developer Express Code Central Example:
// How to use All-Day header to display scheduled time statistics
// 
// Problem : It would be good to display how much time you have in use (% wise) in
// your schedule. When an appointment is added/changed/deleted for each resource it
// will calculate the appointments on the days that have been changed against your
// total time available and get a % which will be added to the top of the schedule.
// When you have less than 50% available it will show yellow and when you go over
// 50% it will show in red. Solution: You can utilize the
// SchedulerControl.CustomDrawDayViewAllDayArea event to draw this statistics in
// the All-Day appointments area. Then, you can collect appointments for a
// particular day via the SchedulerStorageBase.GetAppointments method. This
// approach is illustrated by the following example.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E121

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace iEvent
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        #region Importations d'API
        [DllImport("USER32.DLL")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);


        #endregion

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");

            bool createdNew;

            // give a unique name for the mutex,  // prefix it with Local\ to ensure that it's created in the per-session namespace, not the global namespace.  
            string mutexName = @"Local\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

            // Create a new mutex object with given name
            Mutex m = new Mutex(false, mutexName, out createdNew);

            // If the mutex already exists then don't start program becase
            // another instance is already running.
            if (!createdNew)
            {
                MessageBox.Show("Une instance de vôtre programme est déjà en cours d'exécution.\nVérifier s'il n'est pas réduit ou cacher", "UltimateSPA déjà ouvert");
                // SetForegroundWindow(maFenetreHandle);
                return;
            }

            Login formlogin = new Login();
            formlogin.ShowDialog();
            if (formlogin.DialogResult == DialogResult.OK)
                try
                {
                    Application.Run(new Form1());

                }
                catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally
                {

                    if (m != null)
                    {
                        //mutex.ReleaseMutex(); 
                        m.Close();
                    }
                }

            else Application.Exit();

            // Release the mutex resources
        }
    }
}