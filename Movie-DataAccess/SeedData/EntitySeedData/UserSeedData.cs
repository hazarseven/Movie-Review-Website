using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie_Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DataAccess.SeedData.EntitySeedData
{
    public class UserSeedData : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
                (
                    new User
                    {
                        Id = 1,
                        FirstName = "John",
                        LastName = "Doe",
                        UserName = "johndoe",
                        Email = "johndoe@gmail.com",
                        BirthDate = new DateTime(1990, 1, 1),
                        Password = "123"
                    },

                    new User
                    {
                        Id = 2,
                        FirstName = "Jane",
                        LastName = "Doe",
                        UserName = "janedoe",
                        Email = "janedoe@gmail.com",
                        BirthDate = new DateTime(1991, 1, 1),
                        Password = "123"
                    },

                    new User
                    {
                        Id = 3,
                        FirstName = "Alice",
                        LastName = "Smith",
                        UserName = "alicesmith",
                        Email = "alicesmith@gmail.com",
                        BirthDate = new DateTime(1992, 1, 1),
                        Password = "123"
                    },

                    new User
                    {
                        Id = 4,
                        FirstName = "Bob",
                        LastName = "Smith",
                        UserName = "bobsmith",
                        Email = "bobsmith@gmail.com",
                        BirthDate = new DateTime(1993, 1, 1),
                        Password = "123"
                    }
                );
        }
    }
}
