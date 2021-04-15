using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVCATP.Models;

namespace MVCATP.ViewModels
{
    public class PlayerFormViewModel
    {
        public IEnumerable<Country> Countries;

        public IEnumerable<Surface> Surfaces;

        public IEnumerable<Coach> Coaches;

        public int? PlayerID { get; set; }

        [Display(Name ="Player Name")]
        public string PlayerName { get; set; }

        [Display(Name = "Player Surname")]
        public string PlayerSurname { get; set; }

        [Display(Name = "Coach")]
        public int? CoachID { get; set; }

        [Display(Name ="Favourite surface")]
        public int SurfaceID { get; set; }


        [Display(Name = "Country")]

        public int CountryID { get; set; }


        public DateTime? Birthday { get; set; }

        public int Points { get; set; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - Birthday.Value.Year;
            }
        }
        public string Title
        {
            get
            {
                return PlayerID != 0 ? "Edit Player" : "Add Player";
            }
        }

        public PlayerFormViewModel()
        {
            PlayerID = 0;
        }

        public PlayerFormViewModel(Player player)
        {
            PlayerID = player.PlayerID;
            PlayerSurname = player.PlayerSurname;
            PlayerName = player.PlayerName;
            CoachID = player.CoachID;
            SurfaceID = player.SurfaceID;
            Birthday = player.Birthday;
            Points = player.Points;

        }

    }
}