using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SurveyApplication.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public string Surname { get; set; }
     
        public string FirstName { get; set; }

        public string ContactNumber { get; set; }

        public DateTime Date { get; set; }

        public int Age { get; set; }

        //Navigation property that establish foreign key mapping
        public virtual List<UserFavouriteFood> UserFavouriteFood { get; set; }
    }
}