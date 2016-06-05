using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Data
{
    public class LFAUsers
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public int RoleId { get; set; }        
    }
}
