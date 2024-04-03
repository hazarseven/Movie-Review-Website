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
    public class CommentSeedData : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData
                (
                    new Comment
                    {
                        Id = 1,
                        UserName = "johndoe",
                        UserComment = "This movie is awesome!",
                        MovieId = 1
                    },

                    new Comment
                    {
                        Id = 2,
                        UserName = "janedoe",
                        UserComment = "I love this movie!",
                        MovieId = 4
                    },

                    new Comment
                    {
                        Id = 3,
                        UserName = "alicesmith",
                        UserComment = "This movie is great!",
                        MovieId = 2
                    },

                    new Comment
                    {
                        Id = 4,
                        UserName = "bobsmith",
                        UserComment = "This movie is amazing!",
                        MovieId = 3
                    }
                );
        }
    }
}
