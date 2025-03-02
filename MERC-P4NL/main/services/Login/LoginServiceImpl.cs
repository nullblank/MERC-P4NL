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
        public UserModel user { get; set; }
        private LoginServiceJDBC loginServiceJDBC;

        public LoginServiceImpl (Supabase.Client client)
        {
            this.client = client;
            this.loginServiceJDBC = new LoginServiceJDBCImpl(client);
        }

        public async Task<bool> authenticate (int user, String auth)
        {
            try
            {
                var userModel = await loginServiceJDBC.getUserAsync(user);
                if (userModel == null) return false;

                this.user = userModel;
                return this.user?.Auth == auth;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
    }
}
