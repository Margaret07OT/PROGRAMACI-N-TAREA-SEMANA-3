using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace myapp.Models
{
    public class Formulario
    {
         [Display(Name = "First Name", Prompt = "Enter first Name")]
        public string? firstName {get; set;}
        
        [Display(Name = "Last Name", Prompt = "Enter Last Name")]
        public string? lastName {get; set;}

        [Display(Name = "Job Title", Prompt = "Enter your job Title")]
        public string? jobTitle {get; set;}   

        [Display(Name = "Highest level of education")]
        public string? level {get; set;}
       
       [Display(Name = "Sex")]
        public string? sex {get; set;}

        [Display(Name = "Years of experience:")]
        public string? years {get; set;}

        [Display(Name = "Date:")]
        [DataType(DataType.Date)]
        public string? date {get; set;}
    }
}