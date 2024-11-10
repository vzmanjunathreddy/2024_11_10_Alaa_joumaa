using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public interface IConfig
    {
        string GetUserName();
        string GetPassword();
    }

    public class Config : IConfig
    {
        public string GetPassword()
        {
            throw new NotImplementedException();
        }

        public string GetUserName()
        {
            throw new NotImplementedException();
        }
    }

    public interface INotificationServiceIS_Violation
    {
        void SendEmail(Config config);
        void SendSms(Config config);
    }

    public class NotificationServiceIS_Violation : INotificationServiceIS_Violation
    {
        public void SendEmail(Config config)
        {
            Console.WriteLine("Not implemented");
        }

        public void SendSms(Config config)
        {
            Console.WriteLine("Not implemented");
        }

        public void SendWhatsapp(Config config)
        {
            Console.WriteLine("Violation");
        }
    }

    public interface INotificationServiceIS
    {
        void SendEmail(IConfig config);
        void SendSms(IConfig config);
        void SendWhatsapp(IConfig config);
    }

    public class NotificationServiceIS_Soltuion : INotificationServiceIS
    {
        public void SendEmail(IConfig config)
        {
            Console.WriteLine("Sending email");
        }

        public void SendSms(IConfig config)
        {
            Console.WriteLine("Sending SMS");
        }

        public void SendWhatsapp(IConfig config)
        {
            Console.WriteLine("Sending Whatsapp");
        }
    }

}
