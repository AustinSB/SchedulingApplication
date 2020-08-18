using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchedulingForms.UserTracker;

namespace SchedulingForms
{
    public static class TrackLogins
    {
        public static void SaveToLogFile()
        {
            var filename = Path.Combine(Environment.CurrentDirectory, "log.txt");
            
            using (StreamWriter write = new StreamWriter(filename, true))
            {
                write.WriteLine("");
                write.WriteLine($"Successful login by: {ActiveUser.userName} ");
                write.WriteLine($"At: {CurrentTime.ToString("MM/dd/yyyy hh:mm tt")}");
            }
        }
    }
}
