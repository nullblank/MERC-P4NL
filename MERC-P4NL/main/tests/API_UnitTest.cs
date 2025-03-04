using MERC_P4NL.main.enums;
using MERC_P4NL.main.jdbc;
using MERC_P4NL.main.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MERC_P4NL.main.tests
{
    class API_UnitTest
    {
        public Supabase.Client client { get; set; }
        public API_UnitTest()
        {
            _ = test_connection();
        }

        private async Task test_connection()
        {
            var host = MercServerEnums.host;
            var key = MercServerEnums.key;
            var options = new Supabase.SupabaseOptions { AutoConnectRealtime = true };
            client = new Supabase.Client(host, key, options);
            await client.InitializeAsync();

            int user = 0;
            String auth = "admin";

            //var response = await client.From<UserModel>()
            //      .Where(model => model.Id == user)
            //      .Single();

            var response = await client.From<UserModel>().Get();

            MessageBox.Show(MessagesEnums.global_succCon + ": " + response);

            
            LoginServiceJDBC loginServiceJDBC = new LoginServiceJDBCImpl(client);
            //UserModel userModel = await loginServiceJDBC.getUserAsync(user);


        }
    }
}
