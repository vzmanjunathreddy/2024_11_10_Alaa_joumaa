using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{

    public class NotificationServiceOC_Violation
    {
        private void Send(string type)
        {
            //Violation OC.
            switch (type)
            {
                case "SMS"
                :
                    break;
                case "Email":

                    break;
            }
        }

        public void SendEmail(string email)
        {
            //OC Violation.
            Console.WriteLine("SendEmail violation not implemented");
        }

        public void SendSMS(string number)
        {
            //OC Violation.
            Console.WriteLine("SendEmail violation not implemented");
        }
    }

    public class NotificationServiceOC_Solution : INotificationService
    {
        public void SendEmail(string email)
        {
            Console.WriteLine("SendEmail not implemented");
        }

        public void SendSMS(string number)
        {
            Console.WriteLine("SendSMS not implemented");
        }
    }
}
