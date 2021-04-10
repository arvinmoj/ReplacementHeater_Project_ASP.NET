using System.Threading.Tasks;

namespace Service.Email.Account
{
    public interface IMessageSender
    {
        public Task SendEmailAsync(string toEmail, string subject, string message, bool isMessageHtml = false);
    }
}
