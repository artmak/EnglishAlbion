using EnAlbionV1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace EnAlbionV1._0.Controllers
{
    public class SchoolController : Controller
    {
        //
        // GET: /School/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult English()
        {
            return View();
        }

        public ActionResult English_business_rates()
        {
            return View();
        }
        public ActionResult German()
        {
            return View();
        }
        public ActionResult Chinese() 
        {
            return View();
        }
        public ActionResult French() 
        {
            return View();
        }
        public Response getResponse()
        { 
            var ret = new Response(new ResponseItem[]
            {
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "another pants"), 
                    new KeyValuePair<char, string>('b', "other pants"),
                    new KeyValuePair<char, string>('c', "the other ones"),
                    new KeyValuePair<char, string>('d',"another pair")
                }){ question="1. Because the first pair of shoes did not fit properly, he asked for ... . "},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "There are"), 
                    new KeyValuePair<char, string>('b', "The"),
                    new KeyValuePair<char, string>('c', "There is a lot of"),
                    new KeyValuePair<char, string>('d',"Some")
                }){ question="2. ... many computer software programs that possess excellent word-processing capabilities."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "to finish"), 
                    new KeyValuePair<char, string>('b', "finish "),
                    new KeyValuePair<char, string>('c', "finishing "),
                    new KeyValuePair<char, string>('d',"will have finished")
                }){ question="3. Woodrow Wilson believed the United States' entry into World War I would ... the war in months."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "The complete"), 
                    new KeyValuePair<char, string>('b', "Completing "),
                    new KeyValuePair<char, string>('c', "A completing "),
                    new KeyValuePair<char, string>('d',"The completion")
                }){ question="4. ... of New York's Erie Canal greatly enhanced trade in the upstate region."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "those"), 
                    new KeyValuePair<char, string>('b', "them "),
                    new KeyValuePair<char, string>('c', "they "),
                    new KeyValuePair<char, string>('d',"their")
                }){ question="5. Some of the oldest and most widespread creation myths are ... involving the 'Earth Mother'."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "the decade from"), 
                    new KeyValuePair<char, string>('b', "the decade since "),
                    new KeyValuePair<char, string>('c', "the past decade "),
                    new KeyValuePair<char, string>('d',"decade ago the")
                }){ question="6. In ... , compact disk technology has almost made record albums obsolete."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "how its parents to recognize"), 
                    new KeyValuePair<char, string>('b', "how to recognize its parents "),
                    new KeyValuePair<char, string>('c', "to be recognizing its parents "),
                    new KeyValuePair<char, string>('d',"the recognizing of its parents")
                }){ question="7. In the first few months of life, an infant learns how to lift its hands, how to smile and ... ."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "considered"), 
                    new KeyValuePair<char, string>('b', "considered to be"),
                    new KeyValuePair<char, string>('c', "is considered to be"),
                    new KeyValuePair<char, string>('d',"is consideration")
                }){ question="8. Juana Inez de la Cruz ... Mexico's greatest female poet."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "He reached"), 
                    new KeyValuePair<char, string>('b', "When did he reach"),
                    new KeyValuePair<char, string>('c', "Having reached"),
                    new KeyValuePair<char, string>('d',"Whether he reached")
                }){ question="9. ... what is now San Salvador, Christopher Columbus believed that he had found Japan."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "to study the stress experienced"), 
                    new KeyValuePair<char, string>('b', "study the experienced stress"),
                    new KeyValuePair<char, string>('c', "to study stress experiencing"),
                    new KeyValuePair<char, string>('d',"studying the stress experience")
                }){ question="10. The principal purpose of aviation medicine is ... by people aboard an aircraft in flight."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "the"), 
                    new KeyValuePair<char, string>('b', "an"),
                    new KeyValuePair<char, string>('c', "-"),
                }){ question="11. The queen of Great Britain is not ... absolute monarch."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "the"), 
                    new KeyValuePair<char, string>('b', "a"),
                    new KeyValuePair<char, string>('c', "-"),
                }){ question="12. Open ... door, please."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "in"), 
                    new KeyValuePair<char, string>('b', "into"),
                    new KeyValuePair<char, string>('c', "out"),
                    new KeyValuePair<char, string>('d',"-")
                }){ question="13. Are you standing in the corridor? Come ... please."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "of"), 
                    new KeyValuePair<char, string>('b', "in"),
                    new KeyValuePair<char, string>('c', "on"),
                    new KeyValuePair<char, string>('d', "for")
                }){ question="14. Who is ... duty today?"},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "at"), 
                    new KeyValuePair<char, string>('b', "-"),
                    new KeyValuePair<char, string>('c', "on"),
                    new KeyValuePair<char, string>('d', "in")
                }){ question="15. ... what languages are you speaking?"},
                 new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "around"), 
                    new KeyValuePair<char, string>('b', "in"),
                    new KeyValuePair<char, string>('c', "on"),
                    new KeyValuePair<char, string>('d', "over")
                }){ question="16. There is a picture ... sofa."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "is having"), 
                    new KeyValuePair<char, string>('b', "has been having"),
                    new KeyValuePair<char, string>('c', "had"),
                }){ question="17. Now she ... difficulty in putting fact in order."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "have taken"), 
                    new KeyValuePair<char, string>('b', "has been taking"),
                    new KeyValuePair<char, string>('c', "took"),
                }){ question="18. My brother ... music lessons for three years now."},
                 new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "will live"), 
                    new KeyValuePair<char, string>('b', "would live"),
                    new KeyValuePair<char, string>('c', "are living"),
                }){ question="19. Perhaps in the future men ... on the sea, away from the crowded and noisy cities on land."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "is"), 
                    new KeyValuePair<char, string>('b', "are"),
                    new KeyValuePair<char, string>('c', "am"),
                    new KeyValuePair<char, string>('d', "was")
                }){ question="20. There ... ten pens and a magazine on the table."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "could"), 
                    new KeyValuePair<char, string>('b', "might"),
                    new KeyValuePair<char, string>('c', "must"),
                }){ question="21. Police, fire fighters, newspaper reporters and radio broadcasters ... work on holiday in the USA."},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "Did ... have to"), 
                    new KeyValuePair<char, string>('b', "Had ... to "),
                    new KeyValuePair<char, string>('c', "Have ... had to"),
                    new KeyValuePair<char, string>('d', "=)")
                }){ question="22. ... you ... get up early yesterday to meet the delegation at the airport?"},
                new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "may"), 
                    new KeyValuePair<char, string>('b', "need"),
                    new KeyValuePair<char, string>('c', "must"),
                    new KeyValuePair<char, string>('d', "=)")
                }){ question="23. We ... learn from the past."},
                  new ResponseItem(new KeyValuePair<char, string>[]
                {
                    new KeyValuePair<char, string>('a', "few"), 
                    new KeyValuePair<char, string>('b', "a few"),
                    new KeyValuePair<char, string>('c', "some"),
                    new KeyValuePair<char, string>('d', "a lot of")
                }){ question="24. There are …(мало) foreign students in our Institute."},
                                
            }); 
   
            return ret;
        }
        [HttpGet]
        public ViewResult TestPage()
        {
               return View(getResponse());
            
        }
        [HttpPost]
        public ViewResult TestPage(Response resp)
        {
            resp.Submit();
            return View("Thanks", resp);
           
        }
        
    }
}
