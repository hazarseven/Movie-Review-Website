using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DataAccess.SeedData.IdentitySeedData
{
    public class IdentityUserRoleSeedData : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b",
                    UserId = "f4f4f4f4-4f4f-4f4f-4f4f-4f4f4f4f4f4f"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "f4f4f4f4-4f4f-4f4f-4f4f-4f4f4f4f4f4f",
                    UserId = "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b"
                }
             );
        }
    }
}
