using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class FacebookNotification : Notification
    {
        private readonly Notification _notification;

        public FacebookNotification()
        {

        }
        public FacebookNotification(Notification notification)
        {
            _notification = notification;
        }
        public override void notify()
        {
            _notification?.notify();
            Console.WriteLine("Notifing In Facebook");
        }
    }
}
