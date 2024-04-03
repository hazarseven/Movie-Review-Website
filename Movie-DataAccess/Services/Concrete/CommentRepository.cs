
using Movie_Core.Entities.Concrete;
using Movie_DataAccess.Context;
using Movie_DataAccess.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DataAccess.Services.Concrete
{
    public class CommentRepository : BaseRepository
        <Comment>, ICommentRepository
    {
        public CommentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
