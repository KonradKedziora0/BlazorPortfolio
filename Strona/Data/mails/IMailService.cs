using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Strona.Data.mails;

namespace Strona.Data.mails
{
    public interface IMailService { 
        Task SendEmailAsync(string ToEmail, string Subject, string HTMLBody);
    }
}
