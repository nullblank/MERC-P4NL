using MERC_P4NL.main.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                var response = await client.From<UserModel>()
                  .Where(model => model.Id == id)
                  .Single();
                return response;
            } catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }


    }
}
