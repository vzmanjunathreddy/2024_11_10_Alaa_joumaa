using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public interface IConfigDI
    {
        string GetUserName();
        string GetPassword();
    }

    public class ConfigDI : IConfigDI
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

    public class NotificationServiceDI_Violation
    {
        public NotificationServiceDI_Violation()
        {
        }

        public void SendEmail(Config config)
        {

        }
    }

    public class NotificationServiceDI_Solution
    {
        private IConfig _config;

        public NotificationServiceDI_Solution(IConfig config)
        {
            _config = config;
        }
    }
}
