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


        [Required(ErrorMessage = "���������� ������� ���")]
        public string Name { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "���������� ���������� email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "���������� ����� ��������")]
        public string Phone { get; set; }

        public string Comment { get; set; }
        [Required(ErrorMessage = "�������� ������ ������! ��������� �������� ������ ��� ���������� �� �������.")]
        public bool? WillFeed { get; set; }
        
        public List<ResponseItem> Answers { get; set;}

        public string Error { get { return null; } }

        public string this[string propName]
        {
            get
            {
                if ((propName == "Name") && string.IsNullOrEmpty(Name))
                    return "���������� ������� ���";
                if ((propName == "Email") && !Regex.IsMatch(Email, ".+\\@.+\\..+"))
                    return "���������� ������� ���������� email";
                if ((propName == "Phone") && string.IsNullOrEmpty(Phone))
                    return "���������� ������� ����� ��������";
                if ((propName == "WillFeed") && !WillFeed.HasValue)
                    return "�������� ������ ������! ��������� �������� ������ ��� ���������� �� �������.";
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

        //    message.AppendFormat("������� ��������: {0}\n", WillFeed.Value ? "����������� ����������" : "�������� ���� �� ������� ����");
        //    message.AppendFormat("������: []", Answers);

        //    SmtpClient smtpClient = new SmtpClient();
        //    smtpClient.Send(new MailMessage("feedback@englishalbion.com.ua", "feedback@englishalbion.com.ua", Name + (WillFeed.Value ? " ����������� ���" : " ���������� �� ������� ����"), message.ToString()));

            
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
       
            [Required(ErrorMessage = "���������� ������� ���")]
            public string Name { get; set; }
            [EmailAddress]
            [Required(ErrorMessage = "���������� ���������� email")]
            public string Email { get; set; }
            [Required(ErrorMessage = "���������� ����� ��������")]
            public string Phone { get; set; }

            public string Comment { get; set; }
            [Required(ErrorMessage = "�������� ������ ������! ��������� �������� ������ ��� ���������� �� �������.")]
            public bool? WillFeed { get; set; }

            public List<char> Answers { get; set; }

            public string Error { get { return null; } }

            public string this[string propName]
            {
                get
                {
                    if ((propName == "Name") && string.IsNullOrEmpty(Name))
                        return "���������� ������� ���";
                    if ((propName == "Email") && !Regex.IsMatch(Email, ".+\\@.+\\..+"))
                        return "���������� ������� ���������� email";
                    if ((propName == "Phone") && string.IsNullOrEmpty(Phone))
                        return "���������� ������� ����� ��������";
                    if ((propName == "WillFeed") && !WillFeed.HasValue)
                        return "�������� ������ ������! ��������� �������� ������ ��� ���������� �� �������.";
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

            //    message.AppendFormat("������� ��������: {0}\n", WillFeed.Value ? "����������� ����������" : "�������� ���� �� ������� ����");
            //    message.AppendFormat("������: []", Answers);

            //    SmtpClient smtpClient = new SmtpClient();
            //    smtpClient.Send(new MailMessage("feedback@englishalbion.com.ua", "feedback@englishalbion.com.ua", Name + (WillFeed.Value ? " ����������� ���" : " ���������� �� ������� ����"), message.ToString()));


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
        [Required(ErrorMessage = "�� ���������� �����. ���������� �������� �� ��� �������.")]
        public char answer { get; set; }
        public KeyValuePair<char, string>[] Answers { get; set; }
        public string question { get; set; }

        public string comment { get; set; }
    }
}