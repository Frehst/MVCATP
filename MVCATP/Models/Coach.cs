using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCATP.Models
{
    public class Coach
    {

        public int CoachID { get; set; }


        [Display(Name = "Coach Name")]
        public string CoachName { get; set; }


        [Display(Name = "Coach Surname")]
        public string CoachSurname { get; set; }

    }
}