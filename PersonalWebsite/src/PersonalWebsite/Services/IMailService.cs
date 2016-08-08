using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWebsite.Services
{
    // Defining the interface that each of the mail services may need
    public interface IMailService
    {
        void SendMail(string to, string from, string subject, string body);
    }
}
