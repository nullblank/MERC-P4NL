using MERC_P4NL.main.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MERC_P4NL.main.jdbc
{
    public interface LoginServiceJDBC
    {
        public Task<UserModel> getUserAsync(int id);
    }
}
