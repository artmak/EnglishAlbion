using EnAlbionV1._0.Models;
using Mvc.Mailer;

namespace EnAlbionV1._0.Mailers
{ 
    public interface IUserMailer
    {
			MvcMailMessage Feedback(Response resp);
            MvcMailMessage TestPage(ResponseTest tresp);
	}
}