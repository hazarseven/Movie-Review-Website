using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie_Core.Entities.UserEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DataAccess.SeedData.IdentitySeedData
{
    public class UserSeedData : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();

            var editor = new AppUser
            {
                Id = "f4f4f4f4-4f4f-4f4f-4f4f-4f4f4f4f4f4f",
                FirstName = "Editor",
                LastName = "Editor",
                BirthDate = new DateTime(1999, 01, 01),
                UserName = "editor",
                NormalizedUserName = "EDITOR",
                Email = "editor@test.com",
                NormalizedEmail = "EDITOR@TEST.COM",
                PasswordHash = hasher.HashPassword(null, "123")
            };

            var member = new AppUser
            {
                Id = "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b",
                FirstName = "Member",
                LastName = "Member",
                BirthDate = new DateTime(1999, 01, 01),
                UserName = "member",
                NormalizedUserName = "MEMBER",
                Email = "member@test.com",
                NormalizedEmail = "MEMBER@TEST.COM",
                PasswordHash = hasher.HashPassword(null, "123")
            };

            builder.HasData(editor, member);
        }
    }
}
