using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI.Models
{
    public class BankAccountViewModel
    {
        [Display(Name = "Card Id")]
        public int CardID { get; set; }

        [RegularExpression(@"[A-Za-z]{1,}", ErrorMessage = "Input only one word with English characters, do not start with a space and do not finish them")]
        [Required(ErrorMessage = "Empty field. Fill in the field")]
        [StringLength(50, ErrorMessage = "Max length 50 characters")]
        [Display(Name = "First Name")]
        public string Name { get; set; }

        [RegularExpression(@"[A-Za-z]{1,}", ErrorMessage = "Input only one word with English characters, do not start with a space and do not finish them")]
        [Required(ErrorMessage = "Empty field. Fill in the field")]
        [StringLength(50, ErrorMessage = "Max length 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Amount")]
        public double Amount { get; set; }

        [Display(Name = "Bonus Amount")]
        public int BonusAmount { get; set; }

        [Display(Name = "Card Status")]
        public CardStatusEnum CardStatus { get; set; }
    }
}