using MERC_P4NL.main.enums;
using MERC_P4NL.main.forms;
using MERC_P4NL.main.helper;
using MERC_P4NL.main.services.DataSource;
using MERC_P4NL.main.services.Login;
using System.Drawing.Text;
using System.Threading.Tasks;

namespace MERC_P4NL
{
    public partial class LoginForm : Form
    {
        private DataSource dataSource = new DataSourceImpl();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#1e1e1e");
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            int user = 0;
            try
            {
                user = int.Parse(txtUsername.Text);
                this.authUser(user, txtPassword.Text);
            }
            catch (Exception a)
            {
                //Application.Exit();
            }
        }

        private async Task authUser(int user, String pass)
        {
            LoginService login = new LoginServiceImpl(dataSource.client);
            bool isAuth = await login.authenticate(user, pass);
            if (isAuth)
            {
                if (!login.user.Equals(null))
                {
                    MessageBox.Show("Welcome " + login.user.Mercenary);
                    Form_Landing form_Landing = new Form_Landing();
                    FormController formController = new FormController(this, form_Landing);
                    formController.hideFormer();
                    formController.showLatter();
                }

            }
            else
            {
                MessageBox.Show(MessagesEnums.global_failLogin, "Login Fail", MessageBoxButtons.OK);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
