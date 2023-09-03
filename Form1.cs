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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraScheduler.Tools;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Media;
using DevExpress.Xpo;
using System.Data.SqlClient;

namespace iEvent
{
    public partial class Form1 : RibbonForm 

    {


        public Form1()
        {
            InitializeComponent();
            //this.unitOfWork1.Disconnect();
            //this.unitOfWork1.ConnectionString = Properties.Settings.Default.iEventConnectionString;
            //this.unitOfWork1.Connect();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            if (unitOfWork1.IsConnected)
                this.barEditItem2.Caption = "En ligne";
            else
                this.barEditItem2.Caption = "Hors ligne";

            
            xpCollection1.Reload();
            xpCollection2.Reload();
            schedulerControl1.GroupType = SchedulerGroupType.Resource;
            schedulerControl1.Start = DateTime.Now;

            //Reservation.AutoSaveOnEndEdit = true;
            //Emplacement.AutoSaveOnEndEdit = true;
           


        }

        private void schedulerStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e)
        {
            try
            {
                //Console.WriteLine("AppointmentsChanged :");
            //unitOfWork1.BeginTransaction();
            //xpCollection1.Session.BeginTransaction();

                bool succes = true;
                foreach (Appointment app in e.Objects)
                {
                    //Console.WriteLine("AppointmentsChanged :" + app.ToString());
                    if (app.Type == AppointmentType.ChangedOccurrence)
                        succes = false;
                    else
                    {
                        (app.GetSourceObject(this.schedulerStorage1) as Reservation).Save();

                    }
                }
                if (succes)
                {
                    unitOfWork1.CommitTransaction();
                }
                else
                {
                    unitOfWork1.RollbackTransaction();
                    ReloadCollections();
                }  
            
            
                }  catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.GetType().FullName + "\nErreur d'accès aux données, Cette Réservation est peut être supprimer par un autre utilisateur", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
        }





        DevExpress.Utils.ImageCollection sportsImages;
        ///////////////////////////////////////////////////////////////////////////////
        private void schedulerControl_InitAppointmentImages(object sender, AppointmentImagesEventArgs e)
        {
            this.sportsImages = imageCollection1;
          
            AppointmentImageInfo info = new AppointmentImageInfo();
            try
            {
               if (e.Appointment.StatusId == 1) info.Image = this.sportsImages.Images[0];

                e.ImageInfoList.Add(info);
            }
            catch (System.IndexOutOfRangeException ex)
            {
                XtraMessageBox.Show(ex.Message, ex.Source);

            }

           
        }
        //////////////////////////////////////////////////////////////////////////
        static string GetPax(Appointment apt)
        {
            if (apt.CustomFields["pax"] != null)
                return String.Format("Nombre de Pax: [{0}]", apt.CustomFields["pax"].ToString());
            else return string.Empty;
        }
        static string GetTel(Appointment apt)
        {
            if (apt.CustomFields["tel"] != null)
                return String.Format("Tél:{0}", apt.CustomFields["tel"].ToString());
            else return string.Empty;
        }
        private string GetEmail(Appointment apt)
        {
         

            if (apt.CustomFields["email"] != null)
            
               return String.Format("Email:{0}", apt.CustomFields["email"].ToString());
            else return string.Empty;

            

        }
        private string GetFax(Appointment apt)
        {


            if (apt.CustomFields["fax"] != null)

                return String.Format("Fax:{0}", apt.CustomFields["fax"].ToString());
            else return string.Empty;



        }
        private void toolTipController1_BeforeShow(object sender, ToolTipControllerShowEventArgs e)
        {
            ToolTipController controller = sender as ToolTipController;
            AppointmentViewInfo aptViewInfo = controller.ActiveObject as AppointmentViewInfo;
            if (aptViewInfo == null) return;
            Appointment apt = aptViewInfo.Appointment;
            if (apt == null) return;
            e.IconType = ToolTipIconType.Information;
            e.Title = e.ToolTip;
            e.ToolTip = GetPax(apt) + "\r\n" + GetTel(apt) + "\r\n" + GetFax(apt) + "\r\n" + GetEmail(apt) + "\r\n"+apt.Description;
        }



        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            Appointment apt = e.Appointment;

            // Required to open the recurrence form via context menu.
            bool openRecurrenceForm = apt.IsRecurring && schedulerStorage1.Appointments.IsNewAppointment(apt);

            // Create a custom form.
            Form2 myForm = new Form2((SchedulerControl)sender, apt, openRecurrenceForm);

            try
            {
                // Required for skins support.
                myForm.LookAndFeel.ParentLookAndFeel = schedulerControl1.LookAndFeel;

                e.DialogResult = myForm.ShowDialog();
                schedulerControl1.Refresh();
                e.Handled = true;
            }
            finally
            {
                myForm.Dispose();
            }
        }

        private void schedulerControl1_InitAppointmentDisplayText(object sender, AppointmentDisplayTextEventArgs e)
        {
            Appointment apt = e.Appointment;
            string s = string.Empty;
            if (apt.CustomFields["pax"] != null)
                s= String.Format("[{0}]", apt.CustomFields["pax"].ToString());
            
            e.Text = e.Text+s;
          //  e.Description = GetCustomServices(apt);
        }


        public static DateTime date1 = DateTime.Today.AddDays(-1);
        public static DateTime date2 = DateTime.Today;
       
 

        /**************************************                                    ********************************/
       
        
        delegate void DoRefreshData();
        IAsyncResult asyncResult;
        
        
        private void ReloadCollections()
        {
            xpCollection1.Reload();
            asyncResult = this.BeginInvoke((DoRefreshData)RefreshAsync);
        }
        void RefreshAsync()
        {
            this.EndInvoke(asyncResult);
            this.schedulerStorage1.RefreshData();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                ReloadCollections();
                //schedulerStorage1.RefreshData();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                throw;
            }
           

        }

        private void schedulerStorage1_ReminderAlert(object sender, ReminderEventArgs e)
        {
            SystemSounds.Exclamation.Play();
          

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FormCalc frm = new FormCalc())
            {
                frm.ShowDialog();
                if (frm.DialogResult != DialogResult.OK) return;
                try
                {
                    AppointmentBaseCollection abc = this.schedulerStorage1.GetAppointments(date1, date2); ;
                    if (abc.Count == 0)
                    {
                        MessageBox.Show("Aucune réservation trouvée!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    Int32 nbre = 0;
                    float total = 0, prix = 0;
                    foreach (Appointment apt in abc)
                    {
                        if (apt.CustomFields["pax"] != null)
                        {
                            nbre += (int)apt.CustomFields["pax"];
                            prix += nbre * (float)apt.CustomFields["prix"];

                        }
                        total = prix;

                    }

                    using (ChifreDaffaire chfr = new ChifreDaffaire(abc.Count.ToString(), nbre.ToString(), total.ToString()))
                    {
                        chfr.ShowDialog();
                        chfr.Dispose();
                    }

                    //MessageBox.Show("Total des réservations: " + abc.Count.ToString() + "\r\nTotal des Pax: " + nbre.ToString() + "\r\nLe chifre d'affaire est: " + total.ToString());
                    frm.Dispose();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); };
            }
        }

        private void schedulerStorage1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
        {
            //unitOfWork1.BeginTransaction();
            unitOfWork1.CommitTransaction();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Voulez vous Quitter iEvent?  ", "Avertissement!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Login formlogin = new Login();
            Users usr = new Users();
            formlogin.ShowDialog();

            if (formlogin.DialogResult == DialogResult.OK)

                try
                {
                    usr.ShowDialog();


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nErreur N°: F09", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    usr.Dispose();
                }
            formlogin.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //barButtonItem1.PerformClick();
        }

        private void schedulerStorage1_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
        {
            //barButtonItem1.PerformClick();

            AppointmentBaseCollection apt = this.schedulerControl1.SelectedAppointments;
            if (apt.Count == 0) return;

            //////////////////////////////////////////////////////////////////////////////

            try
            {
                if (XtraMessageBox.Show("Voulez vous annuler la réservation séléctionnée?", "Veuillez confirmer la suppression", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question, 
                    MessageBoxDefaultButton.Button2) 
                    == DialogResult.Yes)
                {
                    apt[0].Delete();
                    //schedulerControl1.SelectedAppointments.Remove(apt[0]);
                }
                else e.Cancel = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\nErreur N°: S14", ex.Source);
            }
            finally
            {
                
                schedulerControl1.Refresh();
            }
            
        }

        private void schedulerControl1_PreparePopupMenu(object sender, PreparePopupMenuEventArgs e)
        {
            if (e.Menu.Id == SchedulerMenuItemId.DefaultMenu)
            {
                // Find the "New Appointment" menu item and rename it.
                SchedulerMenuItem item = e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment);
                if (item != null) item.Caption = "&Nouvelle Réservation";
                // Find the "New Appointment" menu item and rename it.

                //
                SchedulerMenuItem oldDelete1 = e.Menu.GetMenuItemById(SchedulerMenuItemId.NewRecurringAppointment);
                oldDelete1.Visible = false;
                ////
                SchedulerMenuItem oldDelete2 = e.Menu.GetMenuItemById(SchedulerMenuItemId.NewRecurringEvent);
                oldDelete2.Visible = false;

                SchedulerMenuItem oldDelete3 = e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAllDayEvent);
                oldDelete3.Visible = false;

                
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Endroits endroit = new Endroits();
            endroit.ShowDialog();
        }

     

     
    }


}