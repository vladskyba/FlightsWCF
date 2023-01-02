using FlightsWCF.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace FlightsWCF.Context
{
    public class UserInitiallizer : DropCreateDatabaseIfModelChanges<FlightsWCFContext>
    {
        protected override void Seed(FlightsWCFContext context)
        {
            var users = new List<User>
            {
                new User
                {
                    FirstName = "Rambls",
                    LastName = "Rambls",
                    MiddleName = "Rambls",
                    Phone = "+380963888888"
                }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}