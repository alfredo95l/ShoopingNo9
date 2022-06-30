using ShoopingNo9.Common;

namespace ShoopingNo9.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string toName, string toEmail, string subject, string body);
    }
}
