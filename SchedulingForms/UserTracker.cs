using SchedulingDataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace SchedulingForms
{
    static public class UserTracker
    {
        static public BindingList<appointment> userAppointments { get; set; } = new BindingList<appointment>();
        static public BindingList<customer> userCustomers { get; set; } = new BindingList<customer>();

        static private DateTime currentTime = DateTime.Now;
        //static private DateTime currentTime = DateTime.UtcNow;

        static public DateTime CurrentTime
        {
            get 
            {
                currentTime = DateTime.Now;
                return currentTime;
            }
            set
            {
                currentTime = CurrentTime;
            }
        }

        static public customer CustomerIndex;
        static public appointment AppointmentIndex;

        static private user activeUser;
        static public user ActiveUser
        {
            get
            {
                return activeUser;
            }
            set
            {
                activeUser = ActiveUser;
            }
        }

        //Set active user
        static public void GetUser(user active)
        {
            activeUser = active;
        }

        

    }
}
