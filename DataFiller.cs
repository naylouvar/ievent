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
using System.Text;
using DevExpress.XtraScheduler;

namespace iEvent {
    public class DataFiller {
        public static string[] Users = new string[] { "Riad", "Ksar", "Tente", "Hotel", "Picsine", "Masraf Café" };
        public static string[] Usernames = new string[] { "Riad", "Ksar", "Tente", "Hotel", "Picsine", "Masraf Café" };
        public static Random RandomInstance = new Random();


        public static void FillResources(SchedulerStorage storage, int count) {
            ResourceCollection resources = storage.Resources.Items;
            storage.BeginUpdate();
            try {
                int cnt = Math.Min(count, Users.Length);
                for (int i = 1; i <= cnt; i++) {
                    resources.Add(new Resource(Usernames[i - 1], Users[i - 1]));
                }
            }
            finally {
                storage.EndUpdate();
            }
        }


        public static void GenerateAppointments(SchedulerStorage storage) {
            int count = storage.Resources.Count;
            for (int i = 0; i < count; i++) {
                Resource resource = storage.Resources[i];
                string subjPrefix = resource.Caption + "'s ";

                storage.Appointments.Add (AptCreate(resource.Id, subjPrefix + "Marriage", 1, 1));
                storage.Appointments.Add (AptCreate(resource.Id, subjPrefix + "Seminaire", 0, 0));
                storage.Appointments.Add (AptCreate(resource.Id, subjPrefix + "Dinner", 0, 1));
            }
        }
        public static Appointment AptCreate(object resourceId, string subject, int status, int label) {
            Appointment apt = new Appointment();
            apt.Subject = subject;
            apt.ResourceId = resourceId;
            Random rnd = RandomInstance;
            int rangeInHours = 48;
            apt.Start = DateTime.Today + TimeSpan.FromHours(rnd.Next(0, rangeInHours));
            apt.End = apt.Start + TimeSpan.FromHours(rnd.Next(0, rangeInHours / 8));
            apt.StatusId = status;
            apt.LabelId = label;
           // apt.CustomFields["fax"] = "ici fx";
            return apt;
        }

    }
}
