using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class BaseNotificationService
    {
        public void Send(string config)
        {

        }
    }
    public class NotificationServiceLiskov_Violation : BaseNotificationService
    {
        string _config;

        public NotificationServiceLiskov_Violation(string config)
        {
            _config = config;
        }

        public void Send(string user, string password)
        {

        }
    }

    public class NotificationServiceLiskov_Solution : BaseNotificationService, INotificationService
    {
        string _config;

        public NotificationServiceLiskov_Solution(string config)
        {
            _config = config;
        }

        public void SendEmail(string email)
        {
            Send(_config);
        }

        public void SendSMS(string number)
        {
            Send(_config);
        }
    }
}
