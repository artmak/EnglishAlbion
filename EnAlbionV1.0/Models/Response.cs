using EnAlbionV1._0.Mailers;


namespace EnAlbionV1._0.Models
{
    using System.ComponentModel;
    using System.Text.RegularExpressions;
    using System.Net.Mail;
    using System.Linq;
    using System.Text;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Response : IDataErrorInfo
    {


        [Required(ErrorMessage = "Пожалуйста введите Имя")]
        public string Name { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Пожалуйста корректный email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Пожалуйста номер телефона")]
        public string Phone { get; set; }

        public string Comment { get; set; }
        [Required(ErrorMessage = "Выберете нужный запрос! Запросить обратный звонок или записаться на занятие.")]
        public bool? WillFeed { get; set; }
        
        public List<ResponseItem> Answers { get; set;}

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

        public Response() 
        {
            Answers = new List<ResponseItem>();
        }



        public Response(IEnumerable<ResponseItem> lists)
        {

            Answers = lists.ToList();

        }
        
        //public void Submit()
        //{
        //    EnsureCurrentlyValid();


        //    var message = new StringBuilder();
        //    message.AppendFormat("Date: {0:yyyy-MM-dd hh:mm}\n", DateTime.Now);
        //    message.AppendFormat("Feedback from: {0}\n", Name);
        //    message.AppendFormat("Email: {0}\n", Email);
        //    message.AppendFormat("Phone: {0}\n", Phone);
        //    message.AppendFormat("Comments: {0}\n", Comment);

        //    message.AppendFormat("Выбрано действие: {0}\n", WillFeed.Value ? "Перезвоните пожалуйста" : "Записать меня на пробный урок");
        //    message.AppendFormat("Ответы: []", Answers);

        //    SmtpClient smtpClient = new SmtpClient();
        //    smtpClient.Send(new MailMessage("feedback@englishalbion.com.ua", "feedback@englishalbion.com.ua", Name + (WillFeed.Value ? " Перезвоните мне" : " Записаться на пробный урок"), message.ToString()));

            
        //}

        private void EnsureCurrentlyValid()
        {
            // Check that IDataErrorInfo.this[] returns null for every property
            var propsToValidate = new[] { "Name", "Email", "Phone", "WillFeed" };
            bool isValid = propsToValidate.All(x => this[x] == null);
            if (!isValid)
            throw new InvalidOperationException("Can't submit invalid GuestResponse");
        }
    }

    public class ResponseTest : IDataErrorInfo {
       
            [Required(ErrorMessage = "Пожалуйста введите Имя")]
            public string Name { get; set; }
            [EmailAddress]
            [Required(ErrorMessage = "Пожалуйста корректный email")]
            public string Email { get; set; }
            [Required(ErrorMessage = "Пожалуйста номер телефона")]
            public string Phone { get; set; }

            public string Comment { get; set; }
            [Required(ErrorMessage = "Выберете нужный запрос! Запросить обратный звонок или записаться на занятие.")]
            public bool? WillFeed { get; set; }

            public List<char> Answers { get; set; }

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

            public ResponseTest()
            {
                Answers = new List<char>();
            }



            public ResponseTest(IEnumerable<char> lists)
            {

                Answers = lists.ToList();

            }

            //public void Submit()
            //{
            //    EnsureCurrentlyValid();


            //    var message = new StringBuilder();
            //    message.AppendFormat("Date: {0:yyyy-MM-dd hh:mm}\n", DateTime.Now);
            //    message.AppendFormat("Feedback from: {0}\n", Name);
            //    message.AppendFormat("Email: {0}\n", Email);
            //    message.AppendFormat("Phone: {0}\n", Phone);
            //    message.AppendFormat("Comments: {0}\n", Comment);

            //    message.AppendFormat("Выбрано действие: {0}\n", WillFeed.Value ? "Перезвоните пожалуйста" : "Записать меня на пробный урок");
            //    message.AppendFormat("Ответы: []", Answers);

            //    SmtpClient smtpClient = new SmtpClient();
            //    smtpClient.Send(new MailMessage("feedback@englishalbion.com.ua", "feedback@englishalbion.com.ua", Name + (WillFeed.Value ? " Перезвоните мне" : " Записаться на пробный урок"), message.ToString()));


            //}

            private void EnsureCurrentlyValid()
            {
                // Check that IDataErrorInfo.this[] returns null for every property
                var propsToValidate = new[] { "Name", "Email", "Phone", "WillFeed" };
                bool isValid = propsToValidate.All(x => this[x] == null);
                if (!isValid)
                    throw new InvalidOperationException("Can't submit invalid GuestResponse");
            }
        }

    

    public class ResponseItem
    {

        public ResponseItem(IEnumerable<KeyValuePair<char, string>> answers)
        {
            Answers = answers.ToArray();
        }
        [Required(ErrorMessage = "Вы пропустили ответ. Необходимо ответить на все вопросы.")]
        public char answer { get; set; }
        public KeyValuePair<char, string>[] Answers { get; set; }
        public string question { get; set; }

        public string comment { get; set; }
    }
}