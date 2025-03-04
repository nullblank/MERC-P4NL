using MERC_P4NL.main.models;
using Supabase.Postgrest.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MERC_P4NL.main.jdbc
{
    class LoginServiceJDBCImpl : LoginServiceJDBC
    {
        private Supabase.Client client;
        public LoginServiceJDBCImpl (Supabase.Client client)
        {
            this.client = client;
        }

        public async Task<UserModel> getUserAsync(int id)
        {
            try
            {
                UserModel userModel = new UserModel();
                var response = await client.From<UserModel>()
                  .Where(model => model.Id == id)
                  .Get();
                if (!response.Equals(null))
                {
                    userModel = response.Model;
                    return userModel;
                }
                return userModel ?? null;
            } catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }


    }
}
