using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class SMSNotification : Notification
    {
        private readonly Notification _notification;

        public SMSNotification()
        {

        }
        public SMSNotification(Notification notification)
        {
            _notification = notification;
        }
        public override void notify()
        {
            _notification?.notify();
            Console.WriteLine("Notifing SMS");
        }
    }
}
