using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCATP.Models
{
    public class Country
    {
        public int CountryID { get; set; }

        [Display(Name = "Country")]
        public string CountryName { get; set; }
    }
}