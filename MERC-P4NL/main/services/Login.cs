using MERC_P4NL.main.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MERC_P4NL.main.services
{
    class Login
    {
        private FormController controller;
        public Login(FormController controller)
        {
            this.controller = controller;
        }

        public bool authenticate ()
        {
            try
            {
                //Handle login
            }
            catch (Exception e)
            {
                MessageBox.Show(e);
                return false;
            }
        }

        private void openLanding ()
        {
            controller.hideFormer();
            controller.showLatter();
        }
    }
}
