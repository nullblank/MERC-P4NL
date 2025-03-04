using MERC_P4NL.main.helper;
using MERC_P4NL.main.jdbc;
using MERC_P4NL.main.models;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MERC_P4NL.main.services.Login
{
    class LoginServiceImpl : LoginService
    {
        public Supabase.Client client { get; set; }
        public UserModel userModel { get; set; }

        public LoginServiceImpl (Supabase.Client client)
        {
            this.client = client;
        }

        public async Task<bool> authenticate (int user, String auth)
        {
            try
            {
                LoginServiceJDBC loginServiceJDBC = new LoginServiceJDBCImpl(client);
                UserModel userModel = await loginServiceJDBC.getUserAsync(user);
                if (userModel != null)
                {
                    if (userModel.Id == user && userModel.Auth == auth)
                    {
                        this.userModel = userModel;
                        return true;
                    }
                    else
                    {
                        this.userModel = null;
                        return false;
                    }
                } else
                {
                    this.userModel = null;
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
    }
}
