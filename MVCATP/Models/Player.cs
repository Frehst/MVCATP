using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCATP.Models
{
    public class Player
    {
        public int PlayerID { get; set; }

        [Display(Name ="Name")]
        public string PlayerName { get; set; }

        [Display(Name = "Surname")]
        public string PlayerSurname { get; set; }

        public Coach Coach { get; set; }

        public int CoachID { get; set; }

        public Surface Surface { get; set; }

        public int SurfaceID { get; set; }

        public Country Country { get; set; }

        public int CountryID { get; set; }


        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Birthday { get; set; }

        public int Points { get; set; }
    }
}