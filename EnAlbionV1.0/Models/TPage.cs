
namespace EnAlbionV1._0.Models
{
    using System.ComponentModel;
    using System.Text.RegularExpressions;
    using System.Net.Mail;
    using System.Linq;
    using System.Text;
    using System;
    using System.Collections.Generic;
    

    public class TPage : IDataErrorInfo
    {
              
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set; }
        public string Comment1 { get; set; }
        public string Comment2 { get; set; }
        public string Comment3 { get; set; }
        public string Comment4 { get; set; }
        public string Comment5 { get; set; }
        public string Comment6 { get; set; }
        public string Comment7 { get; set; }
        public string Comment8 { get; set; }
        public string Comment9 { get; set; }
        public string Comment10 { get; set; }
        public string Comment11 { get; set; }
        public string Comment12 { get; set; }
        public string Comment13 { get; set; }
        public string Comment14 { get; set; }
        public string Comment15 { get; set; }
        public string Comment16 { get; set; }
        public string Comment17 { get; set; }
        public string Comment18 { get; set; }
        public string Comment19 { get; set; }
        public string Comment20 { get; set; }
        public string Comment21 { get; set; }
        public string Comment22 { get; set; }
        public string Comment23 { get; set; }
        public string Comment24 { get; set; }

        

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
            message.AppendFormat("Comment: {0}\n", Comment);

            message.AppendFormat("1: {0}\n", Comment1);
            message.AppendFormat("2: {0}\n", Comment2);
            message.AppendFormat("3: {0}\n", Comment3);
            message.AppendFormat("4: {0}\n", Comment4);
            message.AppendFormat("5: {0}\n", Comment5);
            message.AppendFormat("6: {0}\n", Comment6);
            message.AppendFormat("7: {0}\n", Comment7);
            message.AppendFormat("8: {0}\n", Comment8);
            message.AppendFormat("9: {0}\n", Comment9);
            message.AppendFormat("10: {0}\n", Comment10);
            message.AppendFormat("11: {0}\n", Comment11);
            message.AppendFormat("12: {0}\n", Comment12);
            message.AppendFormat("13: {0}\n", Comment13);
            message.AppendFormat("14: {0}\n", Comment14);
            message.AppendFormat("15: {0}\n", Comment15);
            message.AppendFormat("16: {0}\n", Comment16);
            message.AppendFormat("17: {0}\n", Comment17);
            message.AppendFormat("18: {0}\n", Comment18);
            message.AppendFormat("19: {0}\n", Comment19);
            message.AppendFormat("20: {0}\n", Comment20);
            message.AppendFormat("21: {0}\n", Comment21);
            message.AppendFormat("22: {0}\n", Comment22);
            message.AppendFormat("23: {0}\n", Comment23);
            message.AppendFormat("24: {0}\n", Comment24);



           
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Send(new MailMessage("feedback@englishalbion.com.ua", "feedback@englishalbion.com.ua", Name , message.ToString()));
        }

        private void EnsureCurrentlyValid()
        {
            // Check that IDataErrorInfo.this[] returns null for every property
            var propsToValidate = new[] { "Name", "Email", "Phone" };
            bool isValid = propsToValidate.All(x => this[x] == null);
            if (!isValid)
            throw new InvalidOperationException("Can't submit invalid Test Page");
        }
    }

  
    
}