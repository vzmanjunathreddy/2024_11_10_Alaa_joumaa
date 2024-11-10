using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public interface INotificationService
    {
        void SendSMS(string number);
        void SendEmail(string email);
    }

    /// <summary>
    /// Single resposiblity.
    /// </summary>
    public class NotificationService_SRViolation : INotificationService
    {
        public NotificationService_SRViolation() { }

        public void SendEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void SendSMS(string number)
        {
            throw new NotImplementedException();
        }

        //Violating the Single responsiblity.
        public void Login()
        {
            throw new NotImplementedException();
        }
    }

    //SR
    public class NotificationService_ViolationSolution : INotificationService
    {
        public void SendEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void SendSMS(string number)
        {
            throw new NotImplementedException();
        }
    }
}
