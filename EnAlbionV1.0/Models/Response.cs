
namespace EnAlbionV1._0.Models
{
    using System.ComponentModel;
    using System.Text.RegularExpressions;
    using System.Net.Mail;
    using System.Linq;
    using System.Text;
    using System;

    public class Response : IDataErrorInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set; }
        public bool? WillFeed { get; set; }

        public string Error { get { return null; } }

        public string this[string propName]
        {
            get
            {
                if ((propName == "Name") && string.IsNullOrEmpty(Name))
                    return "Пожалуйста введите Имя";
                if ((propName == "Email") && !Regex.IsMatch(Email, ".+\\@.+\\..+"))
                    return "Пожалуйста введите корректный email";
                if ((propName == "Phone") && string.IsNullOrEmpty(Phone))
                    return "Пожалуйста введите номер телефона";
                if ((propName == "WillFeed") && !WillFeed.HasValue)
                    return "Выберете нужный запрос! Запросить обратный звонок или записаться на занятие.";
                return null;
            }
        }

        public void Submit()
        {
            EnsureCurrentlyValid();

            
            var message = new StringBuilder();
            message.AppendFormat("Date: {0:yyyy-MM-dd hh:mm}\n", DateTime.Now);
            message.AppendFormat("Feedback from: {0}\n", Name);
            message.AppendFormat("Email: {0}\n", Email);
            message.AppendFormat("Phone: {0}\n", Phone);
            message.AppendFormat("Comments: {0}\n", Comment);
            message.AppendFormat("Выбрано действие: {0}\n", WillFeed.Value ? "Перезвоните пожалуйста" : "Записать меня на пробный урок");

           
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Send(new MailMessage("feedback@englishalbion.com.ua", "feedback@englishalbion.com.ua", Name + (WillFeed.Value ? " Перезвоните мне" : " Записаться на пробный урок"), message.ToString()));
        }

        private void EnsureCurrentlyValid()
        {
            // Check that IDataErrorInfo.this[] returns null for every property
            var propsToValidate = new[] { "Name", "Email", "Phone", "WillFeed" };
            bool isValid = propsToValidate.All(x => this[x] == null);
            if (!isValid)
            throw new InvalidOperationException("Can't submit invalid GuestResponse");
        }
    }
}