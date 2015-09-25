using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MeusPedidos.Models
{
    public class QuestionnaireModels
    {
        [Required(ErrorMessage = "Por favor informe seu Nome!")]
        [Display(Name = "Nome")]
        [StringLength(40)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Por favor informe seu Email!")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [RegularExpression("(10)|([0123456789])", ErrorMessage = "O campo Html aceita apenas de 0 a 10!")]
        [Display(Name = "Html")]
        public string Html { get; set; }

        [RegularExpression("(10)|([0123456789])", ErrorMessage = "O campo Css aceita apenas de 0 a 10!")]
        [Display(Name = "Css")]
        public string Css { get; set; }

        [RegularExpression("(10)|([0123456789])", ErrorMessage = "O campo JavaScript aceita apenas de 0 a 10!")]
        [Display(Name = "JavaScript")]
        public string JavaScript { get; set; }

        [RegularExpression("(10)|([0123456789])", ErrorMessage = "O campo Python aceita apenas de 0 a 10!")]
        [Display(Name = "Python")]
        public string Python { get; set; }

        [RegularExpression("(10)|([0123456789])", ErrorMessage = "O campo Django aceita apenas de 0 a 10!")]
        [Display(Name = "Django")]
        public string Django { get; set; }

        [RegularExpression("(10)|([0123456789])", ErrorMessage = "O campo Desenvolvimento iOS aceita apenas de 0 a 10!")]
        [Display(Name = "Desenvolvimento iOS")]
        public string DesIOS { get; set; }

        [RegularExpression("(10)|([0123456789])", ErrorMessage = "O campo Desenvolvimento Android aceita apenas de 0 a 10!")]
        [Display(Name = "Desenvolvimento Android")]
        public string DesAndroid { get; set; }
    }
}