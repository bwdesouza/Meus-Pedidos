using MeusPedidos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeusPedidos.Controllers
{
    public class QuestionnaireController : Controller
    {
        // GET: Questionnaire
        public ActionResult Index()
        {
            return View();
        }

        // POST: Questionnaire
        [HttpPost]
        public ActionResult Send(QuestionnaireModels model)
        {
            if (ModelState.IsValid)
            {                
                var html = Convert.ToInt32(model.Html);
                var css = Convert.ToInt32(model.Css);
                var javaScript = Convert.ToInt32(model.JavaScript);
                var python = Convert.ToInt32(model.Python);
                var django = Convert.ToInt32(model.Django);
                var desIOS = Convert.ToInt32(model.DesIOS);
                var desAndroid = Convert.ToInt32(model.DesAndroid);
                var subject = "Obrigado por se candidatar";

                if ((html >= 7 && html <= 10) && (css >= 7 && css <= 10) && (javaScript >= 7 && javaScript <= 10))
                {
                    var sendEmail = new SendEmailModels();
                    var body = "Obrigado por se candidatar, assim que tivermos uma vaga disponível " +
                               "para programador Front - End entraremos em contato";

                    var result = sendEmail.Email(model.Name, model.Email, subject, body);

                }
                if ((python >= 7 && python <= 10) && (django >= 7 && django <= 10))
                {
                    var sendemail = new SendEmailModels();
                    var body = "Obrigado por se candidatar, assim que tivermos uma vaga disponível " +
                               "para programador Back-End entraremos em contato.";

                    var result = sendemail.Email(model.Name, model.Email, subject, body);
                }
                if ((desIOS >= 7 && desIOS <= 10) || (desAndroid >= 7 && desAndroid <= 10))
                {
                    var sendEmail = new SendEmailModels();
                    var body = "Obrigado por se candidatar, assim que tivermos uma vaga disponível " +
                               "para programador Mobile entraremos em contato.";

                    var result = sendEmail.Email(model.Name, model.Email, subject, body);
                }
                else
                {
                    var sendEmail = new SendEmailModels();
                    var body = "Obrigado por se candidatar, assim que tivermos uma vaga disponível " +
                               "para programador entraremos em contato.";

                    var result = sendEmail.Email(model.Name, model.Email, subject, body);
                }                
            }
            //Não pode
            return View("ThankYou");
        }        
    }
}