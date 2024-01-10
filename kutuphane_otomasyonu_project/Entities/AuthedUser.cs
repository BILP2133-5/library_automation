using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_otomasyonu_project.Entities
{
    public class AuthedUser
    {
        public string UserId { get; set; }
        public string UserToken { get; set; }
        public string UserRole { get; set; }
    }
}

