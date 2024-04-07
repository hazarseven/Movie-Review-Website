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
    public class RoleSeedData : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            var editor = new IdentityRole
            {
                Id = "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b",
                Name = "editor",
                NormalizedName = "EDITOR"
            };

            var member = new IdentityRole
            {
                Id = "f4f4f4f4-4f4f-4f4f-4f4f-4f4f4f4f4f4f",
                Name = "member",
                NormalizedName = "MEMBER"
            };

            builder.HasData(editor, member);
        }
    }
}
