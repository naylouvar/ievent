using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraScheduler;

namespace iEvent
{
    public class Task : Appointment {

        public Task() : base() { }
        public Task (AppointmentType type) : base(type){}
 
        // Convert custom fields into the Task properties
        public string CustName
        {
            get { return (string)base.CustomFields["CustName"]; }
            set { base.CustomFields["CustName"] = value; }
        }
        public string Services
        {
            get { return (string)base.CustomFields["Services"]; }
            set { base.CustomFields["Services"] = value; }
        }
        public int Price
        {
            get { return (int)base.CustomFields["Price"]; }
            set { base.CustomFields["Price"] = value; }
        }
        //public string EmpName
        //{
        //    get { return (string)base.Location; }
        //    set { base.Location = value; }
        //}
        //public int CustomColorARGB { get { return ((Color)base.CustomFields["CustomColorField"]).ToArgb(); } }
    }

    // 
    public class TaskFactory : IAppointmentFactory {

        public Appointment CreateAppointment(AppointmentType type) {
            Task task = new Task(type);
            return task;
        }

    }

    public class TaskCollection : List<Task> {

        public void AddAppointment(Appointment appointment) {
            Task task = (Task)appointment;
            base.Add(task);
        }

        public virtual void AddAppointmentRange(AppointmentBaseCollection collection) {
            foreach(Appointment item in collection)
                this.AddAppointment(item);
        }

    
    }
}
