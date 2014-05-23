using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iBunter.Models
{
    public class CompanyModel
    {
        [Display(Name="Facebook Account:")]
        public string Facebook{get;set;}

        [Display(Name = "Twitter Account:")]
        public string Twitter { get; set; }

        [Display(Name = "Linkedin Account:")]
        public string Linkedin { get; set; }

        [Display(Name = "First Name:")]
        public string FirstName { get; set; }

        [Display(Name = "Surname:")]
        public string Surname { get; set; }

        [Display(Name = "Company Name:")]
        [Required(ErrorMessage = "Please insert the company name.")]
        public string CompanyName { get; set; }

        [Display(Name = "Alias:")]
        public string Alias { get; set; }

        [Display(Name = "Website:")]
        public string Website { get; set; }

        [Display(Name = "Postcode:")]
        public string Postcode { get; set; }

        [Display(Name = "Street:")]
        public string Street { get; set; }

        [Display(Name = "Number:")]
        public string Number { get; set; }

        [Display(Name = "Country:")]
        public string Country { get; set; }

        [Display(Name = "State:")]
        public string State { get; set; }

        [Display(Name = "City:")]
        public string City { get; set; }

        [Display(Name = "Subject:")]
        [Required(ErrorMessage = "Please insert the subject.")]
        [StringLength(500, ErrorMessage = "The Subject cannot be longer than 500 characters.")]
        public string Subject { get; set; }

        [Display(Name = "Feedback:")]
        [Required(ErrorMessage = "Please insert the feedback.")]
        [StringLength(1500, ErrorMessage = "The feedback cannot be longer than 1500 characters.")]
        public string Feedback { get; set; }

        [Display(Name = "Rating:")]
        public List<Models.Rate> Rating { get; set; }   

    }
}