using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Data
{
    public class LFAComments
    {
        public int CommentId { get; set; }
        public string Comment { get; set; }
        public int CommenterId { get; set; }
        public DateTime CommentDate { get; set; }
        public sbyte IsDeleted { get; set; }
    }
}
