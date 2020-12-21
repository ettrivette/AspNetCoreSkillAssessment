using AspNetCoreUi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreUi.Infrastructure
{
    public class DatabaseSeed
    {
        public async Task SeedContext(DatabaseContext context)
        {
            if (context.People.Any() == false)
            {
                context.People.Add(new Person()
                {
                    FirstName = "Eric",
                    LastName = "Trivette"
                });

                context.People.Add(new Person
                {
                    FirstName = "John",
                    LastName = "Doe"
                });

                await context.SaveChangesAsync();
            }
        }
    }
}
