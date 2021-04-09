using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCATP.Models
{
    public class Player
    {
        public int PlayerID { get; set; }

        public string PlayerName { get; set; }

        public string PlayerSurname { get; set; }

        public Coach Coach { get; set; }

        public int CoachID { get; set; }

        public Surface Surface { get; set; }

        public int SurfaceID { get; set; }

        public Country Country { get; set; }

        public int CountryID { get; set; }

        public DateTime Birthday { get; set; }

        public int Points { get; set; }
    }
}