// Developer Express Code Central Example:
// How to customize the Edit Appointment form to show custom fields
// 
// This example illustrates the use of a custom form to enable the end-user to edit
// custom fields. The custom form is invoked instead of the default one by handling
// the SchedulerControl.EditAppointmentFormShowing event. See Also:
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E152

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;

namespace iEvent
{

    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {

        SchedulerControl control;
        Appointment apt;
        bool openRecurrenceForm = false;
        int suspendUpdateCount;
        

        // The MyAppointmentFormController class is inherited from
        // the AppointmentFormController to add custom properties.
        // See its declaration below.
        MyAppointmentFormController controller;

        protected AppointmentStorage Appointments
        {
            get { return control.Storage.Appointments; }
        }
        protected bool IsUpdateSuspended { get { return suspendUpdateCount > 0; } }


        public Form2(SchedulerControl control, Appointment apt, bool openRecurrenceForm)
        {
            this.openRecurrenceForm = openRecurrenceForm;
            this.controller = new MyAppointmentFormController(control, apt);
            this.apt = apt;
            this.control = control;
            InitializeComponent();
            
            UpdateForm();
            
        }

        #region Recurrence
        private void MyAppointmentEditForm_Activated(object sender, System.EventArgs e)
        {
            // Required to show the recurrence form.
            if (openRecurrenceForm)
            {
                openRecurrenceForm = false;
                OnRecurrenceButton();
            }
        }
        private void btnRecurrence_Click(object sender, System.EventArgs e)
        {
            OnRecurrenceButton();
        }

        void OnRecurrenceButton()
        {
            ShowRecurrenceForm();
        }

        void ShowRecurrenceForm()
        {

            if (!control.SupportsRecurrence)
                return;

            // Prepare to edit the appointment's recurrence.
            Appointment editedAptCopy = controller.EditedAppointmentCopy;
            Appointment editedPattern = controller.EditedPattern;
            Appointment patternCopy = controller.PrepareToRecurrenceEdit();

            AppointmentRecurrenceForm dlg = new AppointmentRecurrenceForm(patternCopy, control.OptionsView.FirstDayOfWeek, controller);

            // Required for skin support.
            dlg.LookAndFeel.ParentLookAndFeel = this.LookAndFeel.ParentLookAndFeel;

            DialogResult result = dlg.ShowDialog(this);
            dlg.Dispose();

            if (result == DialogResult.Abort)
                controller.RemoveRecurrence();
            else
                if (result == DialogResult.OK)
                {
                    controller.ApplyRecurrence(patternCopy);
                    if (controller.EditedAppointmentCopy != editedAptCopy)
                        UpdateForm();
                }
            UpdateIntervalControls();
        }

        #endregion

        #region Form control events

        private void dtStart_EditValueChanged(object sender, System.EventArgs e)
        {
            if (!IsUpdateSuspended)
                controller.DisplayStart = dtStart.DateTime.Date + timeStart.Time.TimeOfDay;
            UpdateIntervalControls();
        }

        private void timeStart_EditValueChanged(object sender, System.EventArgs e)
        {
            if (!IsUpdateSuspended)
                controller.DisplayStart = dtStart.DateTime.Date + timeStart.Time.TimeOfDay;
            UpdateIntervalControls();
        }
        private void timeEnd_EditValueChanged(object sender, System.EventArgs e)
        {
            if (IsUpdateSuspended) return;
            if (IsIntervalValid())
                controller.DisplayEnd = dtEnd.DateTime.Date + timeEnd.Time.TimeOfDay;
            else
                timeEnd.EditValue = new DateTime(controller.DisplayEnd.TimeOfDay.Ticks);
            ;
        }
        private void dtEnd_EditValueChanged(object sender, System.EventArgs e)
        {
            if (IsUpdateSuspended) return;
            if (IsIntervalValid())
                controller.DisplayEnd = dtEnd.DateTime.Date + timeEnd.Time.TimeOfDay;
            else
                dtEnd.EditValue = controller.DisplayEnd.Date;
        }
        bool IsIntervalValid()
        {
            DateTime start = dtStart.DateTime + timeStart.Time.TimeOfDay;
            DateTime end = dtEnd.DateTime + timeEnd.Time.TimeOfDay;
            return end >= start;
        }

        private void checkAllDay_CheckedChanged(object sender, System.EventArgs e)
        {
            controller.AllDay = this.checkAllDay.Checked;
            if (!IsUpdateSuspended)
                UpdateAppointmentStatus();

            UpdateIntervalControls();
        }
        #endregion

        #region Updating Form
        protected void SuspendUpdate()
        {
            suspendUpdateCount++;
        }
        protected void ResumeUpdate()
        {
            if (suspendUpdateCount > 0)
                suspendUpdateCount--;
        }

        void UpdateForm()
        {
            SuspendUpdate();
            try
            {
                txSubject.Text = controller.Subject;
                edStatus.Status = Appointments.Statuses[controller.StatusId];
                edLabel.Label = Appointments.Labels[controller.LabelId];

                dtStart.DateTime = controller.DisplayStart.Date;
                dtEnd.DateTime = controller.DisplayEnd.Date;

                timeStart.Time = new DateTime(controller.DisplayStart.TimeOfDay.Ticks);
                timeEnd.Time = new DateTime(controller.DisplayEnd.TimeOfDay.Ticks);
                checkAllDay.Checked = controller.AllDay;

                fax.Text = controller.fax;
                email.Text = controller.email;
                tel.Text = controller.tel;
                pax.Text = controller.pax.ToString();
                prix.Text = controller.prix.ToString();
               txtdescription.Text = controller.Description ;
                //appointmentResourceEdit1.SelectedIndex = -1;
                //appointmentResourceEdit1.Properties.Items.RemoveAt(0);
                appointmentResourceEdit1.Storage = control.Storage;
                appointmentResourceEdit1.ResourceId = controller.ResourceId;
                //checkEdit1.CheckState =  controller.HasReminder == true ? CheckState.Checked : CheckState.Unchecked;

                edStatus.Storage = control.Storage;
                edLabel.Storage = control.Storage;


            }
            finally
            {
                ResumeUpdate();
            }
            UpdateIntervalControls();
        }

        protected virtual void UpdateIntervalControls()
        {
            if (IsUpdateSuspended)
                return;

            SuspendUpdate();
            try
            {
                dtStart.EditValue = controller.DisplayStart.Date;
                dtEnd.EditValue = controller.DisplayEnd.Date;
                timeStart.EditValue = new DateTime(controller.DisplayStart.TimeOfDay.Ticks);
                timeEnd.EditValue = new DateTime(controller.DisplayEnd.TimeOfDay.Ticks);


                timeStart.Visible = !controller.AllDay;
                timeEnd.Visible = !controller.AllDay;
                timeStart.Enabled = !controller.AllDay;
                timeEnd.Enabled = !controller.AllDay;

            }
            finally
            {
                ResumeUpdate();
            }
        }

        void UpdateAppointmentStatus()
        {
            AppointmentStatus currentStatus = edStatus.Status;
            AppointmentStatus newStatus = controller.UpdateAppointmentStatus(currentStatus);
            if (newStatus != currentStatus)
                edStatus.Status = newStatus;
        }

        #endregion

        #region Save changes
        private void btnOK_Click(object sender, System.EventArgs e)
        {
            try
            {
            // Required to check the appointment for conflicts.

            //AppointmentBaseCollection appt = this.control.Storage.GetAppointments(new TimeInterval(this.dtStart.DateTime.Date + this.timeStart.Time.TimeOfDay, this.dtEnd.DateTime.Date + this.timeEnd.Time.TimeOfDay));
            //if (appt.Count > 0)
            //    if (MessageBox.Show("Time conflicts! Proceed", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            //        return;
            controller.Subject = txSubject.Text;
            controller.SetStatus(edStatus.Status);
            controller.SetLabel(edLabel.Label);
            controller.AllDay = this.checkAllDay.Checked;
            controller.DisplayStart = this.dtStart.DateTime.Date + this.timeStart.Time.TimeOfDay;
            controller.DisplayEnd = this.dtEnd.DateTime.Date + this.timeEnd.Time.TimeOfDay;
            controller.ResourceId = this.appointmentResourceEdit1.ResourceId;
            controller.fax = fax.Text;
            controller.email = email.Text;
            controller.tel = tel.Text;
            controller.pax = Int32.Parse(pax.Text);
            controller.prix = float.Parse(prix.Text);
            controller.Description =  txtdescription.Text;
            controller.HasReminder = checkEdit1.CheckState == CheckState.Checked;
            if (controller.HasReminder) controller.ReminderTimeBeforeStart = durationEdit1.Duration;
            // Save all changes of the editing appointment.
            
                controller.ApplyChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        #endregion

        #region MyAppointmentFormController

        public class MyAppointmentFormController : AppointmentFormController
        {
       
            public Int32 pax
            {
                get { return EditedAppointmentCopy.CustomFields["pax"] !=  null ? (Int32)EditedAppointmentCopy.CustomFields["pax"] : 0; }
                set { EditedAppointmentCopy.CustomFields["pax"] = value; }
            }


            Int32 Sourcepax
            {
                get { return SourceAppointment.CustomFields["pax"] != System.DBNull.Value ? (Int32)SourceAppointment.CustomFields["pax"] : 0; }
                set { SourceAppointment.CustomFields["pax"] = value; }
            }

            public float prix
            {
                get { return EditedAppointmentCopy.CustomFields["prix"] != null ? (float)EditedAppointmentCopy.CustomFields["prix"] : 0; }
                set { EditedAppointmentCopy.CustomFields["prix"] = value; }
            }

             public string tel
            {
                get
                {
                    return EditedAppointmentCopy.CustomFields["tel"] != System.DBNull.Value ? (string)EditedAppointmentCopy.CustomFields["tel"] : string.Empty;
                }
                set { EditedAppointmentCopy.CustomFields["tel"] = value; }
            }
             public string fax
             {
                 get { return EditedAppointmentCopy.CustomFields["fax"] != System.DBNull.Value ? (string)EditedAppointmentCopy.CustomFields["fax"] : string.Empty; } 
                 set { EditedAppointmentCopy.CustomFields["fax"] = value; } 
             }
             public string email 
             {
                 get { return EditedAppointmentCopy.CustomFields["email"] != System.DBNull.Value ? (string)EditedAppointmentCopy.CustomFields["email"] : string.Empty; } 
                 set { EditedAppointmentCopy.CustomFields["email"] = value; } 
             }

            string Sourcetel { get { return (string)SourceAppointment.CustomFields["tel"]; } set { SourceAppointment.CustomFields["tel"] = value; } }
            string Sourcefax { get { return (string)SourceAppointment.CustomFields["fax"]; } set { SourceAppointment.CustomFields["fax"] = value; } }
            string Sourceemail { get { return (string)SourceAppointment.CustomFields["email"]; } set { SourceAppointment.CustomFields["email"] = value; } }
            float Sourceprix
            {
                get { return SourceAppointment.CustomFields["prix"] != System.DBNull.Value ? (float)SourceAppointment.CustomFields["prix"] : 0; }
                set { SourceAppointment.CustomFields["prix"] = value; }
            } 
            public MyAppointmentFormController(SchedulerControl control, Appointment apt)
                : base(control, apt)
            {
            }

            public override bool IsAppointmentChanged()
            {
                if (base.IsAppointmentChanged())
                    return true;
                return
                    Sourcefax != fax ||
                    Sourceemail != email ||
                    Sourcetel != tel ||
                    Sourcepax != pax ||
                    Sourceprix != prix; ;
            }

            protected override void ApplyCustomFieldsValues()
            {
                Sourceemail = email;
                Sourcefax = fax;
                Sourcepax = pax;
                Sourcetel = tel;
            }
        }
        #endregion

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            this.apt.HasReminder = !this.apt.HasReminder;
            if (this.apt.HasReminder)
                this.apt.Reminder.TimeBeforeStart = durationEdit1.Duration;
            

        }
    }
}