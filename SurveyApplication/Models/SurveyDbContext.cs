using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SurveyApplication.Models
{
    public class SurveyDbContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public DbSet<UserFavouriteFood> UserFavouriteFood { get; set; }
    }
}