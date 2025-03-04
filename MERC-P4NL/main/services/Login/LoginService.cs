using MERC_P4NL.main.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MERC_P4NL.main.services.Login
{
    public interface LoginService
    {
        public Supabase.Client client { get; set; }
        public UserModel userModel { get; set; }
        public Task<bool> authenticate(int user, String auth);
    }
}
