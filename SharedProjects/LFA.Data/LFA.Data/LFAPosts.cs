using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Data
{
    public class LFAPosts
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostDetail { get; set; }
        public DateTime PostDate { get; set; }
        public sbyte IsDeleted { get; set; }
        public int OwnerId { get; set; }
    }
}
