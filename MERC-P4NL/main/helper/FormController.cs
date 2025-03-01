using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MERC_P4NL.main.helper
{
    class FormController
    {
        private Form former;
        private Form latter;
        public FormController(Form former, Form latter)
        {
            this.former = former;
            this.latter = latter;
        }

        public void hideFormer()
        {
            this.former.Hide();
        }

        public void showFormer()
        {
            this.former.Show();
        }

        public void hideLatter()
        {
            this.latter.Hide();
        }

        public void showLatter()
        {
            this.latter.Show();
        }
    }
}
