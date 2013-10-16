using Mvc.Mailer;
using EnAlbionV1._0.Models;
 

namespace EnAlbionV1._0.Mailers
{ 
    public class UserMailer : MailerBase, IUserMailer 	
	{
		public UserMailer()
		{
			MasterName="_Layout";
		}
		
		public virtual MvcMailMessage Feedback(Response resp)
		{
            ViewData.Model = resp;
           
			//ViewBag.Data = someObject;
			return Populate(x =>
			{
				x.Subject = resp.Name + (resp.WillFeed.Value ? " Перезвоните мне" : " Записаться на пробный урок");
				x.ViewName = "Feedback";
				x.To.Add("feedback@englishalbion.com.ua");
			});
		}
 
		public virtual MvcMailMessage TestPage(ResponseTest tresp)
		{
            ViewData.Model = tresp;
			//ViewBag.Data = someObject;
			return Populate(x =>
			{
                x.Subject = tresp.Name + (tresp.WillFeed.Value ? " Перезвоните мне" : " Записаться на пробный урок");
				x.ViewName = "TestPage";
                x.To.Add("feedback@englishalbion.com.ua");
			});
		}
 	}
}