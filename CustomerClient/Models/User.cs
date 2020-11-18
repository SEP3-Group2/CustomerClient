using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerClient.Models
{
    public class User
    {
        public string UserName { get; set; }
        public int SecurityLevel { get; set; }
        public string Password { get; set; }
    }
}
