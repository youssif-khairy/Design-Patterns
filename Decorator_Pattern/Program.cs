// Structural DP
// As it adds larger structure to object and class without adding much complexity


//Example you need to notify by diffrent ways you can notify multiple, notify one or notify all as i implemented it


/* if you have old design you can do decorator by letting past hirarch as [ Notification (SMS,Email,Facebook) ] as it 
  and make new hirarch for decorator that inferit from Notification and take object in it's constructor 

you can find example here : 
https://www.geeksforgeeks.org/decorator-design-pattern-in-java-with-example/

*/
using Decorator_Pattern;

Notification notification = new EmailNotification();
notification = new SMSNotification(notification);
notification = new FacebookNotification(notification);


notification.notify();
