using MERC_P4NL.main.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MERC_P4NL.main.services.DataSource
{
    class DataSourceImpl : DataSource
    {
        private bool IsServerConnected = false;
        public Supabase.Client client { get; set; }
        public DataSourceImpl ()
        {
            this.serverInit();
        }

        private bool checkSucess()
        {
            connectToJDBC();
            if (IsServerConnected)
            {
                return true;
            } else
            {
                return false;
            }
        }

        private async void connectToJDBC()
        {
            try
            {
                //var url = Environment.GetEnvironmentVariable("JDBC_URL"); <- Debug
                //var key = Environment.GetEnvironmentVariable("JDBC_KEY"); <- Debug

                var host = MercServerEnums.host;
                var key = MercServerEnums.key;
                var options = new Supabase.SupabaseOptions { AutoConnectRealtime = true };
                client = new Supabase.Client(host, key, options);
                await client.InitializeAsync();
                MessageBox.Show(MessagesEnums.global_succCon);
                this.IsServerConnected = true;
            } catch (Exception e)
            {
                MessageBox.Show("Error accessing mercenary services. Contact Staff and send this: " + e.ToString());
                this.IsServerConnected = false;
                Application.Exit();
            }

        }

        private async void serverInit()
        {
            Form messageForm = new Form()
            {
                Text = "Checking...",
                Size = new System.Drawing.Size(300, 150),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                TopMost = true,
                ControlBox = false
            };

            Label label = new Label()
            {
                Text = "Checking server status...",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };

            messageForm.Controls.Add(label);
            messageForm.Show();
            await Task.Run(() => checkSucess());
            messageForm.Close();
        }
    }
}
