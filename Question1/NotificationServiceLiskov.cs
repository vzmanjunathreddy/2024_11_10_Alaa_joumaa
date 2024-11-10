using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class BaseNotificationService
    {
        public BaseNotificationService(string config)
        {
        }

        public virtual void Send(string config)
        {

        }
    }
    public class NotificationServiceLiskov_Violation : BaseNotificationService
    {
        string _config;

        public NotificationServiceLiskov_Violation(string config) : base(config) 
        {
            _config = config;
        }


    }
}
