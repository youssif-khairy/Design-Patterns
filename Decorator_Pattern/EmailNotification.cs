using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class EmailNotification : Notification
    {
        private readonly Notification _notification;

        public EmailNotification()
        {

        }
        public EmailNotification(Notification notification)
        {
            _notification = notification;
        }
        public override void notify()
        {
            _notification?.notify();
            Console.WriteLine("Notifing Email Address");
        }
    }
}
