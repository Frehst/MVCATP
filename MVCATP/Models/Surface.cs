using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCATP.Models
{
    public class Surface
    {
        public int SurfaceID { get; set; }

        [Display(Name = "Favourite surface")]
        public string SurfaceName { get; set; }

    }
}